using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfInterest.Models
{
    public class Rumah
    {
        [Key]
        [Required]
        public Guid Id { set; get; }
        [Required]
        public string Nama { set; get; }
        [Required]
        public string Type { set; get; }
        [Required]
        public string Alamat { set; get; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime Create { set; get; }
        public DateTime Update { set; get; }

        public Rumah()
        {
            Id = Guid.NewGuid();
            Create = DateTime.Now;
        }
    }
}
