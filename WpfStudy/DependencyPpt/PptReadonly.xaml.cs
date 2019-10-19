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

namespace WpfStudy.DependencyPpt
{
    /// <summary>
    /// PptReadonly.xaml の相互作用ロジック
    /// </summary>
    public partial class PptReadonly : Window
    {
        public PptReadonly()
        {
            InitializeComponent();
            // 内部使用SetValue来设置值
            SetValue(CounterKey,8);
        }

        // 属性包装器，只提供GetValue，你也可以设置一个private的SetValue进行限制。
        public int Counter
        {
            get { return (int)GetValue(CounterKey.DependencyProperty); }
        }

        // 使用RegisterReadOnly来代替Register来注册一个只读的依赖属性,是DependencyPropertyKey，不是DependencyProperty
        public static readonly DependencyPropertyKey CounterKey =
            DependencyProperty.RegisterReadOnly("Counter", typeof(int), typeof(PptReadonly), new PropertyMetadata(0));


    }
}
