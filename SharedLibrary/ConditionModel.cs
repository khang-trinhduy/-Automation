using System.Runtime.Serialization;

namespace SharedLibrary
{
    [DataContract]
    public class ConditionModel
    {
        [DataMember(Name="Id")]
        public int Id { get; set; }
        [DataMember(Name="Operator")]
        public string Operator { get; set; }
        [DataMember(Name="Threshold")]
        public string Threshold { get; set; }
        [DataMember(Name="Type")]
        public string Type { get; set; }
        [DataMember(Name="MetaData")]
        public MetadataModel MetaData { get; set; }
    }
}