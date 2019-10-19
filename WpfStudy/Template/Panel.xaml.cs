using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfStudy.Annotations;

namespace WpfStudy.Template
{
    /// <summary>
    /// Panel.xaml の相互作用ロジック
    /// </summary>
    public partial class Panel : Window
    {
        private ObservableCollection<Student> persons = new ObservableCollection<Student>()
        {
            new Student() {Name = "LearningHard", Age = 25},
            new Student() {Name = "HelloWorld", Age = 22}
        };

        public Panel()
        {
            InitializeComponent();
            lstPerson.ItemsSource = persons;
        }

        public class Student : INotifyPropertyChanged
        {
            public string ID
            {
                get { return Guid.NewGuid().ToString(); }
            }

            public string Name { get; set; }
            public int Age { get; set; }


            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


}
