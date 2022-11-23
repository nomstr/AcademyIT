using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AiTi_CS_Course_firstlab_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                line = line.Replace(",", " y:");
                line = "x:" + line;
                Console.WriteLine(line);
                
            }
        }
    }
}
