using CoderApp.Views;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CoderApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //Title = "IGN";

            if (AppWindowTitleBar.IsCustomizationSupported())
            {
                IntPtr hWnd = WindowNative.GetWindowHandle(this);
                WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
                AppWindow appWindow = AppWindow.GetFromWindowId(wndId);
                appWindow.SetIcon("Assets\\code.ico");
                appWindow.Title = "IGN";
            }

            //Title = "Coder Application";
            //ExtendsContentIntoTitleBar = true;
            //SetTitleBar(TitleBarMenu);
            //int width = 1500;
            //int height = 1500;
            //AppWindow.Resize(new SizeInt32 (height , width));
        }

        private void Window_SizeChanged(object sender, WindowSizeChangedEventArgs args)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void NewFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
