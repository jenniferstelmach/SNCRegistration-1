//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SNCRegistration.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FamilyMember
    {
        public int FamilyMemberID { get; set; }
        public string FamilyMemberFirstName { get; set; }
        public string FamilyMemberLastName { get; set; }
        public int GuardianID { get; set; }
        public Nullable<bool> HealthForm { get; set; }
        public Nullable<bool> PhotoAck { get; set; }
        public string AttendingCode { get; set; }
        public string Comments { get; set; }
    }
}
