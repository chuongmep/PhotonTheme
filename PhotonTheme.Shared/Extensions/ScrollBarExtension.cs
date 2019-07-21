﻿using System.Windows;

namespace PhotonTheme.Shared.Extensions
{
    public class ScrollBarExtension
    {
        public static readonly DependencyProperty ArrowsVisibilityProperty =
            DependencyProperty.RegisterAttached("ArrowsVisibility", typeof(Visibility), typeof(ScrollBarExtension), new PropertyMetadata(Visibility.Visible));

        public static void SetArrowsVisibility(DependencyObject element, Visibility value)
        {
            element.SetValue(ArrowsVisibilityProperty, value);
        }

        public static Visibility GetArrowsVisibility(DependencyObject element)
        {
            return (Visibility)element.GetValue(ArrowsVisibilityProperty);
        }
    }
}
