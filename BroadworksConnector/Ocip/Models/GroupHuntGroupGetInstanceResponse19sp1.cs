using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupGetInstanceResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.HuntPolicy _policy;

    [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HuntPolicy Policy {
        get => _policy;
        set {
            PolicySpecified = true;
            _policy = value;
        }
    }

    [XmlIgnore]
    public bool PolicySpecified { get; set; }
    private bool _huntAfterNoAnswer;

    [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
    public bool HuntAfterNoAnswer {
        get => _huntAfterNoAnswer;
        set {
            HuntAfterNoAnswerSpecified = true;
            _huntAfterNoAnswer = value;
        }
    }

    [XmlIgnore]
    public bool HuntAfterNoAnswerSpecified { get; set; }
    private int _noAnswerNumberOfRings;

    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
    public int NoAnswerNumberOfRings {
        get => _noAnswerNumberOfRings;
        set {
            NoAnswerNumberOfRingsSpecified = true;
            _noAnswerNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerNumberOfRingsSpecified { get; set; }
    private bool _forwardAfterTimeout;

    [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
    public bool ForwardAfterTimeout {
        get => _forwardAfterTimeout;
        set {
            ForwardAfterTimeoutSpecified = true;
            _forwardAfterTimeout = value;
        }
    }

    [XmlIgnore]
    public bool ForwardAfterTimeoutSpecified { get; set; }
    private int _forwardTimeoutSeconds;

    [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int ForwardTimeoutSeconds {
        get => _forwardTimeoutSeconds;
        set {
            ForwardTimeoutSecondsSpecified = true;
            _forwardTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ForwardTimeoutSecondsSpecified { get; set; }
    private string _forwardToPhoneNumber;

    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
    public string ForwardToPhoneNumber {
        get => _forwardToPhoneNumber;
        set {
            ForwardToPhoneNumberSpecified = true;
            _forwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool ForwardToPhoneNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _agentUserTable;

    [XmlElement(ElementName = "agentUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentUserTable {
        get => _agentUserTable;
        set {
            AgentUserTableSpecified = true;
            _agentUserTable = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserTableSpecified { get; set; }
    private bool _allowCallWaitingForAgents;

    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
    public bool AllowCallWaitingForAgents {
        get => _allowCallWaitingForAgents;
        set {
            AllowCallWaitingForAgentsSpecified = true;
            _allowCallWaitingForAgents = value;
        }
    }

    [XmlIgnore]
    public bool AllowCallWaitingForAgentsSpecified { get; set; }
    private bool _useSystemHuntGroupCLIDSetting;

    [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false, Namespace = "")]
    public bool UseSystemHuntGroupCLIDSetting {
        get => _useSystemHuntGroupCLIDSetting;
        set {
            UseSystemHuntGroupCLIDSettingSpecified = true;
            _useSystemHuntGroupCLIDSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemHuntGroupCLIDSettingSpecified { get; set; }
    private bool _includeHuntGroupNameInCLID;

    [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false, Namespace = "")]
    public bool IncludeHuntGroupNameInCLID {
        get => _includeHuntGroupNameInCLID;
        set {
            IncludeHuntGroupNameInCLIDSpecified = true;
            _includeHuntGroupNameInCLID = value;
        }
    }

    [XmlIgnore]
    public bool IncludeHuntGroupNameInCLIDSpecified { get; set; }
    private bool _enableNotReachableForwarding;

    [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false, Namespace = "")]
    public bool EnableNotReachableForwarding {
        get => _enableNotReachableForwarding;
        set {
            EnableNotReachableForwardingSpecified = true;
            _enableNotReachableForwarding = value;
        }
    }

    [XmlIgnore]
    public bool EnableNotReachableForwardingSpecified { get; set; }
    private string _notReachableForwardToPhoneNumber;

    [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = false, Namespace = "")]
    public string NotReachableForwardToPhoneNumber {
        get => _notReachableForwardToPhoneNumber;
        set {
            NotReachableForwardToPhoneNumberSpecified = true;
            _notReachableForwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool NotReachableForwardToPhoneNumberSpecified { get; set; }
    private bool _makeBusyWhenNotReachable;

    [XmlElement(ElementName = "makeBusyWhenNotReachable", IsNullable = false, Namespace = "")]
    public bool MakeBusyWhenNotReachable {
        get => _makeBusyWhenNotReachable;
        set {
            MakeBusyWhenNotReachableSpecified = true;
            _makeBusyWhenNotReachable = value;
        }
    }

    [XmlIgnore]
    public bool MakeBusyWhenNotReachableSpecified { get; set; }
    private bool _allowMembersToControlGroupBusy;

    [XmlElement(ElementName = "allowMembersToControlGroupBusy", IsNullable = false, Namespace = "")]
    public bool AllowMembersToControlGroupBusy {
        get => _allowMembersToControlGroupBusy;
        set {
            AllowMembersToControlGroupBusySpecified = true;
            _allowMembersToControlGroupBusy = value;
        }
    }

    [XmlIgnore]
    public bool AllowMembersToControlGroupBusySpecified { get; set; }
    private bool _enableGroupBusy;

    [XmlElement(ElementName = "enableGroupBusy", IsNullable = false, Namespace = "")]
    public bool EnableGroupBusy {
        get => _enableGroupBusy;
        set {
            EnableGroupBusySpecified = true;
            _enableGroupBusy = value;
        }
    }

    [XmlIgnore]
    public bool EnableGroupBusySpecified { get; set; }
    private string _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public string NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
}
}
