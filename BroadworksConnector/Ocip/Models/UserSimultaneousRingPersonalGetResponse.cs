using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingPersonalGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.SimultaneousRingSelection _incomingCalls;

    [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SimultaneousRingSelection IncomingCalls {
        get => _incomingCalls;
        set {
            IncomingCallsSpecified = true;
            _incomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool IncomingCallsSpecified { get; set; }
    private List<string> _simRingPhoneNumber;

    [XmlElement(ElementName = "simRingPhoneNumber", IsNullable = false, Namespace = "")]
    public List<string> SimRingPhoneNumber {
        get => _simRingPhoneNumber;
        set {
            SimRingPhoneNumberSpecified = true;
            _simRingPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool SimRingPhoneNumberSpecified { get; set; }
}
}
