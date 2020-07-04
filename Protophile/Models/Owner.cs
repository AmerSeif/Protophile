using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protophile.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }



        public IEnumerable<ProtofolioItem>   ProtofolioItem { get; set; }
    }
}