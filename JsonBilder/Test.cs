using JsonBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonBilder
{
    class Test
    {

        public static void test1()
        {
            string resultJson = new JsonString()
                .SetDouble("Height", 180.6)
                .SetInt("Id", 123)
                .SetString("FirstName", "Elham")
                .SetString("LastName", "Heydari")
                .SetBolean("IsActive", false)
                .Build();

            Console.WriteLine(resultJson);
            Console.ReadKey(); 
        }
   
           
   
        public static void test2()
        {

        }


    }
}
