using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protophile.Models
{
    public class ProtofolioItem
    {
        public int Id { get; set; }
        public string ProtofolioName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public object Entity { get; internal set; }
    }
}