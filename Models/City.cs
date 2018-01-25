using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoServiceTracking.Models
{
    public class City
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string CityTitle { get; set; }
        public string CityDesc { get; set; }
        public string Notes { get; set; }
        public Country Country { get; set; }
    }
}