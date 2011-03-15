/*
 *********************************************************************
 * 程序名称 : Helper（辅助功能类）
 * 类名称   : 
 * 说明     : 
 * 作者     : 高云鹏
 * 作成日期 : 2008-10-27
 * 修改履历 :
 * 日期         修改者  程序版本    类型    理由
 * 2008-10-27   高云鹏  1.0.0.0     新规    初次做成
 * 2008-12-18   高云鹏  1.0.0.0     修改    写日志函数加入异常处理，防止日志文件被占用时抛出异常
 * 2009-07-06   高云鹏  1.0.0.4     修改    修改数据库查询的方法，使之支持返回值
 * 2009-07-14   高云鹏  1.0.0.5     修改    ①加入工厂方法
 *                                          ②加入输出空行的方法
 * 2009-07-16   高云鹏  1.0.0.6     添加    加入数据库操作的日志输出类型
 * 2009-07-30   高云鹏  1.0.0.7     添加    文件夹删除时加入是否删除根目录的可选标志
 *                                  添加    添加删除文件列表的方法
 * 2009-11-17   高云鹏  1.0.0.8     添加    添加画像旋转功能函数
 * 2009-12-10   高云鹏  1.0.0.10    添加    添加BitmapManipulator、ManagerImage两个类（来源于网络）
 * 2009-12-10   高云鹏  1.0.0.10    添加    添加获得当前程序正在运行的实例（二重启动）的函数
 * 2010-02-04   高云鹏  1.0.0.11    修改    修改获得当前程序正在运行的实例（二重启动）的函数
 * 2010-03-01   高云鹏  1.0.0.12    添加    添加TiffManager类（来源于网络）
 * 2010-03-05   高云鹏  1.0.0.13    修改    修改MergeImageToBitmap方法，使合并前后的画像DPI一致，否则容易引起错误
 * 2011-03-13   高云鹏  1.0.0.14    修改    修改目录结构以及命名空间
 *********************************************************************
 */
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的常规信息通过下列属性集
// 控制。更改这些属性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("Helper")]
[assembly: AssemblyDescription("辅助功能DLL")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("O-RID")]
[assembly: AssemblyProduct("Helper")]
[assembly: AssemblyCopyright("Copyright © GPSoft 2008-2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 使此程序集中的类型
// 对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型，
// 则将该类型上的 ComVisible 属性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("6EC799AB-52D8-4e2a-94BC-BBEC79D61AE9")]

// 程序集的版本信息由下面四个值组成:
//
//      主版本
//      次版本 
//      内部版本号
//      修订号
//
// 可以指定所有这些值，也可以使用“内部版本号”和“修订号”的默认值，
// 方法是按如下所示使用“*”:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.14")]
[assembly: AssemblyFileVersion("1.0.0.14")]
