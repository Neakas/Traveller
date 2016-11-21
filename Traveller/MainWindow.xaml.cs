using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Traveller.Admin;
using Traveller.Sheet;

namespace Traveller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btSheet_Click(object sender, RoutedEventArgs e)
        {
            SheetWindow sw = new SheetWindow();
            sw.ShowDialog();

        }

        private void btAdminSkill_Click(object sender, RoutedEventArgs e)
        {
            CreateSkill cs = new CreateSkill();
            cs.ShowDialog();
        }
    }
}
