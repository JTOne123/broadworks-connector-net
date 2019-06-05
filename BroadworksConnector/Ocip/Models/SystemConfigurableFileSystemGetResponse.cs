using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _mediaDirectory;

    [XmlElement(ElementName = "mediaDirectory", IsNullable = false, Namespace = "")]
    public string MediaDirectory {
        get => _mediaDirectory;
        set {
            MediaDirectorySpecified = true;
            _mediaDirectory = value;
        }
    }

    [XmlIgnore]
    public bool MediaDirectorySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolFile _protocolFile;

    [XmlElement(ElementName = "protocolFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolFile ProtocolFile {
        get => _protocolFile;
        set {
            ProtocolFileSpecified = true;
            _protocolFile = value;
        }
    }

    [XmlIgnore]
    public bool ProtocolFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolWebDAV _protocolWebDAV;

    [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolWebDAV ProtocolWebDAV {
        get => _protocolWebDAV;
        set {
            ProtocolWebDAVSpecified = true;
            _protocolWebDAV = value;
        }
    }

    [XmlIgnore]
    public bool ProtocolWebDAVSpecified { get; set; }
}
}
