﻿using System;
using System.Windows;

namespace WpfApp1
{
    public class MyDepObj : DependencyObject
    {
        public int Value
        {
            get { return (int) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(MyDepObj),
            new PropertyMetadata(0, null, CoerceValue));


        public int Minimum
        {
            get { return (int) GetValue(MinProp); }
            set { SetValue(MinProp, value); }
        }
        public static readonly DependencyProperty MinProp =
            DependencyProperty.Register("Minimum", typeof(int), typeof(MyDepObj), new PropertyMetadata(0));

        public int Maximum
        {
            get { return (int)GetValue(MaxProp); }
            set { SetValue(MaxProp, value); }
        }
        public static readonly DependencyProperty MaxProp =
            DependencyProperty.Register("Maximum", typeof(int), typeof(MyDepObj), new PropertyMetadata(999));

        private static object CoerceValue(DependencyObject dObj, object value)
        {
            int newValue = (int)value;
            MyDepObj cont = (MyDepObj) dObj;

            newValue = Math.Max(cont.Minimum, Math.Min(cont.Maximum, newValue));
            return newValue;
        }

    }
}
