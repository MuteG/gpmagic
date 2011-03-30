using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.Games.GPMagic.GPMagic
{
    public class UpgradeEventArgs:EventArgs
    {
        /// <summary>
        /// 当前处理过程
        /// </summary>
        public string Process
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
        /// 当前处理占总过程的百分比
        /// </summary>
        public int TotalProcessPercent
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
        /// 当前处理过程进度
        /// </summary>
        public int DetailProcessPercent
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
