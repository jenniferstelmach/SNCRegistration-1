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
    
    public partial class Volunteer
    {
        public int VolunteerID { get; set; }
        public string VolunteerFirstName { get; set; }
        public string VolunteerLastName { get; set; }
        public int VolunteerAge { get; set; }
        public int LeaderID { get; set; }
        public bool VolunteerShirtOrder { get; set; }
        public string VolunteerShirtSize { get; set; }
        public string VolunteerAttendingCode { get; set; }
        public bool SaturdayDinner { get; set; }
        public string UnitChapterNumber { get; set; }
        public string Comments { get; set; }
    
        public virtual Volunteer Volunteers1 { get; set; }
        public virtual Volunteer Volunteer1 { get; set; }
    }
}
