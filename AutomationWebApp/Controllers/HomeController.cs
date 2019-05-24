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
        
        public async Task<IActionResult> SaveContact(ContactModel model)
        {
            var respond = await ApiClientFactory.Instance.UpdateContact(model.Id, model);
            return View(nameof(Index));
        }
        public async Task<IActionResult> EditContact(int id)
        {
            var data = await ApiClientFactory.Instance.GetContact(id);
            return View(data);
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
