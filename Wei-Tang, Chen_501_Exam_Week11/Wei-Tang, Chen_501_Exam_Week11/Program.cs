using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wei_Tang__Chen_501_Exam_Week11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new object of Parallelogram class
            Parallelogram parallelogram = new Parallelogram();
            //Declare the data fields
            double height, width;
            int count = 3;
            //Use for to include the data validations
            for (int i=1; i<4; i++)
            {
                //Instruction
                Console.WriteLine("Hello there! Here we are going to determine the area of a parallelogram! \n You have {0} times left to enter the value.", count);
                //Enable user to enter the value of height
                Console.WriteLine("Please Enter the height:");
                double.TryParse(Console.ReadLine(), out height);
                //To prevent user input the negative value
                if (height > 0)
                {
                    parallelogram.HeightOfParallelogram = height;
                    
                }
                else
                {
                    Console.WriteLine("Your input value can not be less than 0!\n");
                    i--;
                    continue;
                }
                //Enable user to enter the value of width
                Console.WriteLine("Please Enter the width:");
                double.TryParse(Console.ReadLine(), out width);
                //To prevent user input the negative value
                if (width > 0)
                {
                    parallelogram.WidthOfParallelogram = width;
                }
                else
                {
                    Console.WriteLine("Your input value can not be less than 0!\n");
                    i--;
                    continue;
                }
                //Calculate the area of the parallelogram and then use Property to store the outcome into the data of object parallelogram
                
                //TO help user to know how many time they got to enter the value
                count--;
                //Display the detail of the object parallelogram
                Console.Clear();
                Console.WriteLine("{0}\n", parallelogram);
                
                
                
            }
            
            Console.ReadKey();
        }
    }
}
