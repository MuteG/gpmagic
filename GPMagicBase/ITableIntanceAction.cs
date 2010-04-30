using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.GPMagic.GPMagicBase
{
    public interface ITableIntanceAction
    {
        /// <summary>
        /// 再次读入数据
        /// </summary>
        void Reload();

        /// <summary>
        /// 保存数据
        /// </summary>
        void Save();

        /// <summary>
        /// 在指定位置插入记录
        /// </summary>
        void InsertAt();

        /// <summary>
        /// 新建一条记录
        /// </summary>
        void NewRecord();

        /// <summary>
        /// 在尾部追加一条记录
        /// </summary>
        void Append();

        /// <summary>
        /// 删除一条数据
        /// </summary>
        void Remove();
    }
}
