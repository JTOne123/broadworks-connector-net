using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyOutgoingSMDIMWIRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementOutgoingDNList _outgoingSMDIMWIPhoneNumberList;

    [XmlElement(ElementName = "outgoingSMDIMWIPhoneNumberList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementOutgoingDNList OutgoingSMDIMWIPhoneNumberList {
        get => _outgoingSMDIMWIPhoneNumberList;
        set {
            OutgoingSMDIMWIPhoneNumberListSpecified = true;
            _outgoingSMDIMWIPhoneNumberList = value;
        }
    }

    [XmlIgnore]
    public bool OutgoingSMDIMWIPhoneNumberListSpecified { get; set; }
}
}
