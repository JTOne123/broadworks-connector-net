using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerCallAdmissionControlPoliciesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableCallAdmissionControl;

    [XmlElement(ElementName = "enableCallAdmissionControl", IsNullable = false, Namespace = "")]
    public bool EnableCallAdmissionControl {
        get => _enableCallAdmissionControl;
        set {
            EnableCallAdmissionControlSpecified = true;
            _enableCallAdmissionControl = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallAdmissionControlSpecified { get; set; }
    private int _maxConcurrentNetworkSessions;

    [XmlElement(ElementName = "maxConcurrentNetworkSessions", IsNullable = false, Namespace = "")]
    public int MaxConcurrentNetworkSessions {
        get => _maxConcurrentNetworkSessions;
        set {
            MaxConcurrentNetworkSessionsSpecified = true;
            _maxConcurrentNetworkSessions = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentNetworkSessionsSpecified { get; set; }
    private int _maxConcurrentNetworkSessionsThreshold;

    [XmlElement(ElementName = "maxConcurrentNetworkSessionsThreshold", IsNullable = false, Namespace = "")]
    public int MaxConcurrentNetworkSessionsThreshold {
        get => _maxConcurrentNetworkSessionsThreshold;
        set {
            MaxConcurrentNetworkSessionsThresholdSpecified = true;
            _maxConcurrentNetworkSessionsThreshold = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentNetworkSessionsThresholdSpecified { get; set; }
    private int _maxNetworkCallsPerSecond;

    [XmlElement(ElementName = "maxNetworkCallsPerSecond", IsNullable = false, Namespace = "")]
    public int MaxNetworkCallsPerSecond {
        get => _maxNetworkCallsPerSecond;
        set {
            MaxNetworkCallsPerSecondSpecified = true;
            _maxNetworkCallsPerSecond = value;
        }
    }

    [XmlIgnore]
    public bool MaxNetworkCallsPerSecondSpecified { get; set; }
    private int _maxNetworkCallsPerSecondThreshold;

    [XmlElement(ElementName = "maxNetworkCallsPerSecondThreshold", IsNullable = false, Namespace = "")]
    public int MaxNetworkCallsPerSecondThreshold {
        get => _maxNetworkCallsPerSecondThreshold;
        set {
            MaxNetworkCallsPerSecondThresholdSpecified = true;
            _maxNetworkCallsPerSecondThreshold = value;
        }
    }

    [XmlIgnore]
    public bool MaxNetworkCallsPerSecondThresholdSpecified { get; set; }
    private int _maxConcurrentExternalSIPRECSessions;

    [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessions", IsNullable = false, Namespace = "")]
    public int MaxConcurrentExternalSIPRECSessions {
        get => _maxConcurrentExternalSIPRECSessions;
        set {
            MaxConcurrentExternalSIPRECSessionsSpecified = true;
            _maxConcurrentExternalSIPRECSessions = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentExternalSIPRECSessionsSpecified { get; set; }
    private int _maxConcurrentExternalSIPRECSessionsThreshold;

    [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessionsThreshold", IsNullable = false, Namespace = "")]
    public int MaxConcurrentExternalSIPRECSessionsThreshold {
        get => _maxConcurrentExternalSIPRECSessionsThreshold;
        set {
            MaxConcurrentExternalSIPRECSessionsThresholdSpecified = true;
            _maxConcurrentExternalSIPRECSessionsThreshold = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentExternalSIPRECSessionsThresholdSpecified { get; set; }
}
}
