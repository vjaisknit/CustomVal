using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomVal.CustValidation
{
    public class EmployeeDTO
    {
        public EmployeeMst employeeMst { get; set; }
        public List<SkillMst> SkillList { get; set; }
    }
}