using System;
using System.Collections.Generic;
using System.Text;

namespace GP.GPMagic.GPMagicBase
{
    public interface IMagicCardAction
    {
        /// <summary>
        /// 当卡牌翻转时触发动作
        /// </summary>
        event EventHandler OnReverse;

        /// <summary>
        /// 当卡牌旋转时触发动作
        /// </summary>
        event EventHandler OnRotate;

        /// <summary>
        /// 当卡牌进入战场时触发动作
        /// </summary>
        event EventHandler OnEnterBattlefield;

        /// <summary>
        /// 当卡牌离开战场时触发动作
        /// </summary>
        event EventHandler OnLeaveBattlefield;

        /// <summary>
        /// 将卡牌保存成图片
        /// </summary>
        /// <param name="imagePath">保存卡牌的路径</param>
        void SaveImage(string imagePath);

        /// <summary>
        /// 读取指定卡牌图片
        /// </summary>
        /// <param name="imagePath">卡牌图片路径</param>
        void LoadImage(string imagePath);

        /// <summary>
        /// 翻转卡牌
        /// </summary>
        void Reverse();

        /// <summary>
        /// 卡牌进入墓地
        /// </summary>
        void EnterCemetery();

        /// <summary>
        /// 放逐卡牌
        /// </summary>
        void Exile();
    }
}
