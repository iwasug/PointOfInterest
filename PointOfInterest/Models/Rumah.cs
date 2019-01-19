using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfInterest.Models
{
    public class Rumah
    {
        public Guid Id { set; get; }
        public string Nama { set; get; }
        public string Type { set; get; }
        public string Alamat { set; get; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime Create { set; get; }
        public DateTime Update { set; get; }
    }
}
