using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Data
{
    public class TravellerChar : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Homeworld { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int Rad { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
        public int Intellect { get; set; }
        public int Education { get; set; }
        public int Social { get; set; }
        public int Psi { get; set; }
        public int StrenghtMOD { get; set; }
        public int DexterityMOD { get; set; }
        public int EnduranceMOD { get; set; }
        public int IntellectMOD { get; set; }
        public int EducationMOD { get; set; }
        public int SocialMOD { get; set; }
        public int PsiMOD { get; set; }
        public ObservableCollection<LearnedSkill> LearnedSkills { get; set; } = new ObservableCollection<LearnedSkill>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
