using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the Service Provider/Enterprise level Zone Calling Restrictions Policies.
    /// The response is SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da5cd0d79ddb505982e08d164e405660:80""}]")]
    public class ServiceProviderZoneCallingRestrictionsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"da5cd0d79ddb505982e08d164e405660:80")]
        [MinLength(1)]
        [MaxLength(30)]
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
        protected bool ServiceProviderIdSpecified { get; set; }

        private bool _enableZoneCallingRestrictions;

        [XmlElement(ElementName = "enableZoneCallingRestrictions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da5cd0d79ddb505982e08d164e405660:80")]
        public bool EnableZoneCallingRestrictions
        {
            get => _enableZoneCallingRestrictions;
            set
            {
                EnableZoneCallingRestrictionsSpecified = true;
                _enableZoneCallingRestrictions = value;
            }
        }

        [XmlIgnore]
        protected bool EnableZoneCallingRestrictionsSpecified { get; set; }

        private bool _enableOriginationRoamingRestrictions;

        [XmlElement(ElementName = "enableOriginationRoamingRestrictions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da5cd0d79ddb505982e08d164e405660:80")]
        public bool EnableOriginationRoamingRestrictions
        {
            get => _enableOriginationRoamingRestrictions;
            set
            {
                EnableOriginationRoamingRestrictionsSpecified = true;
                _enableOriginationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        protected bool EnableOriginationRoamingRestrictionsSpecified { get; set; }

        private bool _enableEmergencyOriginationRoamingRestrictions;

        [XmlElement(ElementName = "enableEmergencyOriginationRoamingRestrictions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da5cd0d79ddb505982e08d164e405660:80")]
        public bool EnableEmergencyOriginationRoamingRestrictions
        {
            get => _enableEmergencyOriginationRoamingRestrictions;
            set
            {
                EnableEmergencyOriginationRoamingRestrictionsSpecified = true;
                _enableEmergencyOriginationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        protected bool EnableEmergencyOriginationRoamingRestrictionsSpecified { get; set; }

        private bool _enableTerminationRoamingRestrictions;

        [XmlElement(ElementName = "enableTerminationRoamingRestrictions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da5cd0d79ddb505982e08d164e405660:80")]
        public bool EnableTerminationRoamingRestrictions
        {
            get => _enableTerminationRoamingRestrictions;
            set
            {
                EnableTerminationRoamingRestrictionsSpecified = true;
                _enableTerminationRoamingRestrictions = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTerminationRoamingRestrictionsSpecified { get; set; }

    }
}
