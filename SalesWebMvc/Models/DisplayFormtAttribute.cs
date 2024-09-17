using System;

namespace SalesWebMvc.Models
{
    internal class DisplayFormtAttribute : Attribute
    {
        public object DataFormatString { get; set; }
    }
}