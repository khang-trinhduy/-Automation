using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SharedLibrary
{
    [DataContract]
    public class CampaignModel
    {
        [DataMember(Name="Id")]
        public int Id { get; set; }
        [DataMember(Name="Name")]
        public string Name { get; set; }
        [DataMember(Name="IsRunning")]
        public bool IsRunning { get; set; }
        [DataMember(Name="Subscribers")]
        public List<ContactModel> Subscribers { get; set; }
    }
}