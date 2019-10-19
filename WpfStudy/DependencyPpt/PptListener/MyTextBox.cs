using System.Windows;
using System.Windows.Controls;

namespace WpfStudy.DependencyPpt.PptListener
{
    public class MyTextBox:TextBox
    {
        public MyTextBox()
            : base()
        {
        }

        static MyTextBox()
        {
            // 第一种方法，通过OverrideMetadata
            TextProperty.OverrideMetadata(typeof(MyTextBox),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(TextPropertyChanged)));
        }

        private static void TextPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("", "Changed");
        }
    }
}
