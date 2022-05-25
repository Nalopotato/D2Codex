using System;
using System.Collections.Generic;

namespace D2Codex
{
    public partial class Mods
    {
        public Mods()
        {
            TItemMods = new HashSet<ItemMods>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? AmountType { get; set; }

        public virtual ICollection<ItemMods> TItemMods { get; set; }
    }
}
