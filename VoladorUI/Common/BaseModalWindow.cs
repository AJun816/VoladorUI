using System;
using System.Windows;

//namespace Common
//{
    //public class BaseModalWindow: Window
    //{
        //public Brush LayerBackground
        //{
        //    get; set;
        //}

        //public BaseModalWindow() : base()
        //{
        //    this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        //    this.ResizeMode = ResizeMode.NoResize;
        //    this.WindowStyle = WindowStyle.None;
        //    this.Closed += Window_Closed;
        //    this.ShowInTaskbar = false;
        //}

        //public bool? ShowDialog(Window owner)
        //{

        //    Grid layer = new Grid() { Background = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0)) };

        //    if (LayerBackground == null)
        //    {
        //        layer.Background = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
        //    }
        //    else
        //    {
        //        layer.Background = LayerBackground;
        //    }

        //    UIElement original = owner.Content as UIElement;
        //    owner.Content = null;

        //    Grid container = new Grid();
        //    container.Children.Add(original);
        //    container.Children.Add(layer);

        //    owner.Content = container;
        //    this.Owner = owner;
        //    return this.ShowDialog();

        //}


        //private void Window_Closed(object sender, EventArgs e)
        //{
        //    if (this.Owner == null)
        //    {
        //        return;
        //    }

        //    Grid grid = this.Owner.Content as Grid;

        //    UIElement original = VisualTreeHelper.GetChild(grid, 0) as UIElement;

        //    grid.Children.Remove(original);

        //    this.Owner.Content = original;
        //}

//    }
//}
