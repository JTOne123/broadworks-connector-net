using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of shared call appearance endpoints that replaces existing endpoints.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3169""}]")]
    public class ReplacementCombinedSharedCallAppearanceAccessDeviceMultipleIdentityEndpointList
    {

        private List<BroadWorksConnector.Ocip.Models.CombinedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> _sharedCallAppearanceAccessDeviceEndpoint = new List<BroadWorksConnector.Ocip.Models.CombinedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint>();

        [XmlElement(ElementName = "sharedCallAppearanceAccessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3169")]
        public List<BroadWorksConnector.Ocip.Models.CombinedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint> SharedCallAppearanceAccessDeviceEndpoint
        {
            get => _sharedCallAppearanceAccessDeviceEndpoint;
            set
            {
                SharedCallAppearanceAccessDeviceEndpointSpecified = true;
                _sharedCallAppearanceAccessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool SharedCallAppearanceAccessDeviceEndpointSpecified { get; set; }

    }
}
