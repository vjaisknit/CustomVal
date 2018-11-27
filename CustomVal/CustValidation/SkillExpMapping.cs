using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomVal.CustValidation
{
    public class SkillExpMapping
    {
        [Key]
        public int Id { get; set; }
        public int  SkillID { get; set; }
        public int  MinExp { get; set; }
        public int MaxExp { get; set; }
    }
}