using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Traveller.Data;

namespace Traveller.Sheet.CustomControls
{
    /// <summary>
    /// Interaction logic for SheetSkillBlock.xaml
    /// </summary>
    public partial class SheetSkillBlock : UserControl
    {
        public ObservableCollection<LearnedSkill> List { get; set; }
        public SheetSkillBlock()
        {
            InitializeComponent();
            List = SheetWindow.Character.LearnedSkills;
            skillDataGrid.DataContext = List;
        }

        private void BtAddSkill_OnClick( object sender, RoutedEventArgs e )
        {
            SheetChooseSkill scs = new SheetChooseSkill();
            scs.ShowDialog();
            UpdateSkillList();
        }

        private void UpdateSkillList()
        {
            List = SheetWindow.Character.LearnedSkills;
            //SheetWindow.Character.LearnedSkills.ForEach(x=> skillDataGrid.Items.Add(x));
            //skillDataGrid.
        }
    }
}
