using System.Collections.Generic;

namespace SharedLibrary
{
    public class CampaignModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRunning { get; set; }
        public List<ContactModel> Subscribers { get; set; }
    }
}