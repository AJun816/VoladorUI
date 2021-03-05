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
using System.Windows.Shapes;

namespace Softkeyboard
{
    /// <summary>
    /// FrmKeyBoard.xaml 的交互逻辑
    /// </summary>
    public partial class FrmKeyBoard : Window
    {
        private String valueString;

        internal String ValueString
        {
            get { return valueString; }
        }
        public FrmKeyBoard(String inputvalue)
        {
            InitializeComponent();

            FrmFullKeyPoint();
            tbValue.Text = inputvalue;
            valueString = inputvalue;
        }

        //通过判断按钮的content属性来做对应处理，以简化大量按钮的编程
        private void ButtonGrid_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)e.OriginalSource;    //获取click事件触发源，即按了的按钮
            if ((String)clickedButton.Content == "删除")
            {
                if (tbValue.Text.Length > 0)
                {
                    tbValue.Text = tbValue.Text.Substring(0, tbValue.Text.Length - 1);
                }
            }
            else if ((String)clickedButton.Content == "清空")
            {
                tbValue.Text = "";
            }
            else if ((String)clickedButton.Content == "确认/关闭")
            {
                valueString = tbValue.Text;
                this.Close();
            }
            else if ((String)clickedButton.Content == "大小写")
            {
                int count = ButtonGrid.Children.Count;
                for (int i = 10; i < count - 4; i++)
                {
                    Button buttonTemp = ButtonGrid.Children[i] as Button;
                    String contentTemp = buttonTemp.Content as String;
                    buttonTemp.Content = contentTemp[0] > 90 ? contentTemp.ToUpper() : contentTemp.ToLower();
                }
            }
            else
            {
                tbValue.Text += (String)clickedButton.Content;
            }
        }


        public void FrmFullKeyPoint()
        {
            double swidth = SystemParameters.WorkArea.Width;//得到屏幕工作区域宽度
            double sheight = SystemParameters.WorkArea.Height;//得到屏幕工作区域高度

            fullKeyboard.Height = sheight / 2.5;
            fullKeyboard.Width = swidth / 2;

            double targetX = (swidth - fullKeyboard.Width) / 2;
            double targetY = (sheight - fullKeyboard.Height);

            fullKeyboard.Width = swidth / 2;
            fullKeyboard.Height = sheight / 2;



            fullKeyboard.Left = targetX;
            fullKeyboard.Top = targetY;

        }
    }
}
