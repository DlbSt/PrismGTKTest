using PrismGTKTest.Enums;
using System;

namespace PrismGTKTest.Models
{
    public class CustomMenuItem
    {
        public string Text { get; set; }
        public NavigationEnum MenuItem { get; set; }
        public Type TargetType { get; set; }
    }
}
