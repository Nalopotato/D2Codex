namespace Domain.Models
{
    public partial class Mods
    {
        public Mods()
        {
            ItemMods = new HashSet<ItemMods>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? AmountType { get; set; }

        public virtual ICollection<ItemMods> ItemMods { get; set; }
    }
}
