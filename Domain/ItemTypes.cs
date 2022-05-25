using System;
using System.Collections.Generic;

namespace D2Codex.Models
{
    public partial class ItemTypes
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int BaseTypeId { get; set; }
    }
}
