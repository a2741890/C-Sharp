using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wei_Tang__Chen_501_Exam_Week11
{
    class Parallelogram
    {
        //Declare the data fields
        private double heightOfParallelogram, widthOfParallelogram, areaOfParallelogram;
        
        //Default Constructor
        public Parallelogram()
        {

        }
        //Constructor with two local variables input needed
        public Parallelogram(double heightOfparallelogram, double widthOfParallelogram)
        {
            Console.WriteLine("Hello, this is a parallelogram!");
            heightOfparallelogram = this.heightOfParallelogram;
            widthOfParallelogram = this.widthOfParallelogram;
            
        }
        //By multiplying the height and width, we use this method to determine the area(return value) of the parallelogram
        public double CalculateArea(double heighOfParallelogram, double widthOfparallelogram)
        {
            double value;
            value = heighOfParallelogram*widthOfparallelogram;
            return value;
        }
        //Override the ToString for this object
        public override string ToString()
        {
            return "The height of the parallelogram is: " + heightOfParallelogram + "\nThe width of parallelogram is: " + widthOfParallelogram + "\nThe area of the Parallelogram is: " + CalculateArea(heightOfParallelogram,widthOfParallelogram);
            
        }
        //Property of heightOfParallelogram variable
        public double HeightOfParallelogram
        {
            get
            {
                return heightOfParallelogram;
            }
            set
            {
                heightOfParallelogram = value;
            }
            
        }
        ////Property of widthOfParallelogram variable
        public double WidthOfParallelogram
        {
            get
            {
                return widthOfParallelogram;
            }
            set
            {
                widthOfParallelogram = value;
            }
        }
        //Property of areaOfParallelogram variable
        public double AreaOfParallelogram
        {
            get
            {
                return areaOfParallelogram;
            }
            set
            {
                areaOfParallelogram = value;
            }
        }

    }
}
