using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCapacityManagementAddInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        private int _maxActiveCallsAllowed;

        [XmlElement(ElementName = "maxActiveCallsAllowed", IsNullable = false, Namespace = "")]
        public int MaxActiveCallsAllowed
        {
            get => _maxActiveCallsAllowed;
            set
            {
                MaxActiveCallsAllowedSpecified = true;
                _maxActiveCallsAllowed = value;
            }
        }

        [XmlIgnore]
        public bool MaxActiveCallsAllowedSpecified { get; set; }
        private int _maxIncomingActiveCallsAllowed;

        [XmlElement(ElementName = "maxIncomingActiveCallsAllowed", IsNullable = false, Namespace = "")]
        public int MaxIncomingActiveCallsAllowed
        {
            get => _maxIncomingActiveCallsAllowed;
            set
            {
                MaxIncomingActiveCallsAllowedSpecified = true;
                _maxIncomingActiveCallsAllowed = value;
            }
        }

        [XmlIgnore]
        public bool MaxIncomingActiveCallsAllowedSpecified { get; set; }
        private int _maxOutgoingActiveCallsAllowed;

        [XmlElement(ElementName = "maxOutgoingActiveCallsAllowed", IsNullable = false, Namespace = "")]
        public int MaxOutgoingActiveCallsAllowed
        {
            get => _maxOutgoingActiveCallsAllowed;
            set
            {
                MaxOutgoingActiveCallsAllowedSpecified = true;
                _maxOutgoingActiveCallsAllowed = value;
            }
        }

        [XmlIgnore]
        public bool MaxOutgoingActiveCallsAllowedSpecified { get; set; }
        private bool _becomeDefaultGroupForNewUsers;

        [XmlElement(ElementName = "becomeDefaultGroupForNewUsers", IsNullable = false, Namespace = "")]
        public bool BecomeDefaultGroupForNewUsers
        {
            get => _becomeDefaultGroupForNewUsers;
            set
            {
                BecomeDefaultGroupForNewUsersSpecified = true;
                _becomeDefaultGroupForNewUsers = value;
            }
        }

        [XmlIgnore]
        public bool BecomeDefaultGroupForNewUsersSpecified { get; set; }
        private List<string> _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public List<string> UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
    }
}
