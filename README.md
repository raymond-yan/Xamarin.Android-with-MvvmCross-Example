# Xamarin.Android-with-MvvmCross-Example
Xamarin Native( Xamarin.Android ) 与 MvvmCross 框架范例, 创建一个 Model-View-ViewModel 项目。

MvvmCross 是一个跨平台的 MVVM 框架，允许开发者开发强大的跨平台应用。它支持 Xamarin.iOS, Xamarin.Android, Xamarin.Mac, Xamarin.Forms, Universal Windows Platform (UWP) and Windows Presentation Framework (WPF).

关于 MvvmCross 的具体介绍，可以参考以下的链接：
[**Getting Started with MvvmCross**](https://www.mvvmcross.com/documentation/getting-started/getting-started)

在这里我们将按照 MvvmCross 的框架，创建一个 Model-View-ViewModel 项目。这个项目会是一个简单的单页应用，页面上会有一个输入框要求用户输入时间间隔，输入间隔之后，将会有倒计时出现，倒计时结束时生成一个关于当前时间的 Hash 值。

此教程的主要是参考自 [**The Tip Calc tutorial**](https://www.mvvmcross.com/documentation/tipcalc-tutorial/the-tip-calc-tutorial?scroll=200#the-tip-calc-tutorial), 只是将 Tip Calc 的功能改成了 Time Hash。主要目的是一步一步搭建 MvvmCross 与 Xamarin.Native 的开发环境。

本项目的代码放在 [**git**](https://github.com/raymond-yan/Xamarin.Android-with-MvvmCross-Example/tree/master) 上，如果遇到问题可以参看整体项目的代码。
