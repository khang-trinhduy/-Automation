namespace SharedLibrary
{
    public class ConditionModel
    {
        public int Id { get; set; }
        public string Operator { get; set; }
        public string Threshold { get; set; }
        public string Type { get; set; }
        public MetadataModel MetaData { get; set; }
    }
}