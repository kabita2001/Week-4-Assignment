using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03
{
    internal class Rectangle
    {
        private float Length;
        private float Width;


        public Rectangle(float Length, float Width) 
        {
            this.Length = Length;
            this.Width = Width;
        }

        public float CalculateArea()
        { 
          return Length* Width;
        }

            

      
    }
}
