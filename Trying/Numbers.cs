using System;
using System.Collections.Generic;
using System.Linq;

namespace Trying
{
    class Numbers
    {

        public int Sum(params int [] numbers)
        {
            int sum = 0;
            foreach(var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public void CalculateArrays(int [] Array1 , char operation ,int [] Array2)
        {
            double[] Array3 = new double [Array1.Count()];
            if(Array1.Count()!= Array2.Count())
                Console.WriteLine("There is Error in element count in arrays !!");
            else
            {
                for(int i = 0; i < Array3.Count(); i++)
                {
                    if (operation == '+')
                        Array3[i] = Array1[i] + Array2[i];
                    else if (operation == '-')
                        Array3[i] = Array1[i] - Array2[i];
                    else if (operation == '*')
                        Array3[i] = Array1[i] * Array2[i];
                    else if (operation == '/')
                        Array3[i] = Array1[i] / Array2[i];
                    else
                        Array3[i] = 0;

                }

                foreach (double item in Array3)
                {
                    Console.Write(item + " ");
                }
            }
            
        }

    }
}
