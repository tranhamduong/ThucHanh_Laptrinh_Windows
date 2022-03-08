using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_TH_02
{
    abstract class Shape
    {
        public float area { get; set; }
        public float perimeter { get; set; }

        public abstract float calculateArea();

        public abstract float calculatePerimeter();

    }
}
