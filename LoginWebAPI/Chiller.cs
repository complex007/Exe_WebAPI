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
    
    public partial class Chiller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chiller()
        {
            this.Chiller_Profile = new HashSet<Chiller_Profile>();
        }
    
        public int chiller_id { get; set; }
        public int facility_id { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creation_time { get; set; }
        public Nullable<System.DateTime> edit_time { get; set; }
        public string status { get; set; }
        public Nullable<double> total_system_power_kw { get; set; }
        public Nullable<double> cooling_load_RT { get; set; }
        public Nullable<double> system_efficiency_kwRT { get; set; }
        public Nullable<double> system_heat_balance { get; set; }
    
        public virtual Chiller_Facility Chiller_Facility { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chiller_Profile> Chiller_Profile { get; set; }
    }
}