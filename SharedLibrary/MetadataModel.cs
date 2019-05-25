using System.Runtime.Serialization;

namespace SharedLibrary
{
    [DataContract]
    public class MetadataModel
    {
        [DataMember(Name="Id")]
        public int Id { get; set; }
        [DataMember(Name="Field")]
        public string Field { get; set; }
        [DataMember(Name="Type")]
        public string Type { get; set; }
        [DataMember(Name="Table")]
        public string Table { get; set; }
    }
}