using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LegionCommand.Data;
using LegionCommand.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LegionCommand.Pages.Units
{
    public class IndexModel : PageModel
    {
        private readonly LegionCommand.Data.LegionCommandContext _context;

        public IndexModel(LegionCommand.Data.LegionCommandContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? UnitRanks { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? UnitRank { get; set; }

        public IList<Unit> Unit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            var units = from u in _context.Unit
                         select u;

            IQueryable<string> rankQuery = from u in _context.Unit
                                            orderby u.Rank
                                            select u.Rank;

            if (!string.IsNullOrEmpty(SearchString))
            {
                units = units.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(UnitRank))
            {
                units = units.Where(x => x.Rank == UnitRank);
            }

            UnitRanks = new SelectList(await rankQuery.Distinct().ToListAsync());
            Unit = await units.ToListAsync();
        }
    }
}
