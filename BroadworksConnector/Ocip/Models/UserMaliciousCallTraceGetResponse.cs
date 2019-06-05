using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMaliciousCallTraceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection _traceTypeSelection;

    [XmlElement(ElementName = "traceTypeSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection TraceTypeSelection {
        get => _traceTypeSelection;
        set {
            TraceTypeSelectionSpecified = true;
            _traceTypeSelection = value;
        }
    }

    [XmlIgnore]
    public bool TraceTypeSelectionSpecified { get; set; }
    private bool _traceForTimePeriod;

    [XmlElement(ElementName = "traceForTimePeriod", IsNullable = false, Namespace = "")]
    public bool TraceForTimePeriod {
        get => _traceForTimePeriod;
        set {
            TraceForTimePeriodSpecified = true;
            _traceForTimePeriod = value;
        }
    }

    [XmlIgnore]
    public bool TraceForTimePeriodSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MaliciousCallTraceTimePeriod _traceTimePeriod;

    [XmlElement(ElementName = "traceTimePeriod", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MaliciousCallTraceTimePeriod TraceTimePeriod {
        get => _traceTimePeriod;
        set {
            TraceTimePeriodSpecified = true;
            _traceTimePeriod = value;
        }
    }

    [XmlIgnore]
    public bool TraceTimePeriodSpecified { get; set; }
}
}
