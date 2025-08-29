using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RotoConectorHerraje
{
    public class ConnectorOption
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Value")]
        public string Value { get; set; }
    }

    public class ConnectorOptions
    {
        [XmlElement("Option")]
        public List<ConnectorOption> OptionList { get; set; }
    }

    public class ConnectorOptionsWrapper
    {
        [XmlElement("Option")]
        public List<ConnectorOption> OptionList { get; set; }
    }

    public class ConnectorOptionsContainer
    {
        [XmlElement("Options")]
        public ConnectorOptionsWrapper Options { get; set; }
    }
}
