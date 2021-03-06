using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a GETS Session Priority Map.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10157""}]")]
    public class SystemGETSSessionPriorityMapModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _priorityLevel;

        [XmlElement(ElementName = "priorityLevel", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10157")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int PriorityLevel
        {
            get => _priorityLevel;
            set
            {
                PriorityLevelSpecified = true;
                _priorityLevel = value;
            }
        }

        [XmlIgnore]
        protected bool PriorityLevelSpecified { get; set; }

        private int _sessionPriority;

        [XmlElement(ElementName = "sessionPriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10157")]
        [MinInclusive(0)]
        [MaxInclusive(4)]
        public int SessionPriority
        {
            get => _sessionPriority;
            set
            {
                SessionPrioritySpecified = true;
                _sessionPriority = value;
            }
        }

        [XmlIgnore]
        protected bool SessionPrioritySpecified { get; set; }

    }
}
