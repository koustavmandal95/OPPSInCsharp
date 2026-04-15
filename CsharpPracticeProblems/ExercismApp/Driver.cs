using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApp
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            string encoded = "aabbbcccc"; //"AABBBCCCC";
            string decoded = "12WB12W3B24WB";

             //Console.WriteLine(RunEncoding.Encode(encoded));
             Console.WriteLine(RunEncoding.Decode(decoded));
    
        }

    }
}