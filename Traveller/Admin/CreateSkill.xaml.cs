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
using Traveller;

namespace Traveller.Admin
{
    /// <summary>
    /// Interaction logic for CreateSkill.xaml
    /// </summary>
    public partial class CreateSkill : Window
    {
        public List<Skill> xmlList = new List<Skill>();
        public Skill skill = new Skill();
        public CreateSkill()
        {
            InitializeComponent();
            xmlList = xmlList.DeserializeFromFile(@"c:\Test\Skill.xml");
        }

        private void btAddSpec_Click(object sender, RoutedEventArgs e)
        {
            CreateSkillSpec css = new CreateSkillSpec();
            css.ShowDialog();
            lbSpecList.Items.Add(css.skillSpecialty);
            lbSpecList.DisplayMemberPath = "Name";
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            skill.Name = tbSkillName.Text;
            skill.Description = tbDescription.Text;
            if (lbSpecList.Items.Count > 0)
            {
                skill.Specialties = new List<SkillSpecialty>();
            }
            
            lbSpecList.Items.SourceCollection.OfType<SkillSpecialty>().ToList().ForEach(x =>
                {
                    x.SkillName = skill.Name;
                    skill.Specialties.Add(x);
                }
            );
            xmlList.Add(skill);
            xmlList = xmlList.OrderBy(x => x.Name).ToList();
            xmlList.SerializeToFile(@"..\");
            Close();
        }
    }
}
