using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.Games.GPMagic.GPMagicBase
{
    public interface ICanRotate
    {
        /// <summary>
        /// 旋转卡牌
        /// </summary>
        /// <param name="angle">旋转的角度</param>
        void Rotate(int angle);

        /// <summary>
        /// 横置卡牌
        /// </summary>
        void Tapping();

        /// <summary>
        /// 颠倒卡牌
        /// </summary>
        void Round();

        /// <summary>
        /// 重置卡牌
        /// </summary>
        void Reset();
    }
}
