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
using Traveller.Data;

namespace Traveller.Sheet.CustomControls.SkillControls
{
    /// <summary>
    /// Interaction logic for SkillItem.xaml
    /// </summary>
    public partial class SkillItem : UserControl
    {
        public SkillItem(Skill skill)
        {
            InitializeComponent();
            lblSkillName.Content = skill.Name;
            textBlock.Text = skill.Description;
            var result = "";
            if (skill.Specialties.Count <= 0) return;
            lblspec.Visibility = Visibility.Visible;
            ( from c in skill.Specialties select c.Name ).ToList().ForEach(x => result += x + ",");
            if (result.Length > 0)
                result = result.Remove(result.Length - 1);
            lblspec.ToolTip = new TextBlock()
            {
                Text = result
            };
        }
    }
}
