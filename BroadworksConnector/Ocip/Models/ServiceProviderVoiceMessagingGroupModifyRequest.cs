using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _deliveryFromAddress;

    [XmlElement(ElementName = "deliveryFromAddress", IsNullable = true, Namespace = "")]
    public string DeliveryFromAddress {
        get => _deliveryFromAddress;
        set {
            DeliveryFromAddressSpecified = true;
            _deliveryFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DeliveryFromAddressSpecified { get; set; }
    private string _notificationFromAddress;

    [XmlElement(ElementName = "notificationFromAddress", IsNullable = true, Namespace = "")]
    public string NotificationFromAddress {
        get => _notificationFromAddress;
        set {
            NotificationFromAddressSpecified = true;
            _notificationFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool NotificationFromAddressSpecified { get; set; }
    private string _voicePortalLockoutFromAddress;

    [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = true, Namespace = "")]
    public string VoicePortalLockoutFromAddress {
        get => _voicePortalLockoutFromAddress;
        set {
            VoicePortalLockoutFromAddressSpecified = true;
            _voicePortalLockoutFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalLockoutFromAddressSpecified { get; set; }
    private bool _useSystemDefaultDeliveryFromAddress;

    [XmlElement(ElementName = "useSystemDefaultDeliveryFromAddress", IsNullable = false, Namespace = "")]
    public bool UseSystemDefaultDeliveryFromAddress {
        get => _useSystemDefaultDeliveryFromAddress;
        set {
            UseSystemDefaultDeliveryFromAddressSpecified = true;
            _useSystemDefaultDeliveryFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemDefaultDeliveryFromAddressSpecified { get; set; }
    private bool _useSystemDefaultNotificationFromAddress;

    [XmlElement(ElementName = "useSystemDefaultNotificationFromAddress", IsNullable = false, Namespace = "")]
    public bool UseSystemDefaultNotificationFromAddress {
        get => _useSystemDefaultNotificationFromAddress;
        set {
            UseSystemDefaultNotificationFromAddressSpecified = true;
            _useSystemDefaultNotificationFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemDefaultNotificationFromAddressSpecified { get; set; }
    private bool _useSystemDefaultVoicePortalLockoutFromAddress;

    [XmlElement(ElementName = "useSystemDefaultVoicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
    public bool UseSystemDefaultVoicePortalLockoutFromAddress {
        get => _useSystemDefaultVoicePortalLockoutFromAddress;
        set {
            UseSystemDefaultVoicePortalLockoutFromAddressSpecified = true;
            _useSystemDefaultVoicePortalLockoutFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemDefaultVoicePortalLockoutFromAddressSpecified { get; set; }
}
}
