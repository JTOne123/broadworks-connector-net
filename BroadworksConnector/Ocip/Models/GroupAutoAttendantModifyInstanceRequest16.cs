using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAutoAttendantModifyInstanceRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        public bool EnableVideo
        {
            get => _enableVideo;
            set
            {
                EnableVideoSpecified = true;
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        public bool EnableVideoSpecified { get; set; }
        private string _businessHours;

        [XmlElement(ElementName = "businessHours", IsNullable = true, Namespace = "")]
        public string BusinessHours
        {
            get => _businessHours;
            set
            {
                BusinessHoursSpecified = true;
                _businessHours = value;
            }
        }

        [XmlIgnore]
        public bool BusinessHoursSpecified { get; set; }
        private string _holidayScheduleName;

        [XmlElement(ElementName = "holidayScheduleName", IsNullable = true, Namespace = "")]
        public string HolidayScheduleName
        {
            get => _holidayScheduleName;
            set
            {
                HolidayScheduleNameSpecified = true;
                _holidayScheduleName = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AutoAttendantDialingScope _extensionDialingScope;

        [XmlElement(ElementName = "extensionDialingScope", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AutoAttendantDialingScope ExtensionDialingScope
        {
            get => _extensionDialingScope;
            set
            {
                ExtensionDialingScopeSpecified = true;
                _extensionDialingScope = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionDialingScopeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AutoAttendantDialingScope _nameDialingScope;

        [XmlElement(ElementName = "nameDialingScope", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AutoAttendantDialingScope NameDialingScope
        {
            get => _nameDialingScope;
            set
            {
                NameDialingScopeSpecified = true;
                _nameDialingScope = value;
            }
        }

        [XmlIgnore]
        public bool NameDialingScopeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AutoAttendantNameDialingEntry _nameDialingEntries;

        [XmlElement(ElementName = "nameDialingEntries", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AutoAttendantNameDialingEntry NameDialingEntries
        {
            get => _nameDialingEntries;
            set
            {
                NameDialingEntriesSpecified = true;
                _nameDialingEntries = value;
            }
        }

        [XmlIgnore]
        public bool NameDialingEntriesSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu16 _businessHoursMenu;

        [XmlElement(ElementName = "businessHoursMenu", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu16 BusinessHoursMenu
        {
            get => _businessHoursMenu;
            set
            {
                BusinessHoursMenuSpecified = true;
                _businessHoursMenu = value;
            }
        }

        [XmlIgnore]
        public bool BusinessHoursMenuSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu16 _afterHoursMenu;

        [XmlElement(ElementName = "afterHoursMenu", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AutoAttendantModifyMenu16 AfterHoursMenu
        {
            get => _afterHoursMenu;
            set
            {
                AfterHoursMenuSpecified = true;
                _afterHoursMenu = value;
            }
        }

        [XmlIgnore]
        public bool AfterHoursMenuSpecified { get; set; }
    }
}
