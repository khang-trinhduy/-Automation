using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharedLibrary
{
    [DataContract]
    public class TriggerModel
    {
        [DataMember(Name="Id")]
        public int Id { get; set; }
        [DataMember(Name="Title")]
        public string Title { get; set; }
        [DataMember(Name="Description")]
        public string Description { get; set; }
        [DataMember(Name="IsNotActive")]
        public bool IsNotActive { get; set; }
        [DataMember(Name="Position")]
        public int Position { get; set; }
        [DataMember(Name="Table")]
        public string Table { get; set; }
        [DataMember(Name="Created")]
        public DateTime Created { get; set; }
        [DataMember(Name="LastUpdated")]
        public DateTime LastUpdated { get; set; }
        [DataMember(Name="Actions")]
        public List<ActionModel> Actions { get; set; }
        [DataMember(Name="All")]
        public List<ConditionModel> All { get; set; }
        [DataMember(Name="Any")]
        public List<ConditionModel> Any { get; set; }
    }
}