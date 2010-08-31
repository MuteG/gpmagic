using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model;
using GPSoft.GPMagic.GPMagicBase.UI;
using GPSoft.GPMagic.GPSearch.Common;
using GPSoft.GPMagic.GPMagicBase.Model.Deck;
using GPSoft.GPMagic.GPMagicBase.Module.Deck;

namespace GPSoft.GPMagic.GPSearch.UI
{
    partial class FormMain
    {
        private IDeck workDeck = new CNDeck();
        private DataTable deckTable = new DataTable();

        private void LoadDeckFilter()
        {
            tsbtnDeckFilterType.DropDownItems.Clear();
            foreach (ConfigDeckFilter deckFilter in CommonHelper.DeckFilterListConfiguration.DeckFilterList)
            {
                ToolStripMenuItem item = (ToolStripMenuItem)tsbtnDeckFilterType.DropDownItems.Add(deckFilter.DisplayName);
                item.Click += new EventHandler(item_Click);
                item.Checked = true;
                item.CheckOnClick = true;
                item.Visible = deckFilter.IsShow;
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            RefillDeckGridViewWithDeck();
        }

        private void RefillDeckGridViewWithDeck()
        {
            dgvDeckList.Rows.Clear();
            foreach (ConfigDeckFilter filter in CommonHelper.DeckFilterListConfiguration.DeckFilterList)
            {
                if (filter.IsShow)
                {
                    // 根据统计设定分类显示卡牌

                }
            }
        }

        private void AddDeckList(DeckCard card)
        {
            int index = GetCardIndexOfDeckGridView(card.CardID);
            if (index < 0)
            {
                card.Count = 1;
                this.workDeck.Deck.Cards.Add(card);
                int rowIndex = dgvDeckList.Rows.Add(1,
                                                    card.Symbol,
                                                    card.CardName,
                                                    card.ManaCost,
                                                    card.CardID);
                DataRow deckRow = this.Cards.Records.Select(string.Format("CardID={0}", card.CardID))[0];
                dgvDeckList.Rows[rowIndex].DefaultCellStyle.ForeColor =
                    CommonHelper.CardRarity.GetRarityColor(card.Rarity);
                this.workDeck.Deck.CardRecords.Rows.Add(deckRow.ItemArray);
            }
            else
            {
                AddDeckCardCount(index);
            }
        }

        private void AddDeckCardCount(int index)
        {
            int count = Convert.ToInt32(dgvDeckList.Rows[index].Cells["colDCount"].Value);
            dgvDeckList.Rows[index].Cells["colDCount"].Value = count + 1;
            DeckCard card = GetDeckCardFromWorkDeck((int)dgvDeckList.Rows[index].Cells["colDCardID"].Value);
            card.Count++;
        }

        private DeckCard GetDeckCardFromWorkDeck(int cardID)
        {
            DeckCard result = new DeckCard();
            foreach (DeckCard card in this.workDeck.Deck.Cards)
            {
                if (card.CardID == cardID)
                {
                    result = card;
                    break;
                }
            }
            return result;
        }

        private int GetCardIndexOfDeckGridView(int cardID)
        {
            int result = -1;
            foreach (DataGridViewRow row in dgvDeckList.Rows)
            {
                if (cardID == Convert.ToInt32(row.Cells["colDCardID"].Value))
                {
                    result = row.Index;
                    break;
                }
            }
            return result;
        }

        private void dgvDeckList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && !tsbtnLockDeck.Checked)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        {
                            // 修改为：左键点击入备
                            //AddDeckCardCount(e.RowIndex);
                            break;
                        }
                    case MouseButtons.Right:
                        {
                            // 修改为：右键点击回主
                            //SubDeckCardCount(e.RowIndex);
                            break;
                        }
                }
            }
        }

        private void SubDeckCardCount(int index)
        {
            int count = Convert.ToInt32(dgvDeckList.Rows[index].Cells["colDCount"].Value);
            if (count > 1)
            {
                dgvDeckList.Rows[index].Cells["colDCount"].Value = count - 1;
            }
            else
            {
                RemoveDeckCard(index);
            }
        }

        private void RemoveDeckCard(int deckGridViewIndex)
        {
            dgvDeckList.Rows.RemoveAt(deckGridViewIndex);
            DeckCard card = GetDeckCardFromWorkDeck((int)dgvDeckList.Rows[deckGridViewIndex].Cells["colDCardID"].Value);
            this.workDeck.Deck.Cards.Remove(card);
            foreach (DataRow deckRow in this.workDeck.Deck.CardRecords.Rows)
            {
                if (((int)deckRow["CardID"]) == card.CardID)
                {
                    deckRow.Delete();
                    break;
                }
            }
        }

        private void dgvDeckList_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 187:
                case 107:
                    {
                        //加号键
                        foreach (DataGridViewRow row in dgvDeckList.SelectedRows)
                        {
                            AddDeckCardCount(row.Index);
                        }
                        break;
                    }
                case 189:
                case 109:
                    {
                        //减号键
                        foreach (DataGridViewRow row in dgvDeckList.SelectedRows)
                        {
                            SubDeckCardCount(row.Index);
                        }
                        break;
                    }
                case 46:
                case 110:
                    {
                        //删除键
                        foreach (DataGridViewRow row in dgvDeckList.SelectedRows)
                        {
                            RemoveDeckCard(row.Index);
                        }
                        break;
                    }
            }
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.L:
                        {
                            tsbtnLockDeck.Checked = !tsbtnLockDeck.Checked;
                            break;
                        }
                }
            }
        }

        private void tsbtnSaveDeck_Click(object sender, EventArgs e)
        {
            List<string> items = GenerateSaveFormatList();
            int index = RadioButtonDialog.Show("保存格式", items);
            if (index >= 0)
            {
                string formatText = items[index];
                SetSaveFileDialogFilter(formatText);
                SaveDeck(formatText);
            }
        }

        private void SaveDeck(string formatText)
        {
            if (this.workDeck.DeckFullPath.Length > 0)
            {
                OutputDeckFile(this.workDeck.DeckFullPath, formatText);
            }
            else
            {
                saveFileDialog1.Title = "保存牌表";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    OutputDeckFile(saveFileDialog1.FileName, formatText);
                }
            }
        }

        private void OutputDeckFile(string deckName, string formatText)
        {
            IDeck saveDeck = new CNDeck();
            if (formatText.Equals(DeckSaveFormat.CnList))
            {
                saveFileDialog1.Filter = "中文牌表|*.txt";
                saveDeck = new CNDeck();
            }
            else if (formatText.Equals(DeckSaveFormat.Mws))
            {
                saveFileDialog1.Filter = "MWS牌表格式|*.mwDeck";
                saveDeck = new MWSDeck();
            }
            foreach (DataRow row in this.workDeck.Deck.CardRecords.Rows)
            {
                saveDeck.Deck.CardRecords.ImportRow(row);
            }
            saveDeck.Deck.Cards.AddRange(this.workDeck.Deck.Cards);
            saveDeck.Save(deckName);
        }

        private int GetCardCountFromDeckList(int cardID)
        {
            int result = 0;
            foreach (DataGridViewRow row in dgvDeckList.Rows)
            {
                if (cardID == Convert.ToInt32(row.Cells["colDCardID"].Value))
                {
                    result = Convert.ToInt32(row.Cells["colDCount"].Value);
                    break;
                }
            }
            return result;
        }

        private List<string> GenerateSaveFormatList()
        {
            List<string> result = new List<string>();
            result.Add(DeckSaveFormat.Mws);
            //items.Add("GPMagic");
            result.Add(DeckSaveFormat.CnList);
            return result;
        }

        private void SetSaveFileDialogFilter(string formatText)
        {
            if (formatText.Equals(DeckSaveFormat.CnList))
            {
                saveFileDialog1.Filter = "中文牌表|*.txt";
            }
            else if (formatText.Equals(DeckSaveFormat.Mws))
            {
                saveFileDialog1.Filter = "MWS牌表格式|*.mwDeck";
            }
        }

        private void mnuItemDeckFilterSetting_Click(object sender, EventArgs e)
        {
            using (FormEditDeckFilter form = new FormEditDeckFilter())
            {
                form.ShowDialog(this);
            }
        }

        private void tsbtnOpenDeck_Click(object sender, EventArgs e)
        {
            if (ofdDeck.ShowDialog() == DialogResult.OK)
            {
                switch (ofdDeck.FilterIndex)
                {
                    case 1: // 中文牌表
                        {
                            this.workDeck = new CNDeck();
                            this.workDeck.Load(ofdDeck.FileName);
                            break;
                        }
                    case 2: // MWS牌表格式
                        {
                            this.workDeck = new MWSDeck();
                            this.workDeck.Load(ofdDeck.FileName);
                            break;
                        }
                }
                RefillDeckGridViewWithDeck();
            }
        }
    }
}
