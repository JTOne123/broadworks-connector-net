using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isLoginDisabled;

    [XmlElement(ElementName = "isLoginDisabled", IsNullable = false, Namespace = "")]
    public bool IsLoginDisabled {
        get => _isLoginDisabled;
        set {
            IsLoginDisabledSpecified = true;
            _isLoginDisabled = value;
        }
    }

    [XmlIgnore]
    public bool IsLoginDisabledSpecified { get; set; }
    private int _expirationDays;

    [XmlElement(ElementName = "expirationDays", IsNullable = false, Namespace = "")]
    public int ExpirationDays {
        get => _expirationDays;
        set {
            ExpirationDaysSpecified = true;
            _expirationDays = value;
        }
    }

    [XmlIgnore]
    public bool ExpirationDaysSpecified { get; set; }
    private bool _doesNotExpire;

    [XmlElement(ElementName = "doesNotExpire", IsNullable = false, Namespace = "")]
    public bool DoesNotExpire {
        get => _doesNotExpire;
        set {
            DoesNotExpireSpecified = true;
            _doesNotExpire = value;
        }
    }

    [XmlIgnore]
    public bool DoesNotExpireSpecified { get; set; }
    private string _password;

    [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
    public string Password {
        get => _password;
        set {
            PasswordSpecified = true;
            _password = value;
        }
    }

    [XmlIgnore]
    public bool PasswordSpecified { get; set; }
}
}
