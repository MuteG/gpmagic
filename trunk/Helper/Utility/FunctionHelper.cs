/*
 *********************************************************************
 * 程序名称 : Helper（辅助功能类）
 * 类名称   : FunctionHelper
 * 说明     : 提供常用功能函数
 * 作者     : 高云鹏
 * 作成日期 : 2008-10-27
 * 修改履历 :
 * 日期         修改者  程序版本    类型    理由
 * 2008-10-27   高云鹏  1.0.0.0     新规    初次做成
 * 2009-12-10   高云鹏  1.0.0.10    添加    添加获得当前程序正在运行的实例（二重启动）的函数
 * 2010-02-04   高云鹏  1.0.0.11    修改    修改获得当前程序正在运行的实例（二重启动）的函数
 *********************************************************************
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace GPSoft.Helper.Utility
{
    public class UtilityHelper
    {
        #region 属性
        /// <summary>
        /// 获得当前程序所在的路径
        /// </summary>
        public static string ApplicationPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
        /// <summary>
        /// 获得当前登录系统的用户名
        /// </summary>
        public static string LocalUserName
        {
            get
            {
                return System.Environment.UserName;
            }
        }
        /// <summary>
        /// 获得当前计算机名
        /// </summary>
        public static string LocalMachineName
        {
            get
            {
                return System.Environment.MachineName;
            }
        } 
        #endregion

        /// <summary>
        /// 获取主显示设备的工作区
        /// </summary>
        /// <returns></returns>
        public static Rectangle GetScreenRect()
        {
            return System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
        }

        /// <summary>
        /// 将一个字符串数组封装成一个List
        /// </summary>
        /// <param name="array">字符串数组</param>
        /// <returns>封装好的List</returns>
        public static List<string> StrArrayToList(string[] array)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                result.Add(array[i]);
            }
            return result;
        }

        public static void ListClone<T>(List<T> sourceList, List<T> targetList)
        {
            T[] array = new T[sourceList.Count];
            sourceList.CopyTo(array);
            targetList.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                targetList.Add(array[i]);
            }
        }

        /// <summary>
        /// 生成指定长度的填充字符串（"0"填充）
        /// </summary>
        /// <param name="length">长度</param>
        /// <returns>指定长度的"0"串</returns>
        public static string MakeFormatStr(int length)
        {
            string result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                result += "0";
            }
            return result;
        }

        /// <summary>
        /// 合并List中的字符串
        /// </summary>
        /// <param name="list">要合并的List</param>
        /// <returns>返回合并后的字符串</returns>
        public static string ListToString(List<string> list)
        {
            string result = string.Empty;
            string[] listArray = list.ToArray();
            result = string.Join(string.Empty, listArray);
            return result;
        }

        /// <summary>
        /// 交换两个输入参数的值
        /// </summary>
        /// <param name="a">第一个参数，将被赋值成第二个参数的值</param>
        /// <param name="b">第二个参数，将被赋值成第一个参数的值</param>
        public static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 将一个int数组的指定区间进行排序
        /// </summary>
        /// <param name="arr">要被排序的数组</param>
        /// <param name="left">要进行排序的左区间（索引值）</param>
        /// <param name="right">要进行排序的右区间（索引值）</param>
        public static void sort(int[] arr, int left, int right)
        {
            int i, j, s;

            if (left < right)
            {
                i = left - 1;
                j = right + 1;
                s = arr[(i + j) / 2];
                while (true)
                {
                    while (arr[++i] < s) ;
                    while (arr[--j] > s) ;
                    if (i >= j)
                        break;
                    swap(ref arr[i], ref arr[j]);
                }
                sort(arr, left, i - 1);
                sort(arr, j + 1, right);
            }
        }

        /// <summary>
        /// 将一行DataRow封装成一个对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="row">数据行</param>
        /// <returns></returns>
        public static T PackInstanceFromDataRow<T>(DataRow row)
        {
            T result = Activator.CreateInstance<T>();
            PropertyInfo[] properties = typeof(T).GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];
                Type propertyType = property.PropertyType;
                object propertyValue = row[property.Name];
                if (propertyValue == DBNull.Value)
                {
                    propertyValue = null;
                }
                else
                {
                    propertyValue = Convert.ChangeType(propertyValue, propertyType);
                    //if (propertyType.IsValueType || propertyType.Equals(typeof(string)))
                    //{
                       
                    //}
                }
                property.SetValue(result, propertyValue, null);
            }
            return result;
        }

        /// <summary>
        /// 获取当前程序正在运行的实例（二重启动），没有运行的实例返回null;
        /// </summary>
        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    // 2010-02-04 使用GetCallingAssembly()，以保证获取的是调用此函数的程序，否则获取的将是Helper.dll
                    if (Assembly.GetCallingAssembly().Location.Replace("/", "\\").Equals(current.MainModule.FileName))
                    {
                        return process;
                    }
                }
            }
            return null;
        }

        public static string GetExcelConnectionString(string filePath, bool hasHeaderRow, IMEX imex)
        {
            if (filePath.EndsWith(".xls"))
                return string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};"
                    + "Extended Properties='Excel 8.0;HDR={1};IMEX={2}';", filePath, hasHeaderRow ? "YES" : "NO",
                    ((int)imex).ToString());
            if (filePath.EndsWith(".xlsx"))
                return string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};"
                    + "Extended Properties='Excel 12.0 Xml;HDR={1}';", filePath, hasHeaderRow ? "YES" : "NO");
            throw new Exception("wrong file type!");
        }
    }

    public enum IMEX
    {
        Export,
        Import,
        Linked
    }

    public enum OfficeVersion
    {
        OfficeXP,
        office2003
    }
}
