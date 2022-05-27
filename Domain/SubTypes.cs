namespace Domain.Models
{
    public partial class SubTypes
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? BaseType { get; set; }
        public int? Quality { get; set; }
        public int? MaxSockets { get; set; }
        public int? Str { get; set; }
        public int? Dex { get; set; }
        public string? Class { get; set; }
        public int? Lvl { get; set; }
    }
}
