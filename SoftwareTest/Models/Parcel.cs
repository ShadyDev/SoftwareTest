using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftwareTest.Models
{
    public class Parcel
    {
        [Key]
        public int id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int depth { get; set; }
        public float weight { get; set; }
        public DateTime date { get; set; }
    }
}