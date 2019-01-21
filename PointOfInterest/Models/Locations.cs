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


        public enum DistanceUnit { Miles, Kilometers };
        public double HaversineDistance(LatLng pos1, LatLng pos2, DistanceUnit unit)
        {
            double R = (unit == DistanceUnit.Miles) ? 3960 : 6371;
            var lat = DegreeToRadian((pos2.Latitude - pos1.Latitude));
            var lng = DegreeToRadian((pos2.Longitude - pos1.Longitude));
            var h1 = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
                          Math.Cos(DegreeToRadian(pos1.Latitude)) * Math.Cos(DegreeToRadian(pos2.Latitude)) *
                          Math.Sin(lng / 2) * Math.Sin(lng / 2);
            var h2 = 2 * Math.Asin(Math.Min(1, Math.Sqrt(h1)));
            return R * h2;
        }
        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public class LatLng
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }

            public LatLng()
            {
            }

            public LatLng(double lat, double lng)
            {
                this.Latitude = lat;
                this.Longitude = lng;
            }
        }

    }
}
