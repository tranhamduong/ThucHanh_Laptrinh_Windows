using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Bai_TH_02
{
    internal class Rectangle : Shape
    {
        public int width { get; set; } 
        public int height { get; set; } 

        public Rectangle(int width, int height) {
            this.width = width;
            this.height = height; 
        }


        public Rectangle() { }

        public override float calculateArea()
        {
           return width * height;
        }

        public override float calculatePerimeter()
        {
            return (width + height) * 2;
        }
    }
}
