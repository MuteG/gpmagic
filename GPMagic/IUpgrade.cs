using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.Games.GPMagic.GPMagic
{
    public interface IUpgrade
    {
        /// <summary>
        /// 当开始进行更新处理时触发的动作
        /// </summary>
        event OnUpgradeEventHandler OnUpgrade;
        /// <summary>
        /// 更新时需要访问的URL
        /// </summary>
        string UpgradeURL
        {
            get;
            set;
        }

        /// <summary>
        /// 更新时需要访问的URL可选列表
        /// </summary>
        List<string> UpgradeURLList
        {
            get;
            set;
        }

        /// <summary>
        /// 要进行更新的模块的名字
        /// </summary>
        string UpgradModelName
        {
            get;
            set;
        }
        /// <summary>
        /// 进行软件更新
        /// </summary>
        /// <param name="upgradeModelName">要进行更新的模块的名字</param>
        /// <param name="model">要进行更新的模块的类型</param>
        void DoUpgrade(string upgradeModelName, ModelType model);

        /// <summary>
        /// 检查更新站点是否可用
        /// </summary>
        /// <param name="url">需要检查的站点路径</param>
        bool CheckUpgradeSite(string url);

        /// <summary>
        /// 获得更新文件的URL
        /// </summary>
        /// <remarks>根据模块名称查找最新版本的模块，可以获得最新模块的版本号和MD5码</remarks>
        /// <param name="version">最新模块的版本号</param>
        /// <param name="md5">最新模块的MD5</param>
        /// <returns>返回获得更新文件的URL是否成功</returns>
        bool GetUpgradeURL(out string version, out string md5);

        /// <summary>
        /// 获得更新的模块文件
        /// </summary>
        /// <param name="upgradeURL">更新文件的URL</param>
        bool GetUpgradeModel(string upgradeURL);

        /// <summary>
        /// 对模块进行更新
        /// </summary>
        bool UpgradeModel();

        /// <summary>
        /// 检查本地文件是否需要更新
        /// </summary>
        /// <param name="version">最新模块的版本号</param>
        /// <param name="md5">最新模块的MD5</param>
        /// <returns>如果需要更新返回true，否则返回false</returns>
        bool CheckVersion(string version, string md5);
    }
}
