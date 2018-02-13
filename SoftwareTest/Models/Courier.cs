using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftwareTest.Models
{
    public class Courier
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        //Validators
        public float minWeight { get; set; }
        public float maxWeight { get; set; }
        public float minSize { get; set; }
        public float maxSize { get; set; }
    }
}