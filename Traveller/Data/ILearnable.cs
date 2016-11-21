using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Data
{
    internal interface ILearnable
    {
        bool Learnable { get; set; }
        string GetDescription();
        bool CanLearnLegal();
    }
}
