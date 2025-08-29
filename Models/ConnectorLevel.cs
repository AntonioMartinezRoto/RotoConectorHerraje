using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RotoConectorHerraje
{
    public class ConnectorLevel
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
    }

    public class ConnectorLevelsWrapper
    {
        [XmlElement("Level")]
        public List<ConnectorLevel> LevelList { get; set; }
    }
}
