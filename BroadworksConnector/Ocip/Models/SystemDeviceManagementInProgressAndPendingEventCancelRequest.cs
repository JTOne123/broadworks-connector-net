using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementInProgressAndPendingEventCancelRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _cancelAllEvents;

    [XmlElement(ElementName = "cancelAllEvents", IsNullable = false, Namespace = "")]
    public string CancelAllEvents {
        get => _cancelAllEvents;
        set {
            CancelAllEventsSpecified = true;
            _cancelAllEvents = value;
        }
    }

    [XmlIgnore]
    public bool CancelAllEventsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents _cancelMultipleEvents;

    [XmlElement(ElementName = "cancelMultipleEvents", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents CancelMultipleEvents {
        get => _cancelMultipleEvents;
        set {
            CancelMultipleEventsSpecified = true;
            _cancelMultipleEvents = value;
        }
    }

    [XmlIgnore]
    public bool CancelMultipleEventsSpecified { get; set; }
    private List<int> _eventId;

    [XmlElement(ElementName = "eventId", IsNullable = false, Namespace = "")]
    public List<int> EventId {
        get => _eventId;
        set {
            EventIdSpecified = true;
            _eventId = value;
        }
    }

    [XmlIgnore]
    public bool EventIdSpecified { get; set; }
}
}
