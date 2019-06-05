using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRemoteOfficeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _remoteOfficePhoneNumber;

    [XmlElement(ElementName = "remoteOfficePhoneNumber", IsNullable = true, Namespace = "")]
    public string RemoteOfficePhoneNumber {
        get => _remoteOfficePhoneNumber;
        set {
            RemoteOfficePhoneNumberSpecified = true;
            _remoteOfficePhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool RemoteOfficePhoneNumberSpecified { get; set; }
}
}
