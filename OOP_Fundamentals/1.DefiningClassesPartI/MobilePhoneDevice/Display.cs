using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    //Task 1 :Define a class that holds information about display characteristics
    public class Display
    {
        private double? sizeOfDisplay;
        private byte? numberOfColors;

        public double? SizeOfDisplay
        { 
            get { return this.sizeOfDisplay; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("\n\nSize of display must have positive value.\n");
                }

                this.sizeOfDisplay = value; 
            }
        }
        
        public byte? NumberOfColors
        {
            get { return this.numberOfColors; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("\n\nNumber of colors must have positive value.\n");
                }

                this.numberOfColors = value; 
            }
        }

        //Task 2:Define several constructors
        public Display()
        {
            
        }

        //Task 2:Define several constructors
        public Display(double? size, byte? numberOfColors)
        {
            this.SizeOfDisplay = size;
            this.NumberOfColors = numberOfColors;
        }
    }
}