using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace GenericsEg {
    class ArrayListEg {
        public static void main() {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("Rick");
            al.Add(true);
            al.Add(23.45f);
            al.Insert(1, "Tom");

            foreach(var item in al) {
                Console.WriteLine(item);
            }

            al.Remove(true);

            foreach (var item in al) {
                Console.WriteLine(item);
            }

        }
    }
}
