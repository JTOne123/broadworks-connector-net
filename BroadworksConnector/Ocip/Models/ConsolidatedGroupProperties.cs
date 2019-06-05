using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class ConsolidatedGroupProperties
    {
        private string _defaultDomain;

        [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
        public string DefaultDomain
        {
            get => _defaultDomain;
            set
            {
                DefaultDomainSpecified = true;
                _defaultDomain = value;
            }
        }

        [XmlIgnore]
        public bool DefaultDomainSpecified { get; set; }
        private int _userLimit;

        [XmlElement(ElementName = "userLimit", IsNullable = false, Namespace = "")]
        public int UserLimit
        {
            get => _userLimit;
            set
            {
                UserLimitSpecified = true;
                _userLimit = value;
            }
        }

        [XmlIgnore]
        public bool UserLimitSpecified { get; set; }
        private string _groupName;

        [XmlElement(ElementName = "groupName", IsNullable = false, Namespace = "")]
        public string GroupName
        {
            get => _groupName;
            set
            {
                GroupNameSpecified = true;
                _groupName = value;
            }
        }

        [XmlIgnore]
        public bool GroupNameSpecified { get; set; }
        private string _callingLineIdName;

        [XmlElement(ElementName = "callingLineIdName", IsNullable = false, Namespace = "")]
        public string CallingLineIdName
        {
            get => _callingLineIdName;
            set
            {
                CallingLineIdNameSpecified = true;
                _callingLineIdName = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdNameSpecified { get; set; }
        private string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        public string TimeZone
        {
            get => _timeZone;
            set
            {
                TimeZoneSpecified = true;
                _timeZone = value;
            }
        }

        [XmlIgnore]
        public bool TimeZoneSpecified { get; set; }
        private string _locationDialingCode;

        [XmlElement(ElementName = "locationDialingCode", IsNullable = false, Namespace = "")]
        public string LocationDialingCode
        {
            get => _locationDialingCode;
            set
            {
                LocationDialingCodeSpecified = true;
                _locationDialingCode = value;
            }
        }

        [XmlIgnore]
        public bool LocationDialingCodeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.Contact _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.Contact Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        public bool ContactSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.StreetAddress _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.StreetAddress Address
        {
            get => _address;
            set
            {
                AddressSpecified = true;
                _address = value;
            }
        }

        [XmlIgnore]
        public bool AddressSpecified { get; set; }
        private List<string> _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        public List<string> NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.DefaultNetworkClassOfService _defaultNetworkClassOfService;

        [XmlElement(ElementName = "defaultNetworkClassOfService", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.DefaultNetworkClassOfService DefaultNetworkClassOfService
        {
            get => _defaultNetworkClassOfService;
            set
            {
                DefaultNetworkClassOfServiceSpecified = true;
                _defaultNetworkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool DefaultNetworkClassOfServiceSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.ConsolidatedGroupServiceAssignment> _groupService;

        [XmlElement(ElementName = "groupService", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.ConsolidatedGroupServiceAssignment> GroupService
        {
            get => _groupService;
            set
            {
                GroupServiceSpecified = true;
                _groupService = value;
            }
        }

        [XmlIgnore]
        public bool GroupServiceSpecified { get; set; }
        private string _servicePolicy;

        [XmlElement(ElementName = "servicePolicy", IsNullable = false, Namespace = "")]
        public string ServicePolicy
        {
            get => _servicePolicy;
            set
            {
                ServicePolicySpecified = true;
                _servicePolicy = value;
            }
        }

        [XmlIgnore]
        public bool ServicePolicySpecified { get; set; }
    }
}
