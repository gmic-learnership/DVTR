//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DVTR.DVTR.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicantContract
    {
        public int ApplicantContractId { get; set; }
        public decimal CurrentGrossSalary { get; set; }
        public decimal CurrentPerfomanceBonus { get; set; }
        public decimal MedicalAidEmpContribution { get; set; }
        public decimal MedicalAidIndContribution { get; set; }
        public decimal ProvidentPensionEmpContribution { get; set; }
        public decimal ProvidentPensionIndContribution { get; set; }
        public decimal OtherEmpContribution { get; set; }
        public decimal OtherIndContribution { get; set; }
        public int CurrentEmplTypeId { get; set; }
        public int ExpectedEmpTypeId { get; set; }
        public string NoticePeriod { get; set; }
        public decimal PermanentSalaryExpectation { get; set; }
        public decimal ContractSalaryExpectation { get; set; }
        public int PersonId { get; set; }
        public string RecentlySentCvToOtherComp { get; set; }
        public string InterviewsScheduled { get; set; }
        public string ReasonLeavingCurrentComp { get; set; }
        public string PreferredEnviroment { get; set; }
    
        public virtual EmploymentType EmploymentType { get; set; }
        public virtual EmploymentType EmploymentType1 { get; set; }
        public virtual Person Person { get; set; }
    }
}