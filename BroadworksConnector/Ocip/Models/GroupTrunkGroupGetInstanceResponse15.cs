using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceResponse15 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _pilotUserId;

    [XmlElement(ElementName = "pilotUserId", IsNullable = false, Namespace = "")]
    public string PilotUserId {
        get => _pilotUserId;
        set {
            PilotUserIdSpecified = true;
            _pilotUserId = value;
        }
    }

    [XmlIgnore]
    public bool PilotUserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.DepartmentKey _department;

    [XmlElement(ElementName = "department", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department {
        get => _department;
        set {
            DepartmentSpecified = true;
            _department = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AccessDevice _accessDevice;

    [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice {
        get => _accessDevice;
        set {
            AccessDeviceSpecified = true;
            _accessDevice = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceSpecified { get; set; }
    private int _maxActiveCalls;

    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
    public int MaxActiveCalls {
        get => _maxActiveCalls;
        set {
            MaxActiveCallsSpecified = true;
            _maxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxActiveCallsSpecified { get; set; }
    private int _maxIncomingCalls;

    [XmlElement(ElementName = "maxIncomingCalls", IsNullable = false, Namespace = "")]
    public int MaxIncomingCalls {
        get => _maxIncomingCalls;
        set {
            MaxIncomingCallsSpecified = true;
            _maxIncomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxIncomingCallsSpecified { get; set; }
    private int _maxOutgoingCalls;

    [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = false, Namespace = "")]
    public int MaxOutgoingCalls {
        get => _maxOutgoingCalls;
        set {
            MaxOutgoingCallsSpecified = true;
            _maxOutgoingCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxOutgoingCallsSpecified { get; set; }
    private bool _enableBursting;

    [XmlElement(ElementName = "enableBursting", IsNullable = false, Namespace = "")]
    public bool EnableBursting {
        get => _enableBursting;
        set {
            EnableBurstingSpecified = true;
            _enableBursting = value;
        }
    }

    [XmlIgnore]
    public bool EnableBurstingSpecified { get; set; }
    private int _burstingMaxActiveCalls;

    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
    public int BurstingMaxActiveCalls {
        get => _burstingMaxActiveCalls;
        set {
            BurstingMaxActiveCallsSpecified = true;
            _burstingMaxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxActiveCallsSpecified { get; set; }
    private int _burstingMaxIncomingCalls;

    [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = false, Namespace = "")]
    public int BurstingMaxIncomingCalls {
        get => _burstingMaxIncomingCalls;
        set {
            BurstingMaxIncomingCallsSpecified = true;
            _burstingMaxIncomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxIncomingCallsSpecified { get; set; }
    private int _burstingMaxOutgoingCalls;

    [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = false, Namespace = "")]
    public int BurstingMaxOutgoingCalls {
        get => _burstingMaxOutgoingCalls;
        set {
            BurstingMaxOutgoingCallsSpecified = true;
            _burstingMaxOutgoingCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxOutgoingCallsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkGroupCapacityExceededAction _capacityExceededAction;

    [XmlElement(ElementName = "capacityExceededAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupCapacityExceededAction CapacityExceededAction {
        get => _capacityExceededAction;
        set {
            CapacityExceededActionSpecified = true;
            _capacityExceededAction = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededActionSpecified { get; set; }
    private string _capacityExceededForwardAddress;

    [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = false, Namespace = "")]
    public string CapacityExceededForwardAddress {
        get => _capacityExceededForwardAddress;
        set {
            CapacityExceededForwardAddressSpecified = true;
            _capacityExceededForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededForwardAddressSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkGroupKey _capacityExceededRerouteTrunkGroupKey;

    [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey CapacityExceededRerouteTrunkGroupKey {
        get => _capacityExceededRerouteTrunkGroupKey;
        set {
            CapacityExceededRerouteTrunkGroupKeySpecified = true;
            _capacityExceededRerouteTrunkGroupKey = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededRerouteTrunkGroupKeySpecified { get; set; }
    private int _capacityExceededTrapInitialCalls;

    [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
    public int CapacityExceededTrapInitialCalls {
        get => _capacityExceededTrapInitialCalls;
        set {
            CapacityExceededTrapInitialCallsSpecified = true;
            _capacityExceededTrapInitialCalls = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededTrapInitialCallsSpecified { get; set; }
    private int _capacityExceededTrapOffsetCalls;

    [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
    public int CapacityExceededTrapOffsetCalls {
        get => _capacityExceededTrapOffsetCalls;
        set {
            CapacityExceededTrapOffsetCallsSpecified = true;
            _capacityExceededTrapOffsetCalls = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededTrapOffsetCallsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction _unreachableDestinationAction;

    [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction UnreachableDestinationAction {
        get => _unreachableDestinationAction;
        set {
            UnreachableDestinationActionSpecified = true;
            _unreachableDestinationAction = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationActionSpecified { get; set; }
    private string _unreachableDestinationForwardAddress;

    [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = false, Namespace = "")]
    public string UnreachableDestinationForwardAddress {
        get => _unreachableDestinationForwardAddress;
        set {
            UnreachableDestinationForwardAddressSpecified = true;
            _unreachableDestinationForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationForwardAddressSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkGroupKey _unreachableDestinationRerouteTrunkGroupKey;

    [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey UnreachableDestinationRerouteTrunkGroupKey {
        get => _unreachableDestinationRerouteTrunkGroupKey;
        set {
            UnreachableDestinationRerouteTrunkGroupKeySpecified = true;
            _unreachableDestinationRerouteTrunkGroupKey = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationRerouteTrunkGroupKeySpecified { get; set; }
    private int _invitationTimeout;

    [XmlElement(ElementName = "invitationTimeout", IsNullable = false, Namespace = "")]
    public int InvitationTimeout {
        get => _invitationTimeout;
        set {
            InvitationTimeoutSpecified = true;
            _invitationTimeout = value;
        }
    }

    [XmlIgnore]
    public bool InvitationTimeoutSpecified { get; set; }
    private bool _requireAuthentication;

    [XmlElement(ElementName = "requireAuthentication", IsNullable = false, Namespace = "")]
    public bool RequireAuthentication {
        get => _requireAuthentication;
        set {
            RequireAuthenticationSpecified = true;
            _requireAuthentication = value;
        }
    }

    [XmlIgnore]
    public bool RequireAuthenticationSpecified { get; set; }
    private string _sipAuthenticationUserName;

    [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
    public string SipAuthenticationUserName {
        get => _sipAuthenticationUserName;
        set {
            SipAuthenticationUserNameSpecified = true;
            _sipAuthenticationUserName = value;
        }
    }

    [XmlIgnore]
    public bool SipAuthenticationUserNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _hostedUserTable;

    [XmlElement(ElementName = "hostedUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable HostedUserTable {
        get => _hostedUserTable;
        set {
            HostedUserTableSpecified = true;
            _hostedUserTable = value;
        }
    }

    [XmlIgnore]
    public bool HostedUserTableSpecified { get; set; }
}
}
