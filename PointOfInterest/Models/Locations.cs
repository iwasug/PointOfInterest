using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PointOfInterest.Models
{
    public class Locations
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string name { set; get; }
        public Locations(double latitude, double longitude, string name)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.name = name;
        }
    }
}
