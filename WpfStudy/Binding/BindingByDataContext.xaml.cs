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
 * 我们并没有对每个控件单独设置它的Source属性，而是直接设置了Window对象的DataContext属性。
 * 这样绑定的控件发现没有设置source属性或RelativeSource属性，就会从元素树中查找DataContex属性不为null的值来作为自己的DataContext。
 * 通过这样的方式可以省去重复在多个控件中设置相同的DataContext属性 
*/
namespace WpfStudy.Binding
{
    /// <summary>
    /// BindingByDataContext.xaml の相互作用ロジック
    /// </summary>
    public partial class BindingByDataContext : Window
    {
        private Student m_student;

        public BindingByDataContext()
        {
            InitializeComponent();
            m_student= new Student() {ID=1,StudentName = "Le",Score = 60};
            this.DataContext = m_student;
        }

        private void changeName_Click_1(object sender, RoutedEventArgs e)
        {
            m_student.StudentName = "Learning";
        }

        private void ChangeScore_Click(object sender, RoutedEventArgs e)
        {
            m_student.Score = 90;
        }
    }
}
