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
    
    public partial class User
    {
        public int Users_ID { get; set; }
        public string Display_ID { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> Creation_Time { get; set; }
        public Nullable<System.DateTime> Edit_Time { get; set; }
        public Nullable<int> Availability { get; set; }
        public string Status { get; set; }
        public string User_Name { get; set; }
        public Nullable<System.Guid> userlogin_id { get; set; }
        public string Country { get; set; }
        public string Designation_2 { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Customer_Code { get; set; }
        public string Authentication { get; set; }
        public string User_Group { get; set; }
        public string EPCIS_Access { get; set; }
        public string Email { get; set; }
        public string Handphone { get; set; }
    }
}