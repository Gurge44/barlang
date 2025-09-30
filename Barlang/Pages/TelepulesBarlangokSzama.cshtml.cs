using Barlang.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Barlang.Pages
{
    public class TelepulesBarlangokSzamaModel : PageModel
    {
        private readonly Barlang.Data.BarlangDbContext _context;

        public TelepulesBarlangokSzamaModel(Barlang.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IList<TelepulesBarlangokDTO> Osszesito { get; set; }

        public void OnGet()
        {
            Osszesito = [.. _context.Barlangok.GroupBy(x => x.telepules).Select(x => new TelepulesBarlangokDTO
            {
                telepules = x.Key,
                barlangokSzama = x.Count()
            })];
        }
    }
}
