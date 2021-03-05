using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Volador.Toolkit.Wpf.UserControls.Loading.LoadingMask
{
    /// <summary>
    /// LoadingMask.xaml 的交互逻辑
    /// </summary>
    public partial class LoadingMask : UserControl
    {
        private readonly DispatcherTimer animationTimer;
        private readonly System.Timers.Timer timer;

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

        public LoadingMask()
        {
            InitializeComponent();


            this.Loaded += WaitFor_Loaded;

            animationTimer = new DispatcherTimer(DispatcherPriority.ContextIdle, Dispatcher);
            animationTimer.Interval = new TimeSpan(0, 0, 0, 0, 90);
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;

            Start();
        }


        private string text;

        public string Text
        {
            get { return text; }
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
            LoadingText.Width = (LoadingText.Width + 36) % 360;
        }







        private void WaitFor_Loaded(object sender, RoutedEventArgs e)
        {
            this.RunAnimation();
        }

        private void RunAnimation()
        {
            Duration duration = new Duration(TimeSpan.FromMilliseconds(1000));
            DoubleAnimation daX = new DoubleAnimation();
            daX.To = 1.8;
            daX.Duration = duration;
            daX.RepeatBehavior = RepeatBehavior.Forever;
            daX.AutoReverse = true;

            DoubleAnimation daY = new DoubleAnimation();
            daY.To = 1.8;
            daY.Duration = duration;
            daY.RepeatBehavior = RepeatBehavior.Forever;
            daY.AutoReverse = true;



            // 关键帧动画
            string textStr = Text;
            StringAnimationUsingKeyFrames keyFrames = new StringAnimationUsingKeyFrames();
            //string txt = "";
            //for (int i = 0; i < textStr.Length; i++)
            //{
            //    keyFrames.KeyFrames.Add(new DiscreteStringKeyFrame { Value = txt, KeyTime = TimeSpan.FromMilliseconds(200 * (i)) });
            //    txt += textStr[i].ToString();
            //}

            keyFrames.RepeatBehavior = RepeatBehavior.Forever;
            this.LoadingText.BeginAnimation(TextBlock.TextProperty, keyFrames);
        }
    }
}
