using System;
using System.Collections.Generic;

namespace D2Codex
{
    public partial class ItemMods
    {
        public int Id { get; set; }
        public int ModId { get; set; }
        public int ItemId { get; set; }
        public double? Value1 { get; set; }
        public double? Value2 { get; set; }
        public string? Skill { get; set; }
        public int? SetId { get; set; }
        public int? SetBonusId { get; set; }

        public virtual Items Item { get; set; } = null!;
        public virtual Mods Mod { get; set; } = null!;
    }
}
