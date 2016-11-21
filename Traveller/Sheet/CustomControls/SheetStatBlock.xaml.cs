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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace Traveller
{
    /// <summary>
    /// Interaction logic for SheetStatBlock.xaml
    /// </summary>
    public partial class SheetStatBlock : UserControl
    {
        public SheetStatBlock()
        {
            InitializeComponent();
        }

        public void OnStatValueChange(object sender, RoutedPropertyChangedEventArgs<object> e )
        {
            switch (((IntegerUpDown)sender).Tag as string)
            {
                case "STR":
                    tbSTRMOD.Value = GetStatMod((int)e.NewValue);
                    break;
                case "DEX":
                    tbDEXMOD.Value = GetStatMod((int)e.NewValue);
                    break;
                case "END":
                    tbENDMOD.Value = GetStatMod((int)e.NewValue);
                    break;
                case "INT":
                    tbINTMOD.Value = GetStatMod((int)e.NewValue);
                    break;
                case "EDU":
                    tbEDUMOD.Value = GetStatMod((int)e.NewValue);
                    break;
                case "SOC":
                    tbSOCMOD.Value = GetStatMod((int)e.NewValue);
                    break;
                case "PSI":
                    tbPSIMOD.Value = GetStatMod((int)e.NewValue);
                    break;
                default:
                    break;
            }
    
        }

        public int GetStatMod( int value )
        {
            switch (value)
            {
                case 0:
                    return -3;
                case 1:
                case 2:
                    return -2;
                case 3:
                case 4:
                case 5:
                    return -1;
                case 6:
                case 7:
                case 8:
                    return 0;
                case 9:
                case 10:
                case 11:
                    return 1;
                case 12:
                case 13:
                case 14:
                    return 2;
                default:
                    return value >= 15 ? 3 : 0;
            }
        }
    }
}
