using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using GPSoft.GPMagic.GPMagic.Model;

namespace GPSoft.GPMagic.GPMagic.UI
{
    public partial class MagicCardBase : UserControl
    {
        public MagicCardBase()
        {
            InitializeComponent();
        }

        private Image image;

        public Image Image
        {
            set
            {
                SetImage(value);
                image = value;
            }
            get
            {
                return image;
            }
        }

        /// <summary>
        /// 卡牌异能
        /// </summary>
        public List<Abilities> Abilities
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌名称
        /// </summary>
        public string CardName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌收集编号(在系列中的索引号)
        /// </summary>
        public int CollectorNumber
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌介绍(背景描述)
        /// </summary>
        public string Comment
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 法术力费用
        /// </summary>
        public ManaCost ManaCost
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌画家
        /// </summary>
        public string Painter
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌攻击力
        /// </summary>
        public int Power
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌副类别
        /// </summary>
        public List<CardSubType> CardSubType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌所属系列
        /// </summary>
        public Symbol Symbol
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌防御力
        /// </summary>
        public int Toughness
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 卡牌类别
        /// </summary>
        public CardType CardType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void SetImage(Image image)
        {
            this.BackgroundImage = image;
        }
    }

    public struct ManaCost
    {
        /// <summary>
        /// 红色法术力费用
        /// </summary>
        public int Red
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 白色法术力费用
        /// </summary>
        public int White
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 蓝色法术力费用
        /// </summary>
        public int Blue
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 黑色法术力费用
        /// </summary>
        public int Black
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// 绿色法术力费用
        /// </summary>
        public int Green
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
