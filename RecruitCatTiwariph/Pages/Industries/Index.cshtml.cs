using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatTiwariph.Data;
using RecruitCatTiwariph.Models;

namespace RecruitCatTiwariph.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatTiwariph.Data.RecruitCatTiwariphContext _context;

        public IndexModel(RecruitCatTiwariph.Data.RecruitCatTiwariphContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
