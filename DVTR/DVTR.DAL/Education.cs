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
    
    public partial class Education
    {
        public int EducationId { get; set; }
        public string EducationType { get; set; }
        public string Institution { get; set; }
        public System.DateTime YearCompleted { get; set; }
        public int PersonId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
