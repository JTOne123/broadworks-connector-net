using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for SIP Hold Normalization option
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum HoldNormalizationMode
    {
        [XmlEnum(Name = "Unspecified Address")]
        UnspecifiedAddress,
        [XmlEnum(Name = "Inactive")]
        Inactive,
        [XmlEnum(Name = "Rfc3264")]
        Rfc3264,
    }
}
