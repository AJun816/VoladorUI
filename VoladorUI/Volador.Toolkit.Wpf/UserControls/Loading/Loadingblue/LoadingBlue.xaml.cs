using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Volador.Toolkit.Wpf
{
    /// <summary>
    /// Loading.xaml 的交互逻辑
    /// </summary>
    public partial class LoadingBlue : Window
    {
        public LoadingBlue(int i =0)
        {
            InitializeComponent();

           // AllowsTransparency = true;
            LoadingCtrl.Timeout = i;
            LoadingCtrl.TimeoutEvent += LoadingCtrl_TimeoutEvent;
        }

        private void LoadingCtrl_TimeoutEvent(object sender, System.EventArgs e)
        {
            //this.Dispatcher.Invoke(() =>
            //{
            //    this.Close();
            //});
        }

        public string Text
        {
            set
            {
                LoadingCtrl.Text = value;
            }
        }
    }
}
