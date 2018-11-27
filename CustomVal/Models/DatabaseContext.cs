using CustomVal.CustValidation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomVal.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<SkillMst> SkillMsts { get; set; }
        public DbSet<EmployeeMst> EmployeeMsts { get; set; }

        public DbSet<SkillExpMapping> SkillExpMappings { get; set; }
    }
}