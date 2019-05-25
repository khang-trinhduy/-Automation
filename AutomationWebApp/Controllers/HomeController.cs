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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
