using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExternalCustomRingbackGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private BroadworksConnector.Ocip.Models.ExternalCustomRingbackSettingLevel _useSettingLevel;

    [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExternalCustomRingbackSettingLevel UseSettingLevel {
        get => _useSettingLevel;
        set {
            UseSettingLevelSpecified = true;
            _useSettingLevel = value;
        }
    }

    [XmlIgnore]
    public bool UseSettingLevelSpecified { get; set; }
    private string _sipRequestURI;

    [XmlElement(ElementName = "sipRequestURI", IsNullable = false, Namespace = "")]
    public string SipRequestURI {
        get => _sipRequestURI;
        set {
            SipRequestURISpecified = true;
            _sipRequestURI = value;
        }
    }

    [XmlIgnore]
    public bool SipRequestURISpecified { get; set; }
}
}
