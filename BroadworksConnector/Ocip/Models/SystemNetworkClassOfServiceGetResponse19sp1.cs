using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkClassOfServiceGetResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile0;

    [XmlElement(ElementName = "communicationBarringProfile0", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile0 {
        get => _communicationBarringProfile0;
        set {
            CommunicationBarringProfile0Specified = true;
            _communicationBarringProfile0 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile0Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile1;

    [XmlElement(ElementName = "communicationBarringProfile1", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile1 {
        get => _communicationBarringProfile1;
        set {
            CommunicationBarringProfile1Specified = true;
            _communicationBarringProfile1 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile1Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile2;

    [XmlElement(ElementName = "communicationBarringProfile2", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile2 {
        get => _communicationBarringProfile2;
        set {
            CommunicationBarringProfile2Specified = true;
            _communicationBarringProfile2 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile2Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile3;

    [XmlElement(ElementName = "communicationBarringProfile3", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile3 {
        get => _communicationBarringProfile3;
        set {
            CommunicationBarringProfile3Specified = true;
            _communicationBarringProfile3 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile3Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile4;

    [XmlElement(ElementName = "communicationBarringProfile4", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile4 {
        get => _communicationBarringProfile4;
        set {
            CommunicationBarringProfile4Specified = true;
            _communicationBarringProfile4 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile4Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile5;

    [XmlElement(ElementName = "communicationBarringProfile5", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile5 {
        get => _communicationBarringProfile5;
        set {
            CommunicationBarringProfile5Specified = true;
            _communicationBarringProfile5 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile5Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile6;

    [XmlElement(ElementName = "communicationBarringProfile6", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile6 {
        get => _communicationBarringProfile6;
        set {
            CommunicationBarringProfile6Specified = true;
            _communicationBarringProfile6 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile6Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile7;

    [XmlElement(ElementName = "communicationBarringProfile7", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile7 {
        get => _communicationBarringProfile7;
        set {
            CommunicationBarringProfile7Specified = true;
            _communicationBarringProfile7 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile7Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile8;

    [XmlElement(ElementName = "communicationBarringProfile8", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile8 {
        get => _communicationBarringProfile8;
        set {
            CommunicationBarringProfile8Specified = true;
            _communicationBarringProfile8 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile8Specified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile9;

    [XmlElement(ElementName = "communicationBarringProfile9", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile9 {
        get => _communicationBarringProfile9;
        set {
            CommunicationBarringProfile9Specified = true;
            _communicationBarringProfile9 = value;
        }
    }

    [XmlIgnore]
    public bool CommunicationBarringProfile9Specified { get; set; }
    private string _networkTranslationIndex;

    [XmlElement(ElementName = "networkTranslationIndex", IsNullable = false, Namespace = "")]
    public string NetworkTranslationIndex {
        get => _networkTranslationIndex;
        set {
            NetworkTranslationIndexSpecified = true;
            _networkTranslationIndex = value;
        }
    }

    [XmlIgnore]
    public bool NetworkTranslationIndexSpecified { get; set; }
    private string _callProcessingPolicyProfileName;

    [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
    public string CallProcessingPolicyProfileName {
        get => _callProcessingPolicyProfileName;
        set {
            CallProcessingPolicyProfileNameSpecified = true;
            _callProcessingPolicyProfileName = value;
        }
    }

    [XmlIgnore]
    public bool CallProcessingPolicyProfileNameSpecified { get; set; }
}
}
