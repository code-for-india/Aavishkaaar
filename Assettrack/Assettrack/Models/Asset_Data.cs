//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assettrack.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asset_Data
    {
        public int id { get; set; }
        public string asset_id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public Nullable<double> temperature { get; set; }
        public Nullable<double> humidity { get; set; }
        public Nullable<double> pressure { get; set; }
        public Nullable<double> ammonia { get; set; }
        public Nullable<double> sanitary_Index { get; set; }
        public string sanitary_Index_flag { get; set; }
        public string time_stamp { get; set; }
        public Nullable<int> active_users { get; set; }
        public Nullable<int> total_users { get; set; }
        public Nullable<int> rating { get; set; }
    }
}
