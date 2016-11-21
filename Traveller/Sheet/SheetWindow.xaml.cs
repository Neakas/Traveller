using System;
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
using Traveller.Data;

namespace Traveller.Sheet
{
    /// <summary>
    /// Interaction logic for SheetWindow.xaml
    /// </summary>
    public partial class SheetWindow : Window
    {
        public static TravellerChar Character = new TravellerChar();
        public SheetWindow()
        {
            InitializeComponent();
        }

        private void BackgroundImage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            foreach (var item in MainGrid.Children.OfType<Control>())
            {
                if (e.PreviousSize.Width == 0 || e.PreviousSize.Width == 0) return;
                var percentageHeight = (e.NewSize.Height / e.PreviousSize.Height);
                var percentageWidth = (e.NewSize.Width / e.PreviousSize.Width);
                item.Height *= percentageHeight;
                item.Width *= percentageWidth;
                item.Margin = new Thickness(item.Margin.Left * percentageWidth, item.Margin.Top * percentageHeight, item.Margin.Right * percentageWidth, item.Margin.Bottom);
                //item.FontSize *= percentageHeight;
            }
        }

        private void SheetWindow_OnSizeChanged( object sender, SizeChangedEventArgs e )
        {
            //foreach (var item in MainGrid.Children.OfType<Decorator>())
            //{
            //    if (e.PreviousSize.Width == 0 || e.PreviousSize.Width == 0) return;
            //    var percentageHeight = (e.NewSize.Height / e.PreviousSize.Height);
            //    var percentageWidth = (e.NewSize.Width / e.PreviousSize.Width);
            //    item.Height *= percentageHeight;
            //    item.Width *= percentageWidth;
            //    item.Margin = new Thickness(item.Margin.Left * percentageWidth, item.Margin.Top * percentageHeight, item.Margin.Right * percentageWidth, item.Margin.Bottom);
            //    //item.FontSize *= percentageHeight;
            //}
        }
    }
}
