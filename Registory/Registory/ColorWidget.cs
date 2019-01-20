using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class ColorWidget : IWidget
    {
        public string Color { get; set; }
        public ColorWidget(string color)
        {
            Color = color;
        }
        
        public void color()
        {
            Console.WriteLine("COLOR : " + Color);
        }
    }
}
