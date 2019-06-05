using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileCallCenterProfileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _callProcessingPolicyProfileName;

    [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
    public string CallProcessingPolicyProfileName {
        get => _callProcessingPolicyProfileName;
        set {
            CallProcessingPolicyProfileNameSpecified = true;
            _callProcessingPolicyProfileName = value;
        }
    }

    [XmlIgnore]
    public bool CallProcessingPolicyProfileNameSpecified { get; set; }
    private bool _useCLIDPolicy;

    [XmlElement(ElementName = "useCLIDPolicy", IsNullable = false, Namespace = "")]
    public bool UseCLIDPolicy {
        get => _useCLIDPolicy;
        set {
            UseCLIDPolicySpecified = true;
            _useCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool UseCLIDPolicySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupCLIDPolicy _clidPolicy;

    [XmlElement(ElementName = "clidPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupCLIDPolicy ClidPolicy {
        get => _clidPolicy;
        set {
            ClidPolicySpecified = true;
            _clidPolicy = value;
        }
    }

    [XmlIgnore]
    public bool ClidPolicySpecified { get; set; }
    private bool _allowAlternateNumbersForRedirectingIdentity;

    [XmlElement(ElementName = "allowAlternateNumbersForRedirectingIdentity", IsNullable = false, Namespace = "")]
    public bool AllowAlternateNumbersForRedirectingIdentity {
        get => _allowAlternateNumbersForRedirectingIdentity;
        set {
            AllowAlternateNumbersForRedirectingIdentitySpecified = true;
            _allowAlternateNumbersForRedirectingIdentity = value;
        }
    }

    [XmlIgnore]
    public bool AllowAlternateNumbersForRedirectingIdentitySpecified { get; set; }
    private bool _useGroupName;

    [XmlElement(ElementName = "useGroupName", IsNullable = false, Namespace = "")]
    public bool UseGroupName {
        get => _useGroupName;
        set {
            UseGroupNameSpecified = true;
            _useGroupName = value;
        }
    }

    [XmlIgnore]
    public bool UseGroupNameSpecified { get; set; }
    private bool _blockCallingNameForExternalCalls;

    [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false, Namespace = "")]
    public bool BlockCallingNameForExternalCalls {
        get => _blockCallingNameForExternalCalls;
        set {
            BlockCallingNameForExternalCallsSpecified = true;
            _blockCallingNameForExternalCalls = value;
        }
    }

    [XmlIgnore]
    public bool BlockCallingNameForExternalCallsSpecified { get; set; }
    private bool _allowConfigurableCLIDForRedirectingIdentity;

    [XmlElement(ElementName = "allowConfigurableCLIDForRedirectingIdentity", IsNullable = false, Namespace = "")]
    public bool AllowConfigurableCLIDForRedirectingIdentity {
        get => _allowConfigurableCLIDForRedirectingIdentity;
        set {
            AllowConfigurableCLIDForRedirectingIdentitySpecified = true;
            _allowConfigurableCLIDForRedirectingIdentity = value;
        }
    }

    [XmlIgnore]
    public bool AllowConfigurableCLIDForRedirectingIdentitySpecified { get; set; }
    private bool _allowDepartmentCLIDNameOverride;

    [XmlElement(ElementName = "allowDepartmentCLIDNameOverride", IsNullable = false, Namespace = "")]
    public bool AllowDepartmentCLIDNameOverride {
        get => _allowDepartmentCLIDNameOverride;
        set {
            AllowDepartmentCLIDNameOverrideSpecified = true;
            _allowDepartmentCLIDNameOverride = value;
        }
    }

    [XmlIgnore]
    public bool AllowDepartmentCLIDNameOverrideSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseCallsCLIDPolicy;

    [XmlElement(ElementName = "enterpriseCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseCallsCLIDPolicy {
        get => _enterpriseCallsCLIDPolicy;
        set {
            EnterpriseCallsCLIDPolicySpecified = true;
            _enterpriseCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseCallsCLIDPolicySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseGroupCallsCLIDPolicy;

    [XmlElement(ElementName = "enterpriseGroupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseGroupCallsCLIDPolicy {
        get => _enterpriseGroupCallsCLIDPolicy;
        set {
            EnterpriseGroupCallsCLIDPolicySpecified = true;
            _enterpriseGroupCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseGroupCallsCLIDPolicySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy _serviceProviderGroupCallsCLIDPolicy;

    [XmlElement(ElementName = "serviceProviderGroupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy ServiceProviderGroupCallsCLIDPolicy {
        get => _serviceProviderGroupCallsCLIDPolicy;
        set {
            ServiceProviderGroupCallsCLIDPolicySpecified = true;
            _serviceProviderGroupCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderGroupCallsCLIDPolicySpecified { get; set; }
    private bool _useCallLimitsPolicy;

    [XmlElement(ElementName = "useCallLimitsPolicy", IsNullable = false, Namespace = "")]
    public bool UseCallLimitsPolicy {
        get => _useCallLimitsPolicy;
        set {
            UseCallLimitsPolicySpecified = true;
            _useCallLimitsPolicy = value;
        }
    }

    [XmlIgnore]
    public bool UseCallLimitsPolicySpecified { get; set; }
    private bool _useMaxSimultaneousCalls;

    [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false, Namespace = "")]
    public bool UseMaxSimultaneousCalls {
        get => _useMaxSimultaneousCalls;
        set {
            UseMaxSimultaneousCallsSpecified = true;
            _useMaxSimultaneousCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxSimultaneousCallsSpecified { get; set; }
    private int _maxSimultaneousCalls;

    [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false, Namespace = "")]
    public int MaxSimultaneousCalls {
        get => _maxSimultaneousCalls;
        set {
            MaxSimultaneousCallsSpecified = true;
            _maxSimultaneousCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxSimultaneousCallsSpecified { get; set; }
    private bool _useMaxSimultaneousVideoCalls;

    [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
    public bool UseMaxSimultaneousVideoCalls {
        get => _useMaxSimultaneousVideoCalls;
        set {
            UseMaxSimultaneousVideoCallsSpecified = true;
            _useMaxSimultaneousVideoCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxSimultaneousVideoCallsSpecified { get; set; }
    private int _maxSimultaneousVideoCalls;

    [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
    public int MaxSimultaneousVideoCalls {
        get => _maxSimultaneousVideoCalls;
        set {
            MaxSimultaneousVideoCallsSpecified = true;
            _maxSimultaneousVideoCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxSimultaneousVideoCallsSpecified { get; set; }
    private bool _useMaxConcurrentRedirectedCalls;

    [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
    public bool UseMaxConcurrentRedirectedCalls {
        get => _useMaxConcurrentRedirectedCalls;
        set {
            UseMaxConcurrentRedirectedCallsSpecified = true;
            _useMaxConcurrentRedirectedCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxConcurrentRedirectedCallsSpecified { get; set; }
    private int _maxConcurrentRedirectedCalls;

    [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
    public int MaxConcurrentRedirectedCalls {
        get => _maxConcurrentRedirectedCalls;
        set {
            MaxConcurrentRedirectedCallsSpecified = true;
            _maxConcurrentRedirectedCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentRedirectedCallsSpecified { get; set; }
    private bool _useMaxFindMeFollowMeDepth;

    [XmlElement(ElementName = "useMaxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
    public bool UseMaxFindMeFollowMeDepth {
        get => _useMaxFindMeFollowMeDepth;
        set {
            UseMaxFindMeFollowMeDepthSpecified = true;
            _useMaxFindMeFollowMeDepth = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxFindMeFollowMeDepthSpecified { get; set; }
    private bool _useMaxConcurrentFindMeFollowMeInvocations;

    [XmlElement(ElementName = "useMaxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
    public bool UseMaxConcurrentFindMeFollowMeInvocations {
        get => _useMaxConcurrentFindMeFollowMeInvocations;
        set {
            UseMaxConcurrentFindMeFollowMeInvocationsSpecified = true;
            _useMaxConcurrentFindMeFollowMeInvocations = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }
    private int _maxConcurrentFindMeFollowMeInvocations;

    [XmlElement(ElementName = "maxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
    public int MaxConcurrentFindMeFollowMeInvocations {
        get => _maxConcurrentFindMeFollowMeInvocations;
        set {
            MaxConcurrentFindMeFollowMeInvocationsSpecified = true;
            _maxConcurrentFindMeFollowMeInvocations = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }
    private int _maxFindMeFollowMeDepth;

    [XmlElement(ElementName = "maxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
    public int MaxFindMeFollowMeDepth {
        get => _maxFindMeFollowMeDepth;
        set {
            MaxFindMeFollowMeDepthSpecified = true;
            _maxFindMeFollowMeDepth = value;
        }
    }

    [XmlIgnore]
    public bool MaxFindMeFollowMeDepthSpecified { get; set; }
    private int _maxRedirectionDepth;

    [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false, Namespace = "")]
    public int MaxRedirectionDepth {
        get => _maxRedirectionDepth;
        set {
            MaxRedirectionDepthSpecified = true;
            _maxRedirectionDepth = value;
        }
    }

    [XmlIgnore]
    public bool MaxRedirectionDepthSpecified { get; set; }
    private bool _useTranslationRoutingPolicy;

    [XmlElement(ElementName = "useTranslationRoutingPolicy", IsNullable = false, Namespace = "")]
    public bool UseTranslationRoutingPolicy {
        get => _useTranslationRoutingPolicy;
        set {
            UseTranslationRoutingPolicySpecified = true;
            _useTranslationRoutingPolicy = value;
        }
    }

    [XmlIgnore]
    public bool UseTranslationRoutingPolicySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkUsageSelection _networkUsageSelection;

    [XmlElement(ElementName = "networkUsageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkUsageSelection NetworkUsageSelection {
        get => _networkUsageSelection;
        set {
            NetworkUsageSelectionSpecified = true;
            _networkUsageSelection = value;
        }
    }

    [XmlIgnore]
    public bool NetworkUsageSelectionSpecified { get; set; }
    private bool _enableEnterpriseExtensionDialing;

    [XmlElement(ElementName = "enableEnterpriseExtensionDialing", IsNullable = false, Namespace = "")]
    public bool EnableEnterpriseExtensionDialing {
        get => _enableEnterpriseExtensionDialing;
        set {
            EnableEnterpriseExtensionDialingSpecified = true;
            _enableEnterpriseExtensionDialing = value;
        }
    }

    [XmlIgnore]
    public bool EnableEnterpriseExtensionDialingSpecified { get; set; }
    private bool _enforceGroupCallingLineIdentityRestriction;

    [XmlElement(ElementName = "enforceGroupCallingLineIdentityRestriction", IsNullable = false, Namespace = "")]
    public bool EnforceGroupCallingLineIdentityRestriction {
        get => _enforceGroupCallingLineIdentityRestriction;
        set {
            EnforceGroupCallingLineIdentityRestrictionSpecified = true;
            _enforceGroupCallingLineIdentityRestriction = value;
        }
    }

    [XmlIgnore]
    public bool EnforceGroupCallingLineIdentityRestrictionSpecified { get; set; }
    private bool _enforceEnterpriseCallingLineIdentityRestriction;

    [XmlElement(ElementName = "enforceEnterpriseCallingLineIdentityRestriction", IsNullable = false, Namespace = "")]
    public bool EnforceEnterpriseCallingLineIdentityRestriction {
        get => _enforceEnterpriseCallingLineIdentityRestriction;
        set {
            EnforceEnterpriseCallingLineIdentityRestrictionSpecified = true;
            _enforceEnterpriseCallingLineIdentityRestriction = value;
        }
    }

    [XmlIgnore]
    public bool EnforceEnterpriseCallingLineIdentityRestrictionSpecified { get; set; }
    private bool _allowEnterpriseGroupCallTypingForPrivateDialingPlan;

    [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPrivateDialingPlan", IsNullable = false, Namespace = "")]
    public bool AllowEnterpriseGroupCallTypingForPrivateDialingPlan {
        get => _allowEnterpriseGroupCallTypingForPrivateDialingPlan;
        set {
            AllowEnterpriseGroupCallTypingForPrivateDialingPlanSpecified = true;
            _allowEnterpriseGroupCallTypingForPrivateDialingPlan = value;
        }
    }

    [XmlIgnore]
    public bool AllowEnterpriseGroupCallTypingForPrivateDialingPlanSpecified { get; set; }
    private bool _allowEnterpriseGroupCallTypingForPublicDialingPlan;

    [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPublicDialingPlan", IsNullable = false, Namespace = "")]
    public bool AllowEnterpriseGroupCallTypingForPublicDialingPlan {
        get => _allowEnterpriseGroupCallTypingForPublicDialingPlan;
        set {
            AllowEnterpriseGroupCallTypingForPublicDialingPlanSpecified = true;
            _allowEnterpriseGroupCallTypingForPublicDialingPlan = value;
        }
    }

    [XmlIgnore]
    public bool AllowEnterpriseGroupCallTypingForPublicDialingPlanSpecified { get; set; }
    private bool _overrideCLIDRestrictionForPrivateCallCategory;

    [XmlElement(ElementName = "overrideCLIDRestrictionForPrivateCallCategory", IsNullable = false, Namespace = "")]
    public bool OverrideCLIDRestrictionForPrivateCallCategory {
        get => _overrideCLIDRestrictionForPrivateCallCategory;
        set {
            OverrideCLIDRestrictionForPrivateCallCategorySpecified = true;
            _overrideCLIDRestrictionForPrivateCallCategory = value;
        }
    }

    [XmlIgnore]
    public bool OverrideCLIDRestrictionForPrivateCallCategorySpecified { get; set; }
    private bool _useIncomingCLIDPolicy;

    [XmlElement(ElementName = "useIncomingCLIDPolicy", IsNullable = false, Namespace = "")]
    public bool UseIncomingCLIDPolicy {
        get => _useIncomingCLIDPolicy;
        set {
            UseIncomingCLIDPolicySpecified = true;
            _useIncomingCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool UseIncomingCLIDPolicySpecified { get; set; }
    private bool _enableDialableCallerID;

    [XmlElement(ElementName = "enableDialableCallerID", IsNullable = false, Namespace = "")]
    public bool EnableDialableCallerID {
        get => _enableDialableCallerID;
        set {
            EnableDialableCallerIDSpecified = true;
            _enableDialableCallerID = value;
        }
    }

    [XmlIgnore]
    public bool EnableDialableCallerIDSpecified { get; set; }
    private bool _includeRedirectionsInMaximumNumberOfConcurrentCalls;

    [XmlElement(ElementName = "includeRedirectionsInMaximumNumberOfConcurrentCalls", IsNullable = false, Namespace = "")]
    public bool IncludeRedirectionsInMaximumNumberOfConcurrentCalls {
        get => _includeRedirectionsInMaximumNumberOfConcurrentCalls;
        set {
            IncludeRedirectionsInMaximumNumberOfConcurrentCallsSpecified = true;
            _includeRedirectionsInMaximumNumberOfConcurrentCalls = value;
        }
    }

    [XmlIgnore]
    public bool IncludeRedirectionsInMaximumNumberOfConcurrentCallsSpecified { get; set; }
    private bool _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable;

    [XmlElement(ElementName = "useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable", IsNullable = false, Namespace = "")]
    public bool UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable {
        get => _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable;
        set {
            UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailableSpecified = true;
            _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable = value;
        }
    }

    [XmlIgnore]
    public bool UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailableSpecified { get; set; }
    private bool _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable;

    [XmlElement(ElementName = "useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable", IsNullable = false, Namespace = "")]
    public bool UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable {
        get => _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable;
        set {
            UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailableSpecified = true;
            _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable = value;
        }
    }

    [XmlIgnore]
    public bool UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailableSpecified { get; set; }
}
}
