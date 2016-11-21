using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
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
using Traveller.Sheet.CustomControls.SkillControls;
using Path = System.IO.Path;

namespace Traveller.Sheet.CustomControls
{
    /// <summary>
    /// Interaction logic for SheetChooseSkill.xaml
    /// </summary>
    public partial class SheetChooseSkill : Window
    {
        public SheetChooseSkill()
        {
            InitializeComponent();
            LoadSkill();
            tvSkillList.SelectedItemChanged += UpdateUI;
        }

        private void UpdateUI( object sender, RoutedPropertyChangedEventArgs<object> e )
        {
            tbDesc.Text = ( (ILearnable) e.NewValue ).GetDescription();
        }

        private void LoadSkill()
        {
            string path = Path.Combine(new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName, "Data", "Skills.xml");
            List<Skill> skills = new List<Skill>().DeserializeFromFile(path);
            tvSkillList.ItemsSource = skills.Where(x => x.CanLearn);
            skills.ForEach(x => x.Specialties.ForEach(y => y.Skill = x));
            skills.ForEach(x=> x.CanLearnLegal());
        }

        private bool CanLearn()
        {
            return false;
        }

        private void btChoose_Click(object sender, RoutedEventArgs e)
        {
            TravellerChar character = SheetWindow.Character;
            if (tvSkillList.SelectedItem == null)
                return;
            ILearnable item = (ILearnable) tvSkillList.SelectedItem;
            if (!item.Learnable)
                return;
            if (item.GetType() == typeof(Skill))
            {
                Skill skillitem = (Skill) item;
                var skill = new LearnedSkill()
                {
                    SkillData = skillitem,
                    Level = 0,
                    Skillname = skillitem.Name
                };
                character.LearnedSkills.Add(skill);
            }
            if (item.GetType() == typeof(SkillSpecialty))
            {
                SkillSpecialty skillspecitem = (SkillSpecialty) item;
                LearnedSkill parentskill = character.LearnedSkills.First(x => x.SkillData.Name == skillspecitem.Skill.Name);
                var skillspec = new LearnedSkillSpecialty()
                {
                    SkillData = parentskill,
                    Level = 0,
                    Name = skillspecitem.Name,
                    SkillName = parentskill.Skillname,
                    SpecialtyData = skillspecitem
                };
                parentskill.LearnedSkillSpecialties.Add(skillspec);
            }
            Close();
        }
    }
}
