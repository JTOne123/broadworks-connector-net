using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallForwardingSelectiveModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _defaultForwardToPhoneNumber;

    [XmlElement(ElementName = "defaultForwardToPhoneNumber", IsNullable = true, Namespace = "")]
    public string DefaultForwardToPhoneNumber {
        get => _defaultForwardToPhoneNumber;
        set {
            DefaultForwardToPhoneNumberSpecified = true;
            _defaultForwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool DefaultForwardToPhoneNumberSpecified { get; set; }
    private bool _playRingReminder;

    [XmlElement(ElementName = "playRingReminder", IsNullable = false, Namespace = "")]
    public bool PlayRingReminder {
        get => _playRingReminder;
        set {
            PlayRingReminderSpecified = true;
            _playRingReminder = value;
        }
    }

    [XmlIgnore]
    public bool PlayRingReminderSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation;

    [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation {
        get => _criteriaActivation;
        set {
            CriteriaActivationSpecified = true;
            _criteriaActivation = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaActivationSpecified { get; set; }
}
}
