using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCollaborateBridgeGetInstanceRequest.
    /// The system-level collaborate supportOutdial setting is returned in the response when the system-level
    /// collaborate
    /// supportOutdial setting is disabled.
    /// Contains the service profile information and a table of assigned owners.
    /// The table has column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", Phone Number", "Extension", "Department", "Email Address".
    /// Collaborate bridge maximum participant’s choices unlimited or a quantified number of participants.
    /// 
    /// Replaced by: GroupCollaborateBridgeGetInstanceResponse20sp1
        /// <see cref="GroupCollaborateBridgeGetInstanceRequest"/>
        /// <see cref="GroupCollaborateBridgeGetInstanceResponse20sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCollaborateBridgeGetInstanceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants _maximumBridgeParticipants;

        [XmlElement(ElementName = "maximumBridgeParticipants", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants MaximumBridgeParticipants {
            get => _maximumBridgeParticipants;
            set {
                MaximumBridgeParticipantsSpecified = true;
                _maximumBridgeParticipants = value;
            }
        }

        [XmlIgnore]
        public bool MaximumBridgeParticipantsSpecified { get; set; }
        
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
        
        private bool _isDefault;

        [XmlElement(ElementName = "isDefault", IsNullable = false, Namespace = "")]
        public bool IsDefault {
            get => _isDefault;
            set {
                IsDefaultSpecified = true;
                _isDefault = value;
            }
        }

        [XmlIgnore]
        public bool IsDefaultSpecified { get; set; }
        
        private int _maxCollaborateRoomParticipants;

        [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false, Namespace = "")]
        public int MaxCollaborateRoomParticipants {
            get => _maxCollaborateRoomParticipants;
            set {
                MaxCollaborateRoomParticipantsSpecified = true;
                _maxCollaborateRoomParticipants = value;
            }
        }

        [XmlIgnore]
        public bool MaxCollaborateRoomParticipantsSpecified { get; set; }
        
        private bool _supportOutdial;

        [XmlElement(ElementName = "supportOutdial", IsNullable = false, Namespace = "")]
        public bool SupportOutdial {
            get => _supportOutdial;
            set {
                SupportOutdialSpecified = true;
                _supportOutdial = value;
            }
        }

        [XmlIgnore]
        public bool SupportOutdialSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _collaborateOwnerUserTable;

        [XmlElement(ElementName = "collaborateOwnerUserTable", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CollaborateOwnerUserTable {
            get => _collaborateOwnerUserTable;
            set {
                CollaborateOwnerUserTableSpecified = true;
                _collaborateOwnerUserTable = value;
            }
        }

        [XmlIgnore]
        public bool CollaborateOwnerUserTableSpecified { get; set; }
        
    }
}
