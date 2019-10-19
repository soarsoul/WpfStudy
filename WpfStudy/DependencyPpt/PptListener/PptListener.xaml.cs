using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


/// <summary>
/// 依赖属性的监听(值改变时能监听)有2种方法：
/// 1）使用OverrideMetadata的方式，参照MyTextBox.cs
/// 2）DependencyPropertyDescriptor类
/// </summary>
namespace WpfStudy.DependencyPpt.PptListener
{
    /// <summary>
    /// PptListener.xaml の相互作用ロジック
    /// </summary>
    public partial class PptListener : Window
    {
        public PptListener()
        {
            InitializeComponent();

            //第二种方法，通过DependencyPropertyDescriptor
            //DependencyPropertyDescriptor descriptor =
            //    DependencyPropertyDescriptor.FromProperty(TextBox.TextProperty, typeof(TextBox));

            //descriptor.AddValueChanged(tbxEditMe, tbxEditMe_TextChanged);
        }

        private void tbxEditMe_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("", "Changed");
        }
    }
}
