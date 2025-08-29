using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RotoConectorHerraje
{
    public class ConnectorReference
    {
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }

    public class ConnectorReferences
    {
        [XmlElement("Reference")]
        public List<ConnectorReference> ReferenceList { get; set; }
    }
}
