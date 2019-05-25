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
        public async Task<Message<CampaignModel>> CreateCampaign(CampaignModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Campaigns/"));
            return await PostAsync<CampaignModel>(requestUrl, model);
        }
        public async Task<Message<CampaignModel>> UpdateCampaign(int id, CampaignModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Campaigns/" + id.ToString()));
            return await PutAsync<CampaignModel>(requestUrl, model);
        }
        public async Task<Message<CampaignModel>> RemoveCampaign(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Campaigns/" + id.ToString()));
            return await DeleteAsync<CampaignModel>(requestUrl);
        }
        public async Task<List<TriggerModel>> GetTriggers()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Triggers/"));
            return await GetAsync<List<TriggerModel>>(requestUrl);
        }
        public async Task<TriggerModel> GetTrigger(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Triggers/" + id.ToString()));
            return await GetAsync<TriggerModel>(requestUrl);
        }
        public async Task<Message<TriggerModel>> CreateTrigger(TriggerModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Triggers/"));
            return await PostAsync<TriggerModel>(requestUrl, model);
        }
        public async Task<Message<TriggerModel>> UpdateTrigger(int id, TriggerModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Triggers/" + id.ToString()));
            return await PutAsync<TriggerModel>(requestUrl, model);
        }
        public async Task<Message<TriggerModel>> RemoveTrigger(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Triggers/" + id.ToString()));
            return await DeleteAsync<TriggerModel>(requestUrl);
        }
        public async Task<List<ActionModel>> GetActions()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Actions"));
            return await GetAsync<List<ActionModel>>(requestUrl);
        }
        public async Task<ActionModel> GetAction(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Actions/" + id.ToString()));
            return await GetAsync<ActionModel>(requestUrl);
        }
        public async Task<Message<ActionModel>> CreateAction(ActionModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Actions/"));
            return await PostAsync<ActionModel>(requestUrl, model);
        }
        public async Task<Message<ActionModel>> UpdateAction(int id, ActionModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Actions/" + id.ToString()));
            return await PutAsync<ActionModel>(requestUrl, model);
        }
        public async Task<Message<ActionModel>> RemoveAction(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Actions/" + id.ToString()));
            return await DeleteAsync<ActionModel>(requestUrl);
        }
        public async Task<List<ConditionModel>> GetConditions()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Conditions"));
            return await GetAsync<List<ConditionModel>>(requestUrl);
        }
        public async Task<ConditionModel> GetCondition(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Conditions/" + id.ToString()));
            return await GetAsync<ConditionModel>(requestUrl);
        }
        public async Task<Message<ConditionModel>> CreateCondition(ConditionModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Conditions/"));
            return await PostAsync<ConditionModel>(requestUrl, model);
        }
        public async Task<Message<ConditionModel>> UpdateCondition(int id, ConditionModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Conditions/" + id.ToString()));
            return await PutAsync<ConditionModel>(requestUrl, model);
        }
        public async Task<Message<ConditionModel>> RemoveCondition(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Conditions/" + id.ToString()));
            return await DeleteAsync<ConditionModel>(requestUrl);
        }
        public async Task<List<MetadataModel>> GetMetadatas()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Metadatas"));
            return await GetAsync<List<MetadataModel>>(requestUrl);
        }
        public async Task<MetadataModel> GetMetadata(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Metadatas/" + id.ToString()));
            return await GetAsync<MetadataModel>(requestUrl);
        }
        public async Task<Message<MetadataModel>> CreateMetadata(MetadataModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Metadatas/"));
            return await PostAsync<MetadataModel>(requestUrl, model);
        }
        public async Task<Message<MetadataModel>> UpdateMetadata(int id, MetadataModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Metadatas/" + id.ToString()));
            return await PutAsync<MetadataModel>(requestUrl, model);
        }
        public async Task<Message<MetadataModel>> RemoveMetadata(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Metadatas/" + id.ToString()));
            return await DeleteAsync<MetadataModel>(requestUrl);
        }
    }
}
