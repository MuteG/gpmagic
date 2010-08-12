using System;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model.Deck;
using GPSoft.GPMagic.GPMagicBase.SQLite;
using GPSoft.Helper.FileOperate;

namespace GPSoft.GPMagic.GPMagicBase.Module.Deck
{
    public sealed class MWSDeck : IDeck
    {
        private DatabaseOperator dbOperator = new DatabaseOperator();
        private DeckFile deck = new DeckFile();

        public DeckFile Deck
        {
            get { return deck; }
        }
        #region IDeck 成员

        public void Load(string deckFullPath)
        {
            if (File.Exists(deckFullPath))
            {
                string[] allLines = File.ReadAllLines(deckFullPath);
                StringBuilder notExistCardMessage = new StringBuilder();
                StringBuilder noEffectCardMessage = new StringBuilder();
                string sql = "SELECT TOP 1 * FROM ListCardTotal WHERE Symbol='{0}' AND CardEnglishName='{1}'";
                deck.Cards.Clear();
                deck.CardRecords.Rows.Clear();
                foreach (string line in allLines)
                {
                    string content = line.Trim();
                    if (!content.StartsWith("//") && content.Length > 0)
                    {
                        if (Regex.IsMatch(content, @"^\d+ [\w+] [\p{L}\p{N}\p{P}\p{S}]+$"))
                        {
                            string[] cardInfo = content.Split(' ');
                            DeckCard card = new DeckCard();
                            card.Count = Convert.ToInt32(cardInfo[0]);
                            card.Symbol = cardInfo[1].Substring(1, cardInfo[1].Length - 2);
                            card.CardEnglishName = cardInfo[2];

                            using (DataTable table = dbOperator.ExecuteDataTableScript(string.Format(sql, card.Symbol, card.CardEnglishName)))
                            {
                                if (table.Rows.Count > 0)
                                {
                                    deck.CardRecords.Rows.Add(table.Rows[0].ItemArray);
                                    deck.Name = Path.GetFileNameWithoutExtension(deckFullPath);
                                    deck.Description = "没有说明信息（MWS牌表没有此信息）";
                                    card.CardID = Convert.ToInt32(table.Rows[0]["CardID"]);
                                    card.CardName = table.Rows[0]["CardName"].ToString();
                                    deck.Cards.Add(card);
                                }
                                else
                                {
                                    if (notExistCardMessage.Length == 0)
                                    {
                                        notExistCardMessage.AppendLine("下列卡牌信息不存在：");
                                    }
                                    notExistCardMessage.AppendLine(string.Format("卡牌系列：{0}，卡牌名称：{1}，卡牌数量：{2}",
                                                                                 card.Symbol,
                                                                                 card.CardEnglishName,
                                                                                 card.Count));
                                }
                            }
                        }
                        else
                        {
                            if (noEffectCardMessage.Length == 0)
                            {
                                noEffectCardMessage.AppendLine();
                                noEffectCardMessage.AppendLine("下列信息无效：");
                            }
                            noEffectCardMessage.AppendLine(content);
                        }
                    }
                }
                string message = notExistCardMessage.ToString() + noEffectCardMessage.ToString();
                if (message.Length > 0)
                {
                    MessageBox.Show(message, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void Save(string deckFullPath)
        {
            if (File.Exists(deckFullPath))
            {
                File.WriteAllText(deckFullPath, string.Empty);
            }
            else
            {
                File.Create(deckFullPath).Close();
            }
            StringBuilder sideboardContent = new StringBuilder();
            sideboardContent.AppendLine("// Sideboard");
            StringBuilder landContent = new StringBuilder();
            landContent.AppendLine("// Lands");
            StringBuilder creatureContent = new StringBuilder();
            creatureContent.AppendLine("// Creatures");
            StringBuilder spellContent = new StringBuilder();
            spellContent.AppendLine("// Spells");
            foreach (DeckCard card in this.Deck.Cards)
            {
                string cardInfo = string.Format("    {0} [{1}] {2}", card.Count, card.Symbol, card.CardEnglishName);
                string sql = string.Format("Symbol='{0}' AND CardEnglishName='{1}'", card.Symbol, card.CardEnglishName);
                string cardType = this.Deck.CardRecords.Select(sql)[0]["TypeName"].ToString();
                if (cardType.Contains("地"))
                {
                    landContent.AppendLine(cardInfo);
                }
                else if (cardType.Contains("生物"))
                {
                    creatureContent.AppendLine(cardInfo);
                }
                else
                {
                    spellContent.AppendLine(cardInfo);
                }
            }
            foreach (DeckCard card in this.Deck.SideboardCards)
            {
                string cardInfo = string.Format("SB: {0} [{1}] {2}", card.Count, card.Symbol, card.CardEnglishName);
                sideboardContent.AppendLine(cardInfo);
            }
            StringBuilder content = new StringBuilder();
            content.AppendLine("// Deck file for Magic Workstation (http://www.magicworkstation.com)");
            content.AppendLine("// GPMagic (http://code.google.com/p/gpmagic/)");
            content.AppendLine();
            content.AppendLine(landContent.ToString());
            content.AppendLine(creatureContent.ToString());
            content.AppendLine(spellContent.ToString());
            content.Append(sideboardContent.ToString().Trim());
            FileHelper.WriteToFile(deckFullPath, content.ToString());
        }

        #endregion
    }
}
