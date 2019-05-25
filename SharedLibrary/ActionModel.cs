using System;
using System.Runtime.Serialization;

namespace SharedLibrary
{
    [DataContract]
    public class ActionModel
    {
        [DataMember(Name="Id")]
        public int Id { get; set; }
        [DataMember(Name="MetaData")]
        public MetadataModel MetaData { get; set; }
        [DataMember(Name="Type")]
        public string Type { get; set; }
        [DataMember(Name="Value")]
        public string Value { get; set; }

    }
}