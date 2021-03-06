using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group's Polycom Phone Services attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4f074d986b998636e2bcb0d67372b0f4:80""}]")]
    public class GroupPolycomPhoneServicesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:80")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:80")]
        [MinLength(1)]
        [MaxLength(30)]
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
        protected bool GroupIdSpecified { get; set; }

        private bool _includeGroupCommonPhoneListInDirectory;

        [XmlElement(ElementName = "includeGroupCommonPhoneListInDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:80")]
        public bool IncludeGroupCommonPhoneListInDirectory
        {
            get => _includeGroupCommonPhoneListInDirectory;
            set
            {
                IncludeGroupCommonPhoneListInDirectorySpecified = true;
                _includeGroupCommonPhoneListInDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeGroupCommonPhoneListInDirectorySpecified { get; set; }

        private bool _includeGroupCustomContactDirectoryInDirectory;

        [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:80")]
        public bool IncludeGroupCustomContactDirectoryInDirectory
        {
            get => _includeGroupCustomContactDirectoryInDirectory;
            set
            {
                IncludeGroupCustomContactDirectoryInDirectorySpecified = true;
                _includeGroupCustomContactDirectoryInDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeGroupCustomContactDirectoryInDirectorySpecified { get; set; }

        private string _groupCustomContactDirectory;

        [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4f074d986b998636e2bcb0d67372b0f4:80")]
        [MinLength(1)]
        [MaxLength(40)]
        public string GroupCustomContactDirectory
        {
            get => _groupCustomContactDirectory;
            set
            {
                GroupCustomContactDirectorySpecified = true;
                _groupCustomContactDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool GroupCustomContactDirectorySpecified { get; set; }

    }
}
