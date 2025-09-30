using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barlang.Data;
using Barlang.Models;

namespace Barlang.Pages
{
    public class TelepulesSzuresModel : PageModel
    {
        private readonly Barlang.Data.BarlangDbContext _context;

        public TelepulesSzuresModel(Barlang.Data.BarlangDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string KivalasztottTelepules { get; set; }


        public IList<Models.Barlang> Barlang { get;set; } = default!;
        public IList<string> Telepulesek { get; set; }

        public async Task OnGetAsync()
        {
            Telepulesek = await _context.Barlangok.Select(x => x.telepules).Distinct().OrderBy(x => x).ToListAsync();
            Barlang = await _context.Barlangok.Where(x => x.telepules == KivalasztottTelepules).ToListAsync();
        }
    }
}
