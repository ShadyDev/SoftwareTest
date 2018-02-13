using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareTest.ViewModels
{
    public class FormViewModel
    {
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? Depth { get; set; }
        public float? Weight { get; set; }
        public bool IsVisiblePrice { get; set; }
        public PriceViewModel PriceVM { get; set; }
        public string Notification { get; set; }
    }
}