using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protophile.Models
{
    public class Homeviewmodel
    {

        public Owner Owner { get; set; }
        public IEnumerable<ProtofolioItem> ProtofolioItem { get; set; }
    }
}