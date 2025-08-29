using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotoConectorHerraje
{
    public class XmlData
    {
        public string supplier {  get; set; }
        public List<Set> SetList { get; set; }
        public List<FittingGroup> FittingGroupList { get; set; }
        public List<Fitting> FittingList { get; set; }
        public List<Colour> ColourList { get; set; }
        public List<Option> OptionList { get; set; }

        // Constructor y otros métodos si los hay
    }
}
