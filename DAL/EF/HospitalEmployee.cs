//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class HospitalEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public int Vinfo { get; set; }
    
        public virtual VolInfo VolInfo { get; set; }
    }
}
