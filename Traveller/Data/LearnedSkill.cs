using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Data
{
    public class LearnedSkill : INotifyPropertyChanged
    {
        public string Skillname { get; set; }
        public Skill SkillData { get; set; }
        public List<LearnedSkillSpecialty> LearnedSkillSpecialties { get; set; } = new List<LearnedSkillSpecialty>();
        public int Level { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
