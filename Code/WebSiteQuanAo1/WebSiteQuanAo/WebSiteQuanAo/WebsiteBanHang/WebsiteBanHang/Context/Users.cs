//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteBanHang.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int user_id { get; set; }
        public string user_first_name { get; set; }
        public string user_last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<bool> is_admin { get; set; }
    }
}