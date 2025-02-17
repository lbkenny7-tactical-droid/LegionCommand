using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LegionCommand.Data;
using LegionCommand.Models;

namespace LegionCommand.Pages.Units
{
    public class CreateModel : PageModel
    {
        private readonly LegionCommand.Data.LegionCommandContext _context;

        public CreateModel(LegionCommand.Data.LegionCommandContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Unit Unit { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Unit.Add(Unit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
