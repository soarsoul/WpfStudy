﻿using System;
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

namespace WpfStudy.Template
{
    /// <summary>
    /// Tree.xaml の相互作用ロジック
    /// </summary>
    public partial class Tree : Window
    {
        public Tree()
        {
            InitializeComponent();
        }

        // 把公共代码抽象出一个方法，从而使代码重用
        private void ProcessElement(object obj, TreeViewItem item, TreeViewItem previousItem)
        {
            item.Header = obj.GetType().Name;
            item.IsExpanded = true;

            // 如果当前元素是第一个元素就添加到树集合上
            // 如果是内嵌元素，则添加到它的父节点上
            if (previousItem == null)
            {
                treeElements.Items.Add(item);
            }
            else
            {
                previousItem.Items.Add(item);
            }
        }

        #region LogicTree
        private void ShowLogicTree(object sender, RoutedEventArgs e)
        {
            treeElements.Items.Clear();
            PrintLogicTree(this, null);
        }

        private void PrintLogicTree(Object obj, TreeViewItem previousItem)
        {
            TreeViewItem item = new TreeViewItem();
            ProcessElement(obj, item, previousItem);

            // 如果不是DependencyObject，则返回
            if (!(obj is DependencyObject))
                return;

            // 递归打印逻辑树
            foreach (object child in LogicalTreeHelper.GetChildren((DependencyObject)obj))
            {
                // 这里为了避免死循环，因为TreeView的子元素包含Window1、StackPanel等控件
                // 如果不加这个条件，控件会一直反复循环
                if (child is TreeView)
                    return;
                PrintLogicTree(child, item);
            }
        }
        #endregion

        #region VisualTree
        private void ShowVisualTree(object sender, RoutedEventArgs e)
        {
            treeElements.Items.Clear();
            PrintVisualTree(this, null);
        }

        private void PrintVisualTree(DependencyObject obj, TreeViewItem previousItem)
        {
            TreeViewItem item = new TreeViewItem();
            ProcessElement(obj, item, previousItem);

            //  递归输出视觉树
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                if (obj is TreeView)
                    return;
                PrintVisualTree(VisualTreeHelper.GetChild(obj, i), item);
            }
        }
        #endregion

    }
}
