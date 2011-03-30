using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace GPSoft.Games.GPMagic.GPMagic.Model
{
    public class CardProperties
    {
        private List<CardProperty> cardPopertyList = new List<CardProperty>();
        /// <summary>
        /// 获取或者设置卡牌属性列表
        /// </summary>
        public List<CardProperty> CardPropertyList
        {
            get { return cardPopertyList; }
            set { cardPopertyList = value; }
        }
        /// <summary>
        /// 获得卡牌的属性名与实际值的字典
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetCardPropertiesDictionary()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            try
            {
                foreach (CardProperty prop in this.cardPopertyList)
                {
                    if(!result.ContainsKey(prop.Name)){
                        result.Add(prop.Name, prop.ConvertToTrueValue());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }

    public class CardProperty
    {
        private string name;
        /// <summary>
        /// 获取或者设置卡牌属性的名称
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private string value;
        /// <summary>
        /// 获取或者设置卡牌属性的值
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        private string trueType;
        /// <summary>
        /// 获取或者设置卡牌属性的实际数据类型
        /// </summary>
        public string TrueType
        {
            get { return this.value; }
            set { this.trueType = value.ToUpper(); }
        }
        /// <summary>
        /// 将卡牌属性的值，根据指定的类型，转换成实际的值
        /// </summary>
        /// <returns></returns>
        public object ConvertToTrueValue()
        {
            object result = null;

            switch (this.trueType)
            {
                case ConstClass.TYPESTR_INT:
                    {
                        result = Convert.ToInt32(this.value);
                        break;
                    }
                case ConstClass.TYPESTR_STRING:
                    {

                        break;
                    }
                case ConstClass.TYPESTR_IMAGE:
                    {
                        if (File.Exists(this.value))
                        {
                            result = Image.FromFile(this.value);
                        }
                        break;
                    }
            }
            return result;
        }
    }
}
