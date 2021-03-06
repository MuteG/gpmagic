﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GPSoft.Games.GPMagic.GPMagicBase.Model.Database
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
        void Save(object saveObject);

        /// <summary>
        /// 保存数据
        /// </summary>
        void Save(DataRow saveRow);

        /// <summary>
        /// 新建一条记录
        /// </summary>
        /// <param name="newObject">要添加的表实例</param>
        void Add(object newObject);
        /// <summary>
        /// 新建一条记录
        /// </summary>
        /// <param name="newRow">要添加的数据行</param>
        void Add(System.Data.DataRow newRow);

        /// <summary>
        /// 删除一条数据
        /// </summary>
        void Remove(object deleteObject);

        /// <summary>
        /// 删除一条数据
        /// </summary>
        void Remove(DataRow deleteRow);
    }
}
