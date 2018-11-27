using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomVal.CustValidation
{
    public class EmployeeMst
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [StringLength(255)]

        public string Name { get; set; }

        [Display(Name ="Skill")]
        public int SkillId { get; set; }

        [Range(1, 10)]

        [ValidExp]
        public int Experience { get; set; }
    }
}