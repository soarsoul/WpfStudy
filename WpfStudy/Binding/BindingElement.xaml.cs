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

namespace WpfStudy.Binding
{
    /// <summary>
    /// BindingElement.xaml の相互作用ロジック
    /// </summary>
    public partial class BindingElement : Window
    {
        public BindingElement()
        {
            InitializeComponent();
        }

        private void cmd_SetSmall(object sender, RoutedEventArgs e)
        {
            // 仅仅在双向模式下工作
            lbtext.FontSize = 5;
        }

        private void cmd_SetNormal(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 20;
        }

        private void cmd_SetLarge(object sender, RoutedEventArgs e)
        {
            // 仅仅在双向模式下工作
            lbtext.FontSize = 40;
        }
    }
}
