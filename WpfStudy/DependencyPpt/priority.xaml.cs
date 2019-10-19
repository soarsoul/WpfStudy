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

/* <summary>
依赖属性的优先级：
动画=》绑定=》本地值=》自定义style trigger =》自定义Template Trigger=》自定义style setter=》
默认style trigger=》默认style setter=》继承值=》默认值

按钮的本地值设置的是Green，自定义Style Trigger设置的为Red，自定义的Style Setter设置的为Yellow，
由于这里的本地值的优先级最高，所以按钮的背景色或者的是Green值。
如果此时把本地值Green去掉的话，此时按钮的背景颜色是Yellow而不是Red。
这里尽管Style Trigger的优先级比Style Setter高，但是由于此时Style Trigger的IsMouseOver属性为false，
即鼠标没有移到按钮上，一旦鼠标移到按钮上时，此时按钮的颜色就为Red。
此时才会体现出Style Trigger的优先级比Style Setter优先级高
</summary>
*/
namespace WpfStudy.DependencyPpt
{
    /// <summary>
    /// priority.xaml の相互作用ロジック
    /// </summary>
    public partial class priority : Window
    {
        public priority()
        {
            InitializeComponent();
        }
    }
}
