using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _code;

    [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
    public string Code {
        get => _code;
        set {
            CodeSpecified = true;
            _code = value;
        }
    }

    [XmlIgnore]
    public bool CodeSpecified { get; set; }
}
}
