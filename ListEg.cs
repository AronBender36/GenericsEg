using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEg {
    class ListEg {
        public static void main() {
            List<int> marks = new List<int>();

            marks.Add(20);
            marks.Add(40);
            marks.Add(12);
            marks.Sort();
            foreach(int item in marks) {
                Console.WriteLine(item);
            }

            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add("Chris");

            foreach(string it in names) {
                Console.WriteLine(it);
            }


        }
    }
}
