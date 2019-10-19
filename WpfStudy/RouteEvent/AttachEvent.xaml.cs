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

namespace WpfStudy.RouteEvent
{
    /// <summary>
    /// AttachEvent.xaml の相互作用ロジック
    /// </summary>
    public partial class AttachEvent : Window
    {
        public AttachEvent()
        {
            InitializeComponent();
            ButtonsPanel.AddHandler(Button.ClickEvent,new RoutedEventHandler(DoSomething));
        }

        private void DoSomething(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(e.OriginalSource.ToString());
        }
    }
}
