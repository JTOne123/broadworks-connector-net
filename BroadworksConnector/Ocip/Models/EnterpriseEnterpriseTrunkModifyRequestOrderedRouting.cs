using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseEnterpriseTrunkModifyRequestOrderedRouting
    {
        private BroadworksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkTrunkGroupKeyList _trunkGroupList;

        [XmlElement(ElementName = "trunkGroupList", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkTrunkGroupKeyList TrunkGroupList
        {
            get => _trunkGroupList;
            set
            {
                TrunkGroupListSpecified = true;
                _trunkGroupList = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm _orderingAlgorithm;

        [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm OrderingAlgorithm
        {
            get => _orderingAlgorithm;
            set
            {
                OrderingAlgorithmSpecified = true;
                _orderingAlgorithm = value;
            }
        }

        [XmlIgnore]
        public bool OrderingAlgorithmSpecified { get; set; }
    }
}
