using CustomVal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomVal.CustValidation
{
    public class ValidExp: ValidationAttribute
    {
        DatabaseContext _db = new DatabaseContext();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
         var emp=  (EmployeeMst) validationContext.ObjectInstance;
            string ValMassage = "";
            var ExpConfig = _db.SkillExpMappings.FirstOrDefault(a => a.SkillID == emp.SkillId);
            if(emp.Experience>ExpConfig.MaxExp || emp.Experience<ExpConfig.MinExp)
            {
                ValMassage = "Your Experience is " + emp.Experience.ToString() +
                        "; Experience Should be " + ExpConfig.MinExp + "-" + ExpConfig.MaxExp;
                return new ValidationResult(ValMassage);
            }
            return ValidationResult.Success;
        }
    }
}