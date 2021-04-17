using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KoronaMetre.Models
{
    public class Ulke
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Ad { get; set; }
        public long Nufus { get; set; }
        public KoronaBilgi KoronaBilgi { get; set; }

    }
}
