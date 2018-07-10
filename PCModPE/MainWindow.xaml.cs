using System.Windows;

namespace PCModPE
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            documenthtml.Address = @"C:\Users\Fanhaochuan\source\repos\PCModPE\PCModPE\ModPE\document.html";
            myWebView.Address = @"C:\Users\Fanhaochuan\source\repos\PCModPE\PCModPE\ModPE\Debugger.html";
        }
    }
}
