using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assettrack.Models
{
    public class ModelProperties
    {
        public IQueryable<Asset_Data> Asset_Data_Iqueryable { get; set; }

        public Asset_Data Asset_Data_Object { get; set; }
    }
}