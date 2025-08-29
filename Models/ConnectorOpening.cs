using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RotoConectorHerraje
{
    public class ConnectorOpeningFlag
    {
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }

    public class ConnectorOpening
    {
        [XmlElement("Opening_Flag")]
        public List<ConnectorOpeningFlag> Flags { get; set; }
    }
}
