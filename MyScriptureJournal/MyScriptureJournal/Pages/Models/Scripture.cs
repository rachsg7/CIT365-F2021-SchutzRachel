using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Pages.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }
        [StringLength(4, MinimumLength = 1)]
        [Required]
        public string Chapter { get; set; }

        [StringLength(4, MinimumLength = 1)]
        [Required]
        public string Verse { get; set; }
        [StringLength(120, MinimumLength = 1)]
        [Required]
        public string Notes { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        //public DateTime DateCreated { get { return DateCreated; } set { DateCreated = DateTime.Today; } }
    }
}
