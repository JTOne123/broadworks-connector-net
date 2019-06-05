using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExtensionLengthModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _minExtensionLength;

    [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
    public int MinExtensionLength {
        get => _minExtensionLength;
        set {
            MinExtensionLengthSpecified = true;
            _minExtensionLength = value;
        }
    }

    [XmlIgnore]
    public bool MinExtensionLengthSpecified { get; set; }
    private int _maxExtensionLength;

    [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
    public int MaxExtensionLength {
        get => _maxExtensionLength;
        set {
            MaxExtensionLengthSpecified = true;
            _maxExtensionLength = value;
        }
    }

    [XmlIgnore]
    public bool MaxExtensionLengthSpecified { get; set; }
}
}
