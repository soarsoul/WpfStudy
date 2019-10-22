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

namespace WpfStudy.Command
{
    /// <summary>
    /// UseCommand.xaml の相互作用ロジック
    /// </summary>
    public partial class UseCommand : Window
    {
        public UseCommand()
        {
            InitializeComponent();
        }

        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New 命令被触发了，命令源是：" + e.Source.ToString());
        }

        private void cmdDoCommand_Click(object sender, RoutedEventArgs e)
        {
            //直接调用命令的两种方式
            ApplicationCommands.New.Execute(null,(Button)sender);

            //this.CommandBindings[0].Command.Execute(null);
        }
    }
}
