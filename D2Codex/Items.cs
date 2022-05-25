using System;
using System.Collections.Generic;

namespace D2Codex
{
    public partial class Items
    {
        public Items()
        {
            TItemMods = new HashSet<ItemMods>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? BaseType1 { get; set; }
        public string? BaseType2 { get; set; }
        public string? BaseType3 { get; set; }
        public int? Quality { get; set; }
        public int? Rarity { get; set; }
        public int? Lvl { get; set; }
        public int? Str { get; set; }
        public int? Dex { get; set; }
        public int? Sockets { get; set; }
        public int? Version { get; set; }
        public bool? Ladder { get; set; }
        public string? Class { get; set; }
        public string? Rune1 { get; set; }
        public string? Rune2 { get; set; }
        public string? Rune3 { get; set; }
        public string? Rune4 { get; set; }
        public string? Rune5 { get; set; }
        public string? Rune6 { get; set; }
        public int? SubType { get; set; }
        public bool? Resurrected { get; set; }

        public virtual ICollection<ItemMods> TItemMods { get; set; }
    }
}
