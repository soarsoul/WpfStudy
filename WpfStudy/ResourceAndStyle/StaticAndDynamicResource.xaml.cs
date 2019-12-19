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

namespace WpfStudy.ResourceAndStyle
{
    /// <summary>
    /// StaticAndDynamicResource.xaml の相互作用ロジック
    /// </summary>
    public partial class StaticAndDynamicResource : Window
    {
        public StaticAndDynamicResource()
        {
            InitializeComponent();
        }

        private void ChangeBrushToYellow_Click(object sender, RoutedEventArgs e)
        {
            //改变资源
            this.Resources["RedBrush"]= new SolidColorBrush(Colors.Yellow);
        }
    }
}
