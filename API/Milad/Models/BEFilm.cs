using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milad.Models
{
    public class BEFilm
    {
        public int id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public double IMDBScore { get; set; }
        public string IMDBId { get; set; }
    }
}