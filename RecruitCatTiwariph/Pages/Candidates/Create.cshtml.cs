using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatTiwariph.Data;
using RecruitCatTiwariph.Models;

namespace RecruitCatTiwariph.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatTiwariph.Data.RecruitCatTiwariphContext _context;

        public CreateModel(RecruitCatTiwariph.Data.RecruitCatTiwariphContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "Id");
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "Id", "Id");
        ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
