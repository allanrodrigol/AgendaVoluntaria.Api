using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AgendaVoluntaria.Api.Models.Core;

namespace AgendaVoluntaria.Api.Models
{
    public class Volunteer : CoreModel
    {
        [Required]
        public int Ra { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 1)]
        public string Course { get; set; }

        [Required]
        public bool NeedPsico { get; set; }

        public Guid IdUser { get; set; }

        [Required]
        [ForeignKey("IdUser")]
        public User User { get; set; }
    }
}