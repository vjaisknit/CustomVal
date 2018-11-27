using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomVal.CustValidation
{
    public class SkillMst
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }

    }
}