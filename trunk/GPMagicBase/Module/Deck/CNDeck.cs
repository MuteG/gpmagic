using System;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagicBase.Model.Deck;
using GPSoft.GPMagic.GPMagicBase.SQLite;
using GPSoft.Helper.Files;

namespace GPSoft.GPMagic.GPMagicBase.Module.Deck
{
    public class CNDeck : AbstractDeck
    {
        private const string SIDEBOARD = "备牌：";
        #region IDeck 成员

        public override void Load(string deckFullPath)
        {
            if (File.Exists(deckFullPath))
            {
                this.DeckFullPath = deckFullPath;
                string[] allLines = File.ReadAllLines(deckFullPath);
                StringBuilder notExistCardMessage = new StringBuilder();
                StringBuilder noEffectCardMessage = new StringBuilder();
                string sql = "SELECT * FROM ListCardTotal WHERE Symbol='{0}' AND CardName='{1}' LIMIT 1";
                string regex = @"^(" + SIDEBOARD + @")?\d+ \[\w+\] [\u4e00-\u9fa5]+ [\p{L}\p{N}]+$";
                Deck.Cards.Clear();
                Deck.CardRecords.Rows.Clear();
                foreach (string line in allLines)
                {
                    string content = line.Trim();
                    if (!content.StartsWith(SIDEBOARD) && content.Length > 0)
                    {
                        if (Regex.IsMatch(content, regex))
                        {
                            bool isSideboard = content.StartsWith(SIDEBOARD);
                            string[] cardInfo = content.Replace(SIDEBOARD, string.Empty).Split(' ');
                            DeckCard card = new DeckCard();
                            card.Count = Convert.ToInt32(cardInfo[0]);
                            card.Symbol = cardInfo[1].Substring(1, cardInfo[1].Length - 2);
                            card.CardName = string.Join(" ", cardInfo, 2, cardInfo.Length - 3);

                            using (DataTable table = dbOperator.ExecuteDataTableScript(string.Format(sql, card.Symbol, card.CardName)))
                            {
                                if (table != null && table.Rows.Count > 0)
                                {
                                    Deck.CardRecords.Rows.Add(table.Rows[0].ItemArray);
                                    Deck.Name = Path.GetFileNameWithoutExtension(deckFullPath);
                                    Deck.Description = "中文牌表信息";
                                    card.CardID = Convert.ToInt32(table.Rows[0]["CardID"]);
                                    card.CardName = table.Rows[0]["CardName"].ToString();
                                    card.ManaCost = table.Rows[0]["ManaCost"].ToString();
                                    if (isSideboard)
                                    {
                                        Deck.SideboardCards.Add(card);
                                    }
                                    else
                                    {
                                        Deck.Cards.Add(card);
                                    }
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
                    MessageBox.Show(message, "警告信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public override void Save(string deckFullPath)
        {
            if (File.Exists(deckFullPath))
            {
                File.WriteAllText(deckFullPath, string.Empty);
            }
            else
            {
                File.Create(deckFullPath).Close();
            }
            StringBuilder content = new StringBuilder();
            StringBuilder sideboardContent = new StringBuilder();
            foreach (DeckCard card in this.Deck.Cards)
            {
                string cardInfo = string.Format("{0} [{1}] {2} {3}", 
                                                card.Count, 
                                                card.Symbol, 
                                                card.CardName,
                                                card.ManaCost);
                content.AppendLine(cardInfo);
            }
            foreach (DeckCard card in this.Deck.SideboardCards)
            {
                string cardInfo = string.Format("{4}{0} [{1}] {2} {3}",
                                                card.Count,
                                                card.Symbol,
                                                card.CardName,
                                                card.ManaCost,
                                                SIDEBOARD);
                sideboardContent.AppendLine(cardInfo);
            }
            
            content.Append(sideboardContent.ToString().Trim());
            File.AppendAllText(deckFullPath, content.ToString(), Encoding.UTF8);
        }

        #endregion
    }
}
