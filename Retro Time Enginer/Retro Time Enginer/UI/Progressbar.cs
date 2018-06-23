/********************************************************************************

 By ChinHuCheYeh 2018/6/20  
 
 Function : 绘制进度条

*********************************************************************************/
using System;
using RetroTime;

namespace RetroTime.UI
{
    /// <summary>
    /// 进度条
    /// </summary>
    public class Progressbar
    {
        private static int len, speed;
        private static char filler;
        private static ConsoleColor color, fillerColor;

        /// <summary>
        /// 进度条长度
        /// </summary>
        public int Len { get => len; set => len = value; }
        /// <summary>
        /// 行进速度
        /// </summary>
        public int Speed { get => speed; set => speed = value; }
        /// <summary>
        /// 填充物
        /// </summary>
        public char Filler { get => filler; set => filler = value; }
        /// <summary>
        /// 颜色
        /// </summary>
        public ConsoleColor Color { get => color; set => color = value; }
        /// <summary>
        /// 填充物颜色
        /// </summary>
        public ConsoleColor FillerColor { get => fillerColor; set => fillerColor = value; }


        /// <summary>
        /// 绘制进度条
        /// </summary>
        public void Draw()
        {
            Console.CursorVisible = false;
            for (int i = 0; i < len; i++)
            {
                Printer.Print(filler, speed, color: fillerColor, background: color);
            }
            Console.ResetColor();
            Console.CursorVisible = true;
        }
    }
}
