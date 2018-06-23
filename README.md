# Rotero Time

给控制台程序用的一系列功能库，较有专一性，某些功能可能对你没啥用，对我来说简直求之不得。

##### Printer 类 
可以在控制台上面输出一系列多彩化的字符串，它可以模拟打字机的效果在屏幕上进行输出，也可以快速简单输出带有彩色字体和背景的字符串效果。
还提供了一个关键词高亮功能，你可以创建一个关键词列表集合提供给它，它会把你的关键字在那一行出书中单独高亮，当然，高亮的颜色由你决定。

##### STRING 类 

这玩意估计可能你不太会用到，它能裁开一个字符串然后存到数组中，但是前提是你要有标志符，当然标志符你可以自行决定，你也能提供一个标志符集合列表给它。
另外还有个功能就是把字符串/字符串数组转成字符数组返回出来。

##### View 类 

它能清掉你指定一行的字符串，或者指定宽度的字符串，还能获得当前文字占据控制台视图的宽度。

##### Draw 类 

给它提供一个JPG,BMP,IMG类型的图片，并且设置好宽高，他就能在控制台里面把那张图给打印出来（色彩可能有点奇怪）。这个功能由Gordon Walkedby制作。

##### Progressbar 类

绘制一个自定义速度，长度，外观的简陋进度条。

##### FILE 类

可以直接序列化一个Object，也可以直接读取一个Object，并且使用一个Object接收。还有其它的一些优化后的简易io功能。