using D2Codex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemModsController : ControllerBase
    {
        private readonly D2ItemsContext _context;

        public ItemModsController(D2ItemsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<ItemMods> GetAll()
        {
            var itemMods = _context.ItemMods
                .Include(i => i.Item)
                .Include(i => i.Mod)
                .ToList();

            return itemMods;
        }

        [HttpGet]
        public ItemMods Get(int? id)
        {
            if (id == null || _context.ItemMods == null)
            {
                return new ItemMods();
            }

            var itemMods = _context.ItemMods
                .Include(i => i.Item)
                .Include(i => i.Mod)
                .FirstOrDefault(m => m.Id == id);

            if (itemMods == null)
            {
                return new ItemMods();
            }

            return itemMods;
        }
    }
}
