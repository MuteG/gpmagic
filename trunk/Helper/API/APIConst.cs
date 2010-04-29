/*
 *********************************************************************
 * 程序名称 : Helper（辅助功能类）
 * 类名称   : APIConst
 * 说明     : 提供系统API使用到的常量
 * 作者     : 高云鹏
 * 作成日期 : 2008-10-27
 * 修改履历 :
 * 日期         修改者  程序版本    类型    理由
 * 
 *********************************************************************
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace GPSoft.Helper.API
{
    /// <summary>
    /// API函数用到的常量
    /// </summary>
    public class APIConst
    {
        /// <summary>
        /// 常量，Windows消息，横向滚动
        /// </summary>
        public const int WIN_MESSAGE_WS_HSCROLL = 0x0114;
        /// <summary>
        /// 常量，Windows消息，纵向滚动
        /// </summary>
        public const int WIN_MESSAGE_WS_VSCROLL = 0x0115;
        /// <summary>
        /// 常量，Windows消息，控制
        /// </summary>
        public const int WIN_MESSAGE_WM_SYSCOMMAND = 0x0112;
        public const int WIN_MESSAGE_WM_NCLBUTTONDOWN = 0x00A1;
        /// <summary>
        /// 常量，Windows消息，滚动条向下滚动
        /// </summary>
        public const int WIN_PARAM_SB_LINEDOWN = 1;
        /// <summary>
        /// 常量，Windows消息，滚动条向左滚动
        /// </summary>
        public const int WIN_PARAM_SB_LINELEFT = 0;
        /// <summary>
        /// 常量，Windows消息，滚动条向右滚动
        /// </summary>
        public const int WIN_PARAM_SB_LINERIGHT = 1;
        /// <summary>
        /// 常量，Windows消息，滚动条向上滚动
        /// </summary>
        public const int WIN_PARAM_SB_LINEUP = 0;
        /// <summary>
        /// 常量，Windows消息，移动
        /// </summary>
        public const int WIN_PARAM_SC_MOVE = 0xF010;
        /// <summary>
        /// 常量，Windows消息，改变大小
        /// </summary>
        public const int WIN_PARAM_SC_SIZE = 0xF000;
        /// <summary>
        /// 常量，Windows消息，标题
        /// </summary>
        public const int WIN_PARAM_HTCAPTION = 0x0002;
        /// <summary>
        /// 常量，Windows消息，左侧改变大小，配合WIN_PARAM_SC_SIZE使用
        /// </summary>
        public const int WIN_PARAM_HTLEFT = 1;
        /// <summary>
        /// 常量，Windows消息，右侧改变大小，配合WIN_PARAM_SC_SIZE使用
        /// </summary>
        public const int WIN_PARAM_HTRIGHT = 2;
        /// <summary>
        /// 常量，Windows消息，顶部改变大小，配合WIN_PARAM_SC_SIZE使用
        /// </summary>
        public const int WIN_PARAM_HTTOP = 3;
        /// <summary>
        /// 常量，Windows消息，左上改变大小，配合WIN_PARAM_SC_SIZE使用
        /// </summary>
        public const int WIN_PARAM_HTTOPLEFT = 4;
        /// <summary>
        /// 常量，Windows消息，右上改变大小，配合WIN_PARAM_SC_SIZE使用
        /// </summary>
        public const int WIN_PARAM_HTTOPRIGHT = 5;
        /// <summary>
        /// 常量，Windows消息，底部改变大小，配合WIN_PARAM_SC_SIZE使用
        /// </summary>
        public const int WIN_PARAM_HTBOTTOM = 6;
        /// <summary>
        /// 常量，Windows消息，左下改变大小，配合WIN_PARAM_SC_SIZE使用
        /// </summary>
        public const int WIN_PARAM_HTBOTTOMLEFT = 7;
        /// <summary>
        /// 常量，Windows消息，右下改变大小，配合WIN_PARAM_SC_SIZE使用
        /// </summary>
        public const int WIN_PARAM_HTBOTTOMRIGHT = 8;
    }
    
}
