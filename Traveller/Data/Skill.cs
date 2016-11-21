using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Traveller.Sheet;

namespace Traveller.Data
{
    public class Skill : ILearnable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SkillSpecialty> Specialties { get; set; }
        public bool CanLearn { get; set; } = true;
        public bool CanImprove { get; set; } = true;
        public bool Learnable { get; set; } = true;

        public string GetDescription()
        {
            return Description;
        }

        public bool CanLearnLegal()
        {
            foreach (var item in Specialties)
            {
                item.CanLearnLegal();
            }
            Learnable = !SheetWindow.Character.LearnedSkills.ToList().Exists(x => x.SkillData.Name == this.Name);
            return Learnable;
        }
    }
}
