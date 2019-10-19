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

/// <summary>
/// 1) CoerceValueCallback方法可以修改提供的值或返回DependencyProperty.UnsetValue
/// 2) ValidateValueCallback方法进行验证
/// 3) PropertyChangedCallback方法来触发依赖属性值的更改
/// 通过依赖属性的Register方法，可以声明上面的回调方法
/// </summary>
namespace WpfStudy.DependencyPpt
{
    /// <summary>
    /// ValidateTest.xaml の相互作用ロジック
    /// </summary>
    public partial class ValidateTest : Window
    {
        public ValidateTest()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SimpleDPClass sDpClass= new SimpleDPClass();
            sDpClass.SimpleDP = 2;
        }

        public class SimpleDPClass : DependencyObject
        {


            public double SimpleDP
            {
                get { return (double) GetValue(SimpleDPProperty); }
                set { SetValue(SimpleDPProperty, value); }
            }

            // Using a DependencyProperty as the backing store for SimpleDP.  This enables animation, styling, binding, etc...
            public static readonly DependencyProperty SimpleDPProperty =
                DependencyProperty.Register("SimpleDP", typeof(double), typeof(SimpleDPClass),
                    new FrameworkPropertyMetadata((double) 0.0,
                        FrameworkPropertyMetadataOptions.None,
                        new PropertyChangedCallback(OnValueChanged),
                        new CoerceValueCallback(CoreValue)),
                    new ValidateValueCallback(IsValidValue));

            private static bool IsValidValue(object value)
            {
                MessageBox.Show("验证值是否通过，返回bool值，如果返回True表示验证通过，否则会以异常的形式暴露： {0}", value.ToString());
                return true;
            }

            private static object CoreValue(DependencyObject d, object basevalue)
            {
                MessageBox.Show("对值进行限定，强制值： {0}", basevalue.ToString());
                return basevalue;
            }

            private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                MessageBox.Show("当值改变时，我们可以做的一些操作，具体可以在这里定义： {0}", e.NewValue.ToString());
            }
        }
    }
}
