using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enabled;

    [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
    public bool Enabled {
        get => _enabled;
        set {
            EnabledSpecified = true;
            _enabled = value;
        }
    }

    [XmlIgnore]
    public bool EnabledSpecified { get; set; }
    private int _heartbeatInterval;

    [XmlElement(ElementName = "heartbeatInterval", IsNullable = false, Namespace = "")]
    public int HeartbeatInterval {
        get => _heartbeatInterval;
        set {
            HeartbeatIntervalSpecified = true;
            _heartbeatInterval = value;
        }
    }

    [XmlIgnore]
    public bool HeartbeatIntervalSpecified { get; set; }
    private int _heartbeatTimeout;

    [XmlElement(ElementName = "heartbeatTimeout", IsNullable = false, Namespace = "")]
    public int HeartbeatTimeout {
        get => _heartbeatTimeout;
        set {
            HeartbeatTimeoutSpecified = true;
            _heartbeatTimeout = value;
        }
    }

    [XmlIgnore]
    public bool HeartbeatTimeoutSpecified { get; set; }
}
}
