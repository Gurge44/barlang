using System.ComponentModel.DataAnnotations;

namespace Barlang.Models
{
    public class Barlang
    {
        [Key]
        public int id { get; set; }
        public string nev { get; set; }
        public int hossz { get; set; }
        public int kiterjedes { get; set; }
        public int melyseg { get; set; }
        public int magassag { get; set; }
        public string telepules { get; set; }
    }
}
