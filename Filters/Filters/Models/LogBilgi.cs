using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filters.Models
{
    public class LogBilgi
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string Tip { get; set; }
        public string HataMesaj { get; set; }
    }
}