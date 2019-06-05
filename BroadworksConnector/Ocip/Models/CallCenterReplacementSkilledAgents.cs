using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterReplacementSkilledAgents
    {
        private int _skillLevel;

        [XmlElement(ElementName = "skillLevel", IsNullable = false, Namespace = "")]
        public int SkillLevel
        {
            get => _skillLevel;
            set
            {
                SkillLevelSpecified = true;
                _skillLevel = value;
            }
        }

        [XmlIgnore]
        public bool SkillLevelSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ReplacementUserIdList _agents;

        [XmlElement(ElementName = "agents", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ReplacementUserIdList Agents
        {
            get => _agents;
            set
            {
                AgentsSpecified = true;
                _agents = value;
            }
        }

        [XmlIgnore]
        public bool AgentsSpecified { get; set; }
    }
}
