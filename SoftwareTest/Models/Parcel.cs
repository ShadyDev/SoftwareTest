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
        public string width { get; set; }
        public string height { get; set; }
        public string depth { get; set; }
        public string weight { get; set; }
    }
}