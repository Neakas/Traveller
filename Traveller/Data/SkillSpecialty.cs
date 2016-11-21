using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Sheet;

namespace Traveller.Data
{
    public class SkillSpecialty : ILearnable
    {
        public string Name { get; set; }
        public string SkillName { get; set; }
        public string Description { get; set; }

        public Skill Skill { get; set; }
        public bool Learnable { get; set; } = true;

        public string GetDescription()
        {
            return Description;
        }

        public bool CanLearnLegal()
        {
            Learnable = SheetWindow.Character.LearnedSkills.ToList().Exists(x => x.SkillData.Name == Skill.Name);
            if (Learnable)
            {
                SheetWindow.Character.LearnedSkills.First(x => x.Skillname == SkillName).LearnedSkillSpecialties.ForEach(x=> Learnable = x.Name != Name);
            }
            
            return Learnable;
        }
    }
}
