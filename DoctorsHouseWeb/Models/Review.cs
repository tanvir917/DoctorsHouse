//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorsHouseWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int review_id { get; set; }
        public string review_stars { get; set; }
        public string review_date { get; set; }
        public string review_text { get; set; }
        public int patient_id { get; set; }
        public int doctor_id { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}