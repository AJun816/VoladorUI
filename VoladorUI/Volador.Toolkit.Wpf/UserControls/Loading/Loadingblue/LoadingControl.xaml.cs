﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Volador.Toolkit.Wpf
{
    /// <summary>
    /// LoadingControl.xaml 的交互逻辑
    /// </summary>
    public partial class LoadingControl : UserControl
    {

        private readonly DispatcherTimer animationTimer;
        private readonly Timer timer;

        private int timeOut;

        private bool startTimeOut = false;
        public int Timeout
        {
            get
            {
                return timeOut;
            }
            set
            {
                timeOut = value;
                if (timeOut > 0)
                {
                    startTimeOut = true;
                }

            }
        }

        public event EventHandler<EventArgs> TimeoutEvent;

        public LoadingControl()
        {
            InitializeComponent();
            animationTimer = new DispatcherTimer(DispatcherPriority.ContextIdle, Dispatcher);
            animationTimer.Interval = new TimeSpan(0, 0, 0, 0, 90);
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;

            Start();
        }

        private string text;
        public string Text
        {
            set
            {
                text = value;
                LoadingText.Text = text;
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (timeOut-- > 0)
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (string.IsNullOrEmpty(text))
                    {
                        LoadingText.Text = "请稍候(" + timeOut + ")...";
                    }
                });
            }
            else
            {
                this.Dispatcher.Invoke(() =>
                {
                    if (string.IsNullOrEmpty(text))
                    {
                        LoadingText.Text = "请稍候...";
                    }
                });

                if (startTimeOut && TimeoutEvent != null)
                {
                    TimeoutEvent.Invoke(this, new EventArgs());
                }
            }
        }

        private void Start()
        {
            timer.Start();
            animationTimer.Tick += HandleAnimationTick;
            animationTimer.Start();
        }

        private void Stop()
        {
            timer.Stop();
            timer.Elapsed -= Timer_Elapsed;
            animationTimer.Stop();
            animationTimer.Tick -= HandleAnimationTick;
        }

        private void HandleAnimationTick(object sender, EventArgs e)
        {
            SpinnerRotate.Angle = (SpinnerRotate.Angle + 36) % 360;
        }

        private void HandleLoaded(object sender, RoutedEventArgs e)
        {
            const double offset = Math.PI;
            const double step = Math.PI * 2 / 10.0;

            SetPosition(C0, offset, 0.0, step);
            SetPosition(C1, offset, 1.0, step);
            SetPosition(C2, offset, 2.0, step);
            SetPosition(C3, offset, 3.0, step);
            SetPosition(C4, offset, 4.0, step);
            SetPosition(C5, offset, 5.0, step);
            SetPosition(C6, offset, 6.0, step);
            SetPosition(C7, offset, 7.0, step);
            SetPosition(C8, offset, 8.0, step);
        }

        private void SetPosition(Ellipse ellipse, double offset,
            double posOffSet, double step)
        {
            ellipse.SetValue(Canvas.LeftProperty, 50.0
                + Math.Sin(offset + posOffSet * step) * 50.0);

            ellipse.SetValue(Canvas.TopProperty, 50
                + Math.Cos(offset + posOffSet * step) * 50.0);
        }

        private void HandleUnloaded(object sender, RoutedEventArgs e)
        {
            Stop();
        }

        private void HandleVisibleChanged(object sender,
            DependencyPropertyChangedEventArgs e)
        {
            bool isVisible = (bool)e.NewValue;

            if (isVisible)
                Start();
            else
                Stop();

        }
    }
}
