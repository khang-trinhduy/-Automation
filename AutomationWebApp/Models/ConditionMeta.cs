using System.Collections.Generic;
using SharedLibrary;
namespace AutomationWebApp.Models
{
    public class ConditionMeta
    {
        public ConditionModel Condition { get; set; }
        public List<MetadataModel> Metadatas { get; set; }
    }
}