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
    public class DeleteModel : PageModel
    {
        private readonly LegionCommand.Data.LegionCommandContext _context;

        public DeleteModel(LegionCommand.Data.LegionCommandContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Unit Unit { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unit = await _context.Unit.FirstOrDefaultAsync(m => m.Id == id);

            if (unit == null)
            {
                return NotFound();
            }
            else
            {
                Unit = unit;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unit = await _context.Unit.FindAsync(id);
            if (unit != null)
            {
                Unit = unit;
                _context.Unit.Remove(Unit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
