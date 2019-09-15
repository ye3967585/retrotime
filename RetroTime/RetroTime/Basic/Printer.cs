using System;
using System.Threading;
using RetroTime.Function;

namespace RetroTime.Visual
{
    /// <summary>
    /// 标准输出,向视图中输出各种形式的字符串。
    /// (慢于Console.Write或Console.WriteLine)
    /// </summary>
    public class Printer
    {
        internal static int LineController;
        #region 一般
        /// <summary>
        /// 标准输出
        /// </summary>
        public static void Print()
        {
            Console.WriteLine();
        }
        /// <summary>
        /// 标准字符串输出
        /// </summary>
        /// <param name="value">值</param>
        public static void Print(object value)
        {
            Console.Write(value);
        }
        /// <summary>
        /// 具有动态打字机效果的延时输出
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="delay">输出间隔（值越大输出速度越慢）</param>
        public static void Print(object value, int delay)
        {
            for (int i = 0; i < value.ToString().Length; i++)
            {
                Thread.Sleep(delay);
                Print(value.ToString()[i]);
            }
        }
        /// <summary>
        /// 具有动态打字机效果的延时输出
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="delay">输出间隔（值越大输出速度越慢）</param>
        /// <param name="line">换行值</param>
        public static void Print(object value, int delay, int line)
        {
            LineController = 0;
            for (int i = 0; i < value.ToString().Length; i++, LineController++)
            {
                if (LineController == line)
                {
                    Print();
                    LineController = 0;
                }
                Thread.Sleep(delay);
                Print(value.ToString()[i]);
            }
        }


        #endregion
        #region 颜色
        /// <summary>
        /// 输出一行具有颜色的字符串
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="color">颜色</param>
        /// <param name="background">背景色</param>
        public static void Print(object value, ConsoleColor color, ConsoleColor background = ConsoleColor.Black)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = background;
            Print(value);
            Console.ResetColor();
        }
        /// <summary>
        /// 输出一行具有颜色并且具有动态打字机效果的字符串
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="color">颜色</param>
        /// <param name="delay">输出间隔（值越大输出速度越慢）</param>
        /// <param name="background">背景色</param>
        public static void Print(object value, int delay, ConsoleColor color, ConsoleColor background = ConsoleColor.Black)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = background;
            Print(value, delay);
            Console.ResetColor();
        }
        /// <summary>
        /// 输出一行具有颜色并且具有动态打字机效果的字符串
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="color">颜色</param>
        /// <param name="delay">输出间隔（值越大输出速度越慢）</param>
        /// <param name="line">换行值</param>
        /// <param name="background">背景色</param>
        public static void Print(object value, int delay, int line, ConsoleColor color, ConsoleColor background = ConsoleColor.Black)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = background;
            Print(value, delay, line: line);
            Console.ResetColor();
        }

        /// <summary>
        /// 输出一行具有高亮标注出特定词语、字、句子的字符串
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="delay">输出间隔（值越大输出速度越慢）</param>
        /// <param name="line">换行值</param>
        /// <param name="color">文字颜色</param>
        /// <param name="keyColor">标注颜色</param>
        /// <param name="keyWord">关键词组</param>
        public static void PrintKeyWord(object value, int delay, int line, ConsoleColor color, ConsoleColor keyColor, params string[] keyWord)
        {
            char[] flag = new char[] { ',', ' ', '\t', '\n', '.', '?', '!', '\"', '。', '，', '！', '？', '”', '“' };
            string[] valueWord = STRING.InputSplit(value.ToString(), flag);

            //逆向拆卸
            string[] pun = STRING.InputSplit(value.ToString(), STRING.ToCharArray(keyWord));  // 将文字剔除，留下标点符号

            for (int i = 0, a = 0; i < valueWord.Length; i++, a++)
            {
                Console.ForegroundColor = color;
                for (int j = 0; j < keyWord.Length; j++)
                {
                    if (valueWord[i] == keyWord[j])
                    {
                        Console.ForegroundColor = keyColor;
                    }
                }

                Console.Write(valueWord[i]);

                //for (int k = 0; k < pun.Length; k++)
                //{
                //    Console.Write(pun[k]);
                //}
            }
        }
    }
    #endregion
}
