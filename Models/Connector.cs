using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RotoConectorHerraje
{
    [XmlRoot("Connector")]
    public class Connector
    {
        [XmlAttribute("Connector_code")]
        public string ConnectorCode { get; set; }

        [XmlAttribute("Message")]
        public string Message { get; set; }

        [XmlElement("Node")]
        public List<ConnectorNode> Nodes { get; set; }
    }
}
