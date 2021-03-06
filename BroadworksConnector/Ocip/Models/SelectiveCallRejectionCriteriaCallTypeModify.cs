using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call type criteria used within a modify request.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""41cdd93743bd17548f1ded5691680d5a:224""}]")]
    public class SelectiveCallRejectionCriteriaCallTypeModify
    {

        private BroadWorksConnector.Ocip.Models.SelectiveCallRejectionCriteriaCallTypeSelection _fromDnCriteriaSelection;

        [XmlElement(ElementName = "fromDnCriteriaSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"41cdd93743bd17548f1ded5691680d5a:224")]
        public BroadWorksConnector.Ocip.Models.SelectiveCallRejectionCriteriaCallTypeSelection FromDnCriteriaSelection
        {
            get => _fromDnCriteriaSelection;
            set
            {
                FromDnCriteriaSelectionSpecified = true;
                _fromDnCriteriaSelection = value;
            }
        }

        [XmlIgnore]
        protected bool FromDnCriteriaSelectionSpecified { get; set; }

        private bool _includeAnonymousCallers;

        [XmlElement(ElementName = "includeAnonymousCallers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"41cdd93743bd17548f1ded5691680d5a:224")]
        public bool IncludeAnonymousCallers
        {
            get => _includeAnonymousCallers;
            set
            {
                IncludeAnonymousCallersSpecified = true;
                _includeAnonymousCallers = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeAnonymousCallersSpecified { get; set; }

        private bool _includeUnavailableCallers;

        [XmlElement(ElementName = "includeUnavailableCallers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"41cdd93743bd17548f1ded5691680d5a:224")]
        public bool IncludeUnavailableCallers
        {
            get => _includeUnavailableCallers;
            set
            {
                IncludeUnavailableCallersSpecified = true;
                _includeUnavailableCallers = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeUnavailableCallersSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CriteriaReplacementDNList _phoneNumberList;

        [XmlElement(ElementName = "phoneNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"41cdd93743bd17548f1ded5691680d5a:224")]
        public BroadWorksConnector.Ocip.Models.CriteriaReplacementDNList PhoneNumberList
        {
            get => _phoneNumberList;
            set
            {
                PhoneNumberListSpecified = true;
                _phoneNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberListSpecified { get; set; }

    }
}
