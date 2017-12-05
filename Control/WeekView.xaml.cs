using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace AttWare.Control
{
    public sealed partial class WeekView : UserControl
    {
        public WeekView()
        {
            this.InitializeComponent();
        }



        public int WeekDayIndex
        {
            get { return (int)GetValue(WeekDayIndexProperty); }
            set { SetValue(WeekDayIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WeekDayIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WeekDayIndexProperty =
            DependencyProperty.Register("WeekDayIndex", typeof(int), typeof(WeekView), new PropertyMetadata(0));



        public int TimeLineIndex
        {
            get { return (int)GetValue(TimeLineIndexProperty); }
            set { SetValue(TimeLineIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TimeLineIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TimeLineIndexProperty =
            DependencyProperty.Register("TimeLineIndex", typeof(int), typeof(WeekView), new PropertyMetadata(0));




    }
}
