using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExtendedFileResourceSelection
    {
        [XmlEnum(Name = "File")]
        File,
        [XmlEnum(Name = "URL")]
        URL,
        [XmlEnum(Name = "Default")]
        Default,
    }
}
