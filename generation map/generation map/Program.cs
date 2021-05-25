using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generation_map
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Obj_loc> tests = new List<Obj_loc>();
            tests.Add(new Obj_loc(0, 0, 1, 1));
            tests.Add(new Obj_loc(5, 4, 3, 2));
            tests.Add(new Obj_loc(5, 4, 3, 2));
            tests.Add(new Obj_loc(2, 3, 4, 5));

            //Pattern_map test = new Pattern_map(tests);
            Pattern_map test = new Pattern_map("C:\\Users\\windo\\Documents\\Unity\\test");
            Console.WriteLine(test);
            //test.save("C:\\Users\\windo\\Documents\\Unity\\test");
        }
    }
}
