using System;
using System.Threading;

namespace RetroTime.Function
{
    /// <summary>
    /// 字符串特殊处理
    /// （不同于String类）
    /// </summary>
    public class STRING
    {
        /*
            * 命令与参数的识别规则
            * 
            * 当用户输入一行文本后,这个文本被分成三个部分:
            * 
            *  命令<CR>参数1<CR>参数2<CR>参数n....
            *  [0]     [1]      [2]      [n] ....  
            *  
            *  <CR>代表空格
            *  
            *  这部分文本将会按照上述的规范存入一个名为 args 的字符串数组中,然后传入子程序,
            *  命令 的下标永远为0,其后 参数 的下标从1开始到n
            *  
            *  子程序首先判断 args[0] 是否与本子程序的执行命令一致,如果一致,继续读入 args[1~n](如果存在的话),
            *  根据参数的内容继续执行子程序的其它功能.
            *  
            *  反之终止执行,反馈详细的错误.
            *  
            */
        private static string[] args;
        /// <summary>
        /// 获取当前输入的全部内容
        /// </summary>
        public static string[] Args { get => args; }
        /// <summary>
        /// 分割用户输入文本并获取命令与命令参数
        /// (默认空格为分割符)
        /// </summary>
        /// <param name="inputValue">用户输入</param>
        /// <returns>分割后的文本</returns>
        public static string[] InputSplit(string inputValue)
        {
            args = inputValue.Split(' ');
            return Args;
        }
        /// <summary>
        /// 分割用户输入文本并获取命令与命令参数
        /// (自定义分割符)
        /// </summary>
        /// <param name="inputValue">用户输入</param>
        /// <param name="separator">自定义分割符</param>
        /// <returns>分割后的文本</returns>
        public static string[] InputSplit(string inputValue, params char[] separator)
        {
            args = inputValue.Split(separator);
            return Args;
        }

        /// <summary>
        /// 将字符串数组转换为字符数组
        /// </summary>
        /// <param name="array">数组</param>
        /// <returns>处理后的</returns>
        public static char[] ToCharArray(string[] array)
        {
            string strTemp = null;
            char[] charTemp = null;
            for (int i = 0; i < array.Length; i++)
            {
                strTemp += array[i];
            }
            charTemp = strTemp.ToCharArray();
            return charTemp;
        }

        /// <summary>
        /// 将字符串转换为字符数组
        /// </summary>
        /// <param name="value">字符串</param>
        /// <returns>处理后的</returns>
        public static char[] ToCharArray(string value)
        {
            string strTemp = null;
            char[] charTemp = null;
            for (int i = 0; i < value.Length; i++)
            {
                strTemp += value[i];
            }
            charTemp = strTemp.ToCharArray();
            return charTemp;
        }
    }
}
