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
    
    public partial class BackgroundCheck
    {
        public int BackgroundCheckId { get; set; }
        public bool Convictions { get; set; }
        public string CriminalRecord { get; set; }
        public string CcmaCase { get; set; }
        public string FraudCase { get; set; }
        public string CreditRecord { get; set; }
        public string Other { get; set; }
        public int PersonId { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
