using System;
using System.Collections.Generic;
namespace SharedLibrary
{
    public class TriggerModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsNotActive { get; set; }
        public int Position { get; set; }
        public string Table { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<ActionModel> Actions { get; set; }
        public List<ConditionModel> All { get; set; }
        public List<ConditionModel> Any { get; set; }
    }
}