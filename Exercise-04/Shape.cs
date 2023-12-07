using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_04;

namespace Exercise_04
{
    public class Shape
    {
        public virtual float Calculatearea()
        {
            return 0;
        }
    }


    public class Circle : Shape
    {
        public float Radius { get; set; }

        public override float Calculatearea()
        {
            return (float)(Math.PI * Math.Pow(Radius, 2));
        }

    }
}
