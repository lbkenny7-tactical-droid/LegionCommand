using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LegionCommand.Data;
using LegionCommand.Models;

namespace LegionCommand.Pages.Units
{
    public class IndexModel : PageModel
    {
        private readonly LegionCommand.Data.LegionCommandContext _context;

        public IndexModel(LegionCommand.Data.LegionCommandContext context)
        {
            _context = context;
        }

        public IList<Unit> Unit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Unit = await _context.Unit.ToListAsync();
        }
    }
}
