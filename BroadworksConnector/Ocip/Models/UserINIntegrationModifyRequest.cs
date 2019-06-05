using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserINIntegrationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private int? _originatingServiceKey;

    [XmlElement(ElementName = "originatingServiceKey", IsNullable = true, Namespace = "")]
    public int? OriginatingServiceKey {
        get => _originatingServiceKey;
        set {
            OriginatingServiceKeySpecified = true;
            _originatingServiceKey = value;
        }
    }

    [XmlIgnore]
    public bool OriginatingServiceKeySpecified { get; set; }
    private int? _terminatingServiceKey;

    [XmlElement(ElementName = "terminatingServiceKey", IsNullable = true, Namespace = "")]
    public int? TerminatingServiceKey {
        get => _terminatingServiceKey;
        set {
            TerminatingServiceKeySpecified = true;
            _terminatingServiceKey = value;
        }
    }

    [XmlIgnore]
    public bool TerminatingServiceKeySpecified { get; set; }
}
}
