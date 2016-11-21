using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Data
{
    public class LearnedSkillSpecialty
    {
        public string Name { get; set; }
        public SkillSpecialty SpecialtyData { get; set; }
        public string SkillName { get; set; }
        public LearnedSkill SkillData { get; set; }
        public int Level { get; set; }
    }
}
