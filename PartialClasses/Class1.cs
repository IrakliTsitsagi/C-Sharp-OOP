using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{

    // class 1 da class 2 rom orivegan Animals mqondes saxeli, vwer win partial
    partial class Animals
    {
        public string animalName;
        public string animalColor;

        public void GetName() 
        {
            Console.WriteLine("dog name is max");
        }
    }
}
