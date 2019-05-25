
using System.Runtime.Serialization;

namespace SharedLibrary
{
    [DataContract]
    public class ContactModel
    {
        [DataMember(Name="Id")]
        public int Id { get; set; }
        [DataMember(Name="Name")]
        public string Name { get; set; }
        [DataMember(Name="Age")]
        public int Age { get; set; }
        [DataMember(Name="PhoneNumber")]
        public string PhoneNumber { get; set; }
        public CampaignModel Campaign { get; set; }
        [DataMember(Name="CampaignId")]
        public int? CampaignId { get; set; }
    }
}