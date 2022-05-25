using System;
using System.Collections.Generic;

namespace D2Codex.Models
{
    public partial class BaseTypes
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? IsMelee { get; set; }
    }
}
