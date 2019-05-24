using System;

namespace SharedLibrary
{
    public class ActionModel
    {
        public int Id { get; set; }
        public MetadataModel MetaData { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

    }
}