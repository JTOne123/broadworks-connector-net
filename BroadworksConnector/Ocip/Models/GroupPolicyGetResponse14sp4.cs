using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPolicyGetResponse14sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.GroupCallingPlanAccess _callingPlanAccess;

    [XmlElement(ElementName = "callingPlanAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupCallingPlanAccess CallingPlanAccess {
        get => _callingPlanAccess;
        set {
            CallingPlanAccessSpecified = true;
            _callingPlanAccess = value;
        }
    }

    [XmlIgnore]
    public bool CallingPlanAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupExtensionAccess _extensionAccess;

    [XmlElement(ElementName = "extensionAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupExtensionAccess ExtensionAccess {
        get => _extensionAccess;
        set {
            ExtensionAccessSpecified = true;
            _extensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool ExtensionAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupLDAPIntegrationAccess _ldapIntegrationAccess;

    [XmlElement(ElementName = "ldapIntegrationAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupLDAPIntegrationAccess LdapIntegrationAccess {
        get => _ldapIntegrationAccess;
        set {
            LdapIntegrationAccessSpecified = true;
            _ldapIntegrationAccess = value;
        }
    }

    [XmlIgnore]
    public bool LdapIntegrationAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupVoiceMessagingAccess _voiceMessagingAccess;

    [XmlElement(ElementName = "voiceMessagingAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupVoiceMessagingAccess VoiceMessagingAccess {
        get => _voiceMessagingAccess;
        set {
            VoiceMessagingAccessSpecified = true;
            _voiceMessagingAccess = value;
        }
    }

    [XmlIgnore]
    public bool VoiceMessagingAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupDepartmentAdminUserAccess _departmentAdminUserAccess;

    [XmlElement(ElementName = "departmentAdminUserAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminUserAccess DepartmentAdminUserAccess {
        get => _departmentAdminUserAccess;
        set {
            DepartmentAdminUserAccessSpecified = true;
            _departmentAdminUserAccess = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentAdminUserAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess _departmentAdminTrunkGroupAccess;

    [XmlElement(ElementName = "departmentAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess DepartmentAdminTrunkGroupAccess {
        get => _departmentAdminTrunkGroupAccess;
        set {
            DepartmentAdminTrunkGroupAccessSpecified = true;
            _departmentAdminTrunkGroupAccess = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentAdminTrunkGroupAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserAuthenticationAccess _userAuthenticationAccess;

    [XmlElement(ElementName = "userAuthenticationAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserAuthenticationAccess UserAuthenticationAccess {
        get => _userAuthenticationAccess;
        set {
            UserAuthenticationAccessSpecified = true;
            _userAuthenticationAccess = value;
        }
    }

    [XmlIgnore]
    public bool UserAuthenticationAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserGroupDirectoryAccess _userGroupDirectoryAccess;

    [XmlElement(ElementName = "userGroupDirectoryAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserGroupDirectoryAccess UserGroupDirectoryAccess {
        get => _userGroupDirectoryAccess;
        set {
            UserGroupDirectoryAccessSpecified = true;
            _userGroupDirectoryAccess = value;
        }
    }

    [XmlIgnore]
    public bool UserGroupDirectoryAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserProfileAccess _userProfileAccess;

    [XmlElement(ElementName = "userProfileAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserProfileAccess UserProfileAccess {
        get => _userProfileAccess;
        set {
            UserProfileAccessSpecified = true;
            _userProfileAccess = value;
        }
    }

    [XmlIgnore]
    public bool UserProfileAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupUserCallLogAccess _userEnhancedCallLogAccess;

    [XmlElement(ElementName = "userEnhancedCallLogAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupUserCallLogAccess UserEnhancedCallLogAccess {
        get => _userEnhancedCallLogAccess;
        set {
            UserEnhancedCallLogAccessSpecified = true;
            _userEnhancedCallLogAccess = value;
        }
    }

    [XmlIgnore]
    public bool UserEnhancedCallLogAccessSpecified { get; set; }
}
}
