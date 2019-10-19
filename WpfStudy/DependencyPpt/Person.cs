using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/* <summary>
定义依赖属性的步骤：
1. 让依赖属性的所在类型继承自DependencyObject类。
2. 使用public static 声明一个DependencyProperty的变量，该变量就是真正的依赖属性。
3. 在类型的静态构造函数中通过Register方法完成依赖属性的元数据注册。
4. 提供一个依赖属性的包装属性，通过这个属性来完成对依赖属性的读写操作。
</summary>
*/
namespace WpfStudy.DependencyPpt
{
    //1. 使类型继承DependencyObject类
    public class Person: DependencyObject
    {
        // 2. 声明一个静态只读的DependencyProperty 字段
        public static readonly DependencyProperty nameProperty;

        static Person()
        {
            // 3. 注册定义的依赖属性
            nameProperty = DependencyProperty.Register(
                "Name", typeof(string), typeof(Person), new PropertyMetadata("Learnng Hard",OnValueChanged));
        }

        // 4. 属性包装器，通过它来读取和设置我们刚才注册的依赖属性
        public string Name
        {
            get { return (string) GetValue(nameProperty); }
            set { SetValue(nameProperty, value); }
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // 当值发生改变时回调的方法
        }
    }
}
