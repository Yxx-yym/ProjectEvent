﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEvent.UI.Types
{
    /// <summary>
    /// 用于UI的ActionType
    /// </summary>
    public enum ActionType
    {
        /// <summary>
        /// 创建文件
        /// </summary>
        WriteFile = 1,
        /// <summary>
        /// 判断开始
        /// </summary>
        IF = 2,
        /// <summary>
        /// 否则
        /// </summary>
        IFElse = 3,
        /// <summary>
        /// 判断结束
        /// </summary>
        IFEnd = 4,
        /// <summary>
        /// HTTP请求
        /// </summary>
        HttpRequest = 5,
        /// <summary>
        /// 关机
        /// </summary>
        Shutdown = 6,
        /// <summary>
        /// 启动进程
        /// </summary>
        StartProcess = 7,
        /// <summary>
        /// 使用浏览器打开网页
        /// </summary>
        OpenURL = 8,
        /// <summary>
        /// 截屏
        /// </summary>
        Snipping = 9,
        /// <summary>
        /// 删除文件
        /// </summary>
        DeleteFile = 10,
        /// <summary>
        /// 播放声音
        /// </summary>
        SoundPlay = 11,
        /// <summary>
        /// 获取ip地址
        /// </summary>
        GetIPAddress = 12,
        /// <summary>
        /// 键盘操作
        /// </summary>
        Keyboard
    }
}
