using SharedLibrary;
using System.Collections.Generic;
namespace AutomationWebApp.Models
{
    public class ActionMeta
    {
        public ActionModel Action { get; set; }
        public List<MetadataModel> Metadatas { get; set; }
    }
}