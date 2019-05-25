using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary;

namespace Adapter
{
    public partial class ApiClient
    {
        public async Task<List<ContactModel>> GetContacts()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, 
                "Contacts/"));
            return await GetAsync<List<ContactModel>>(requestUrl);
        }
        public async Task<ContactModel> GetContact(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, 
                "Contacts/" + id.ToString()));
            return await GetAsync<ContactModel>(requestUrl);
        }
        public async Task<Message<ContactModel>> CreateContact(ContactModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Contacts/"));
            return await PostAsync<ContactModel>(requestUrl, model);
        }
        public async Task<Message<ContactModel>> UpdateContact(int id, ContactModel model)
        {
           var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Contacts/" + id.ToString()));
            return await PutAsync<ContactModel>(requestUrl, model);
        }
        public async Task<Message<ContactModel>> RemoveContact(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Contacts/" + id.ToString()));
            return await DeleteAsync<ContactModel>(requestUrl);
        }
        public async Task<List<CampaignModel>> GetCampaigns()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Campaigns/"));
            return await GetAsync<List<CampaignModel>>(requestUrl);
        }
        public async Task<CampaignModel> GetCampaign(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, 
                "Campaigns/" + id.ToString()));
            return await GetAsync<CampaignModel>(requestUrl);
        }
        public async Task<List<TriggerModel>> GetTriggers()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Triggers/"));
            return await GetAsync<List<TriggerModel>>(requestUrl);
        }
    }
}
