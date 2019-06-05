using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSessionAuditModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private int _intervalSeconds;

    [XmlElement(ElementName = "intervalSeconds", IsNullable = false, Namespace = "")]
    public int IntervalSeconds {
        get => _intervalSeconds;
        set {
            IntervalSecondsSpecified = true;
            _intervalSeconds = value;
        }
    }

    [XmlIgnore]
    public bool IntervalSecondsSpecified { get; set; }
    private int _timeoutPeriodSeconds;

    [XmlElement(ElementName = "timeoutPeriodSeconds", IsNullable = false, Namespace = "")]
    public int TimeoutPeriodSeconds {
        get => _timeoutPeriodSeconds;
        set {
            TimeoutPeriodSecondsSpecified = true;
            _timeoutPeriodSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeoutPeriodSecondsSpecified { get; set; }
}
}
