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

/*
 * Window.FontSize设置会影响所有内部子元素字体大小，这就是依赖属性的继承。
 * 如第一个Label没有定义FontSize，所以它继承了Window.FontSize值。
 * 但一旦子元素提供了显式设置，这种继承就会被打断，所以Window.FontSize值对于第二个Label不再起作用
 * 并不是所有元素都支持属性值继承的，如StatusBar、Tooptip和Menu控件
 */
namespace WpfStudy.DependencyPpt
{
    /// <summary>
    /// PptInherit.xaml の相互作用ロジック
    /// </summary>
    public partial class PptInherit : Window
    {
        public PptInherit()
        {
            InitializeComponent();
        }
    }
}
