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

namespace Traveller.Admin
{
    /// <summary>
    /// Interaction logic for CreateSkill.xaml
    /// </summary>
    public partial class CreateSkillSpec : Window
    {
        public SkillSpecialty skillSpecialty = new SkillSpecialty();
        public CreateSkillSpec()
        {
            InitializeComponent();
        }

        private void btok_Click(object sender, RoutedEventArgs e)
        {
            skillSpecialty.Name = tbSkillName.Text;
            skillSpecialty.Description = tbDescription.Text;
            this.Close();
        }
    }
}
