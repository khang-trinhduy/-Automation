using System.Collections.Generic;
using SharedLibrary;
namespace AutomationWebApp.Models
{
    public class TriggerAction
    {
        public TriggerModel Trigger { get; set; }
        public List<ActionModel> Actions { get; set; }
    }
}