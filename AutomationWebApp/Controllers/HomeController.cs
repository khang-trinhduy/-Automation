using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutomationWebApp.Models;
using AutomationWebApp.Factory;
using AutomationWebApp.Settings;
using SharedLibrary;
using Adapter;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AutomationWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MySettingsModel> appSettings;

        public HomeController(IOptions<MySettingsModel> app)
        {
            appSettings = app;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Contact()
        {
            var data = await ApiClientFactory.Instance.GetContacts();
            return View(data);
        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContact([Bind("Name, Age, PhoneNumber")] ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                var respond = await ApiClientFactory.Instance.CreateContact(contact);
                return RedirectToAction(nameof(Contact));
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> EditContact(int id)
        {
            var data = await ApiClientFactory.Instance.GetContact(id);
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditContact(int? Id, [Bind("Id,Name,Age,PhoneNumber,CampaignId")]ContactModel contact)
        {
            if (Id != contact.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var respond = await ApiClientFactory.Instance.UpdateContact(contact.Id, contact);
                return RedirectToAction(nameof(Contact));
            }
            return RedirectToAction("EditContact", contact.Id);
        }
        [HttpGet]
        public ActionResult DetailContact(ContactModel model)
        {
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var data = await ApiClientFactory.Instance.GetContact(id);
            return View(data);
        }
        [HttpPost, ActionName("DeleteContact")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var data = await ApiClientFactory.Instance.GetContact(id);
            var respond = await ApiClientFactory.Instance.RemoveContact(id);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction("DetailContact", respond.Content);
            }
            return NotFound();
        }
        public async Task<IActionResult> Campaign()
        {
            var data = await ApiClientFactory.Instance.GetCampaigns();
            return View(data);
        }
        [HttpGet]
        public ActionResult CreateCampaign()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCampaign([Bind("Name, IsRunning")] CampaignModel campaign)
        {
            if (ModelState.IsValid)
            {
                var respond = await ApiClientFactory.Instance.CreateCampaign(campaign);
                if (respond != null && respond.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Campaign));
                }
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> EditCampaign(int id)
        {
            var data = await ApiClientFactory.Instance.GetCampaign(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCampaign(int Id, [Bind("Id, Name, IsRunning")]CampaignModel campaign)
        {
            if (Id != campaign.Id)
            {
                return NotFound();
            }
            var respond = await ApiClientFactory.Instance.UpdateCampaign(Id, campaign);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Campaign));
            }
            return NotFound();
        }
        [HttpGet]
        public ActionResult DetailCampaign(CampaignModel model)
        {
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteCampaign(int id)
        {
            var data = await ApiClientFactory.Instance.GetCampaign(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost, ActionName("DeleteCampaign")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCampaignConfirmed(int id)
        {
            var data = await ApiClientFactory.Instance.GetCampaign(id);
            var respond = await ApiClientFactory.Instance.RemoveCampaign(id);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction("DetailCampaign", respond.Content);
            }
            return NotFound();
        }
        public async Task<IActionResult> Trigger()
        {
            var data = await ApiClientFactory.Instance.GetTriggers();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> CreateTrigger()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTrigger([Bind("Title, Description, IsNotActive, Position, Table")] TriggerModel trigger)
        {
            if (ModelState.IsValid)
            {
                var respond = await ApiClientFactory.Instance.CreateTrigger(trigger);
                if (respond != null && respond.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Trigger));
                }
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> EditTrigger(int id)
        {
            var data = await ApiClientFactory.Instance.GetTrigger(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTrigger(int Id, [Bind("Id, Title, Description, IsNotActive, Position, Table")] TriggerModel trigger)
        {
            if (Id != trigger.Id)
            {
                return NotFound();
            }
            var respond = await ApiClientFactory.Instance.UpdateTrigger(Id, trigger);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Trigger));
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> DeleteTrigger(int id)
        {
            var data = await ApiClientFactory.Instance.GetTrigger(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken, ActionName("DeleteTrigger")]
        public async Task<IActionResult> DeleteTriggerConfirmed(int id)
        {
            var respond = await ApiClientFactory.Instance.RemoveTrigger(id);
            if(respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction("DetailTrigger", respond.Content);
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> DetailTrigger(TriggerModel model)
        {
            if(model != null)
            {
                return View(model);
            }
            return NotFound();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Action()
        {
            var data = await ApiClientFactory.Instance.GetActions();
            return View(data);
        }
        [HttpGet]
        public ActionResult CreateAction()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAction([Bind("Type, Value")] ActionModel model)
        {
            if (ModelState.IsValid)
            {
                var respond = await ApiClientFactory.Instance.CreateAction(model);
                if (respond != null && respond.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Action));
                }
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> EditAction(int id)
        {
            var data = await ApiClientFactory.Instance.GetAction(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAction(int Id, [Bind("Id, Type, Value")]ActionModel model)
        {
            if (Id != model.Id)
            {
                return NotFound();
            }
            var respond = await ApiClientFactory.Instance.UpdateAction(Id, model);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Action));
            }
            return NotFound();
        }
        [HttpGet]
        public ActionResult DetailAction(ActionModel model)
        {
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteAction(int id)
        {
            var data = await ApiClientFactory.Instance.GetAction(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost, ActionName("DeleteAction")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteActionConfirmed(int id)
        {
            var data = await ApiClientFactory.Instance.GetAction(id);
            var respond = await ApiClientFactory.Instance.RemoveAction(id);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction("DetailAction", respond.Content);
            }
            return NotFound();
        }
        public async Task<IActionResult> Condition()
        {
            var data = await ApiClientFactory.Instance.GetConditions();
            return View(data);
        }
        [HttpGet]
        public ActionResult CreateCondition()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCondition([Bind("Type, Operator, Threshold")] ConditionModel model)
        {
            if (ModelState.IsValid)
            {
                var respond = await ApiClientFactory.Instance.CreateCondition(model);
                if (respond != null && respond.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Condition));
                }
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> EditCondition(int id)
        {
            var data = await ApiClientFactory.Instance.GetCondition(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCondition(int Id, [Bind("Id, Type, Operator, Threshold")]ConditionModel model)
        {
            if (Id != model.Id)
            {
                return NotFound();
            }
            var respond = await ApiClientFactory.Instance.UpdateCondition(Id, model);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Condition));
            }
            return NotFound();
        }
        [HttpGet]
        public ActionResult DetailCondition(ConditionModel model)
        {
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteCondition(int id)
        {
            var data = await ApiClientFactory.Instance.GetCondition(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost, ActionName("DeleteCondition")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConditionConfirmed(int id)
        {
            var data = await ApiClientFactory.Instance.GetCondition(id);
            var respond = await ApiClientFactory.Instance.RemoveCondition(id);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction("DetailCondition", respond.Content);
            }
            return NotFound();
        }
        public async Task<IActionResult> Metadata()
        {
            var data = await ApiClientFactory.Instance.GetMetadatas();
            return View(data);
        }
        [HttpGet]
        public ActionResult CreateMetadata()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMetadata([Bind("Type, Table, Field")] MetadataModel model)
        {
            if (ModelState.IsValid)
            {
                var respond = await ApiClientFactory.Instance.CreateMetadata(model);
                if (respond != null && respond.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Metadata));
                }
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> EditMetadata(int id)
        {
            var data = await ApiClientFactory.Instance.GetMetadata(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMetadata(int Id, [Bind("Id, Type, Table, Field")]MetadataModel model)
        {
            if (Id != model.Id)
            {
                return NotFound();
            }
            var respond = await ApiClientFactory.Instance.UpdateMetadata(Id, model);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Metadata));
            }
            return NotFound();
        }
        [HttpGet]
        public ActionResult DetailMetadata(MetadataModel model)
        {
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteMetadata(int id)
        {
            var data = await ApiClientFactory.Instance.GetMetadata(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost, ActionName("DeleteMetadata")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteMetadataConfirmed(int id)
        {
            var data = await ApiClientFactory.Instance.GetMetadata(id);
            var respond = await ApiClientFactory.Instance.RemoveMetadata(id);
            if (respond != null && respond.IsSuccessStatusCode)
            {
                return RedirectToAction("DetailMetadata", respond.Content);
            }
            return NotFound();
        }
    }
}
