//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.CAS_Facility = new HashSet<CAS_Facility>();
            this.Chiller_Facility = new HashSet<Chiller_Facility>();
        }
    
        public int company_id { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creation_time { get; set; }
        public Nullable<System.DateTime> edit_time { get; set; }
        public string status { get; set; }
        public string company_name { get; set; }
        public string industry_type { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string post_code { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }
        public string register_system { get; set; }
        public Nullable<int> utility_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAS_Facility> CAS_Facility { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chiller_Facility> Chiller_Facility { get; set; }
        public virtual Utility Utility { get; set; }
    }
}