using System;
using System.Collections.Generic;
using System.Text;
using DrawImageForConsole;
namespace RetroTime
{
    /// <summary>
    /// 用于处理控制台视图中的元素
    /// </summary>
    public class View
    {
        #region 字段
        private static int width, hight;
        #endregion
        #region 属性
        /// <summary>
        /// 获取/设置视图的尺寸——宽度
        /// </summary>
        public static int SetWidth { get => width; set => width = value; }
        /// <summary>
        /// 获取/设置视图的尺寸——高度
        /// </summary>
        public static int SetHight { get => hight; set => hight = value; }
        #endregion
        #region 方法
        /// <summary>
        /// 清空/刷新视图
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }
        /// <summary>
        /// 清空/刷新指定的行
        /// </summary>
        /// <param name="lineValue">指定行</param>
        /// <param name="returnLineTail">是否回到行尾</param>
        public static void Clear(int lineValue, bool returnLineTail = false)
        {
            int oldTop = Console.CursorTop;
            Console.SetCursorPosition(0, lineValue);
            for (int i = 0; i < width; i++)
            {
                Printer.Print(' ');
            }
            Console.SetCursorPosition(0, returnLineTail ? oldTop + 1 : 0);
        }
        /// <summary>
        /// 清空/刷新从指定起点处相应宽度的视图
        /// </summary>
        /// <param name="startPointValue">起始点</param>
        /// <param name="lineValue">指定行</param>
        /// <param name="width">宽度</param>
        /// <param name="returnLineTail">是否回到行尾</param>
        public static void Clear(int startPointValue, int lineValue, int width, bool returnLineTail = false)
        {
            int oldTop = Console.CursorTop;
            Console.SetCursorPosition(startPointValue, lineValue);
            for (int i = 0; i < width; i++)
            {
                Printer.Print(' ');
            }
            Console.SetCursorPosition(0, returnLineTail ? oldTop + 1 : 0);
        }
        /// <summary>
        /// 获取文本占据视图的宽度
        /// </summary>
        /// <param name="text">文本</param>
        /// <returns></returns>
        public static int GetLength(string text)
        {
            byte[] bytes;
            int len = 0;
            for (int i = 0; i < text.Length; i++)
            {
                bytes = Encoding.Default.GetBytes(text.Substring(i, 1));
                len += bytes.Length > 1 ? 2 : 1;
            }
            return len;
        }
        /// <summary>
        /// 设置光标的行列位置
        /// </summary>
        /// <param name="line">行</param>
        /// <param name="row">列</param>
        public static void SetPostion(int line, int row)
        {
            Console.CursorTop = line;
            Console.CursorLeft = row;
        }
        #endregion

    }
    /// <summary>
    /// 在控制台中简单绘图
    /// </summary>
    public class Draw
    {
        private int hight, width;
        private string imagePath;
        DRAW d;
        /// <summary>
        /// 图形高度
        /// </summary>
        public int Hight { set => hight = value; }
        /// <summary>
        /// 图形宽度
        /// </summary>
        public int Width { set => width = value; }
        /// <summary>
        /// 图片文件
        /// </summary>
        public string ImagePath {set => imagePath = value; }
        public Draw()
        {
            d = new DRAW();
        }
        /// <summary>
        /// 绘制图形
        /// </summary>
        public void DrawImage()
        {
            d.刻画图片(imagePath, width, hight);
        }
    }
}
