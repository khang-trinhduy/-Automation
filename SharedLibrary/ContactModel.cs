
namespace SharedLibrary
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public CampaignModel Campaign { get; set; }
        public int? CampaignId { get; set; }
    }
}