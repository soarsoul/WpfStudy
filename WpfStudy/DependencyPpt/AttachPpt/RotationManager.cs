using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

/// <summary>
/// 附加属性:附加是一种特殊的依赖属性。它允许给一个对象添加一个值，而该对象可能对这个值一无所知。
/// 附加属性最常见的例子就是布局容器中DockPanel类中的Dock附加属性和Grid类中Row和Column附加属性。
/// 
/// 想对AttachTest.xaml画面的3个控件，实现旋转，如果每个控件对应，代码量比较大
/// 可以通过给各个控件加入一个Angle的附加属性，在依赖属性变更时，自定义的方法(OnAngleChanged)中实现旋转
/// </summary>
namespace WpfStudy.DependencyPpt.AttachPpt
{
    public class RotationManager:DependencyObject
    {

        public static double GetAngle(DependencyObject obj)
        {
            return (double)obj.GetValue(AngleProperty);
        }

        public static void SetAngle(DependencyObject obj, double value)
        {
            obj.SetValue(AngleProperty, value);
        }

        // 通过使用RegisterAttached来注册一个附加属性   propa 2次tab快速创建
        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.RegisterAttached("Angle", typeof(double), typeof(RotationManager), new PropertyMetadata(0.0,OnAngleChanged));

        //OnAngleChanged方法在RegisterAttached注册时追加
        private static void OnAngleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var element = obj as UIElement;
            if (element != null)
            {
                element.RenderTransformOrigin = new Point(0.5, 0.5);
                element.RenderTransform = new RotateTransform((double)e.NewValue);
            }
        }
    }
}
