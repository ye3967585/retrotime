using System;
using System.Collections.Generic;
using RetroTime;


/*
 * 操作：
 * 小键盘上下 控制光标浮动
 * 回车       确定
 */

/*
 * 菜单的标准格式（行）
 * 00：标题
 * 01：分割线
 * 02：选项卡
 */

namespace RetroTime.UI
{
    #region OLD
    ///// <summary>
    ///// 标准菜单
    ///// </summary>
    //class M
    //{

    //    private ConsoleColor foreground, selected;
    //    private string[] elementText;
    //    private string title;
    //    private bool dynamicMenu;

    //    private List<int> postion;

    //    /// <summary>
    //    /// 设置菜单的前景色
    //    /// </summary>
    //    public ConsoleColor SetForeground { set => foreground = value; }
    //    /// <summary>
    //    /// 设置被选中项的颜色
    //    /// </summary>
    //    public ConsoleColor SetSelected { set => selected = value; }
    //    /// <summary>
    //    /// 菜单标题
    //    /// </summary>
    //    public string Title { set => title = value; }
    //    /// <summary>
    //    /// 菜单中的选项元素集合
    //    /// </summary>
    //    public string[] ElementText { set => elementText = value; }
    //    /// <summary>
    //    /// 是否采用动态效果
    //    /// </summary>
    //    public bool DynamicMenu { set => dynamicMenu = value; }


    //    public Menu()
    //    {
    //        postion = new List<int>();
    //    }


    //    /// <summary>
    //    /// 绘制菜单
    //    /// </summary>
    //    public void Show()
    //    {
    //        DrawTitle();
    //        DrawMenu(elementText);
    //        SelectObject(0, elementText);
    //    }



    //    /// <summary>
    //    /// 绘制标题
    //    /// </summary>
    //    private void DrawTitle()
    //    {
    //        Console.ResetColor();
    //        Printer.Print(" " + title + "\n");
    //        Printer.Print(" ==============================\n");
    //    }
    //    /// <summary>
    //    /// 绘制菜单
    //    /// </summary>
    //    private void DrawMenu(string[] list)
    //    {
    //        for (int i = 0; i < list.Length; i++)
    //        {
    //            SetSingeSelectPostion();
    //            DrawSingeSelect(list[i], postion[i]);
    //            //for (int j = 0; j < list.Length; j++)
    //            //{
    //            // DrawSingeSelect(list[j], postion[j]);   
    //            //}

    //        }
    //        Console.ResetColor();
    //    }

    //    /// <summary>
    //    /// 高亮选中的对象
    //    /// </summary>
    //    /// <param name="list">选项清单</param>
    //    /// <returns>当前被选中的对象在清单中的索引号</returns>
    //    private int SelectObject(int index, string[] list)
    //    {
    //        Console.ForegroundColor = selected;
    //        Console.BackgroundColor = ConsoleColor.Yellow;
    //        Console.SetCursorPosition(0, 3);
    //        Console.BackgroundColor = ConsoleColor.Black;
    //        Console.ForegroundColor = foreground;
    //        Console.SetCursorPosition(0, 2);
    //        return 0;
    //    }

    //    /// <summary>
    //    /// 绘制单个选项对象
    //    /// </summary>
    //    /// <param name="textValue">选项文本</param>
    //    /// <param name="postion">坐标</param>
    //    private void DrawSingeSelect(string textValue, int postion)
    //    {
    //        SetPostion(postion+1, 1);
    //        Printer.Print(textValue, foreground);
    //        Console.SetCursorPosition(0, 0);
    //    }

    //    /// <summary>
    //    /// 设置选项位置信息
    //    /// </summary>
    //    private void SetSingeSelectPostion()
    //    {
    //        postion.Clear();
    //        int len = 0;
    //        for (int i = 0; i < elementText.Length; i++)
    //        {
    //            postion.Add(len);
    //            len += GetLength(elementText[i]);
    //        }
    //    }

    //    /*
    //     * 索引
    //     * 光标（ForntColor）
    //     * 
    //     * 
    //     */
    //}
    #endregion


}
