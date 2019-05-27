using System.Collections.Generic;
using SharedLibrary;
namespace AutomationWebApp.Models
{
    public class TriggerCondition
    {
        public TriggerModel Trigger { get; set; }
        public List<ConditionModel> Conditions { get; set; }
    }
}