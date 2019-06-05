using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDialPlanPolicyModifyAccessCodeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _accessCode;

    [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
    public string AccessCode {
        get => _accessCode;
        set {
            AccessCodeSpecified = true;
            _accessCode = value;
        }
    }

    [XmlIgnore]
    public bool AccessCodeSpecified { get; set; }
    private bool _includeCodeForNetworkTranslationsAndRouting;

    [XmlElement(ElementName = "includeCodeForNetworkTranslationsAndRouting", IsNullable = false, Namespace = "")]
    public bool IncludeCodeForNetworkTranslationsAndRouting {
        get => _includeCodeForNetworkTranslationsAndRouting;
        set {
            IncludeCodeForNetworkTranslationsAndRoutingSpecified = true;
            _includeCodeForNetworkTranslationsAndRouting = value;
        }
    }

    [XmlIgnore]
    public bool IncludeCodeForNetworkTranslationsAndRoutingSpecified { get; set; }
    private bool _includeCodeForScreeningServices;

    [XmlElement(ElementName = "includeCodeForScreeningServices", IsNullable = false, Namespace = "")]
    public bool IncludeCodeForScreeningServices {
        get => _includeCodeForScreeningServices;
        set {
            IncludeCodeForScreeningServicesSpecified = true;
            _includeCodeForScreeningServices = value;
        }
    }

    [XmlIgnore]
    public bool IncludeCodeForScreeningServicesSpecified { get; set; }
    private bool _enableSecondaryDialTone;

    [XmlElement(ElementName = "enableSecondaryDialTone", IsNullable = false, Namespace = "")]
    public bool EnableSecondaryDialTone {
        get => _enableSecondaryDialTone;
        set {
            EnableSecondaryDialToneSpecified = true;
            _enableSecondaryDialTone = value;
        }
    }

    [XmlIgnore]
    public bool EnableSecondaryDialToneSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
}
}
