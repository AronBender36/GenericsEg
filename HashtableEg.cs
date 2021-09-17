using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEg {
    class HashtableEg {
        public static void Main() {
            // Hashtable ht = new Hashtable();
            Dictionary<string, string> ht = new Dictionary<string, string>();
            ht.Add("1001", "Apple");
            ht.Add("1002", "Kiwi");
            ht.Add("1003", "Pears");
            ht.Add("1004", null);
            //ht.Add(null, "Banana");
            Console.WriteLine("Keys");
            foreach(var item in ht.Keys) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Values");
            foreach (var item in ht.Values) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Key\tValue");
            foreach(KeyValuePair<string, string> de in ht) {
                Console.WriteLine(de.Key + "\t" + de.Value);
            }
            Console.WriteLine("Enter the search key");
            string search = Console.ReadLine();

            if(ht.ContainsKey(search)) {
                Console.WriteLine(ht[search]);
            }
            else {
                Console.WriteLine("Item Not Found");
            }

            Stack s = new Stack();
            s.Push(10);
            object a = s.Pop();

            Queue q = new Queue();
            q.Enqueue(34);
            object b = q.Dequeue();

            Console.WriteLine("Hashset");
            HashSet<int> scores = new HashSet<int>();
            scores.Add(80);
            scores.Add(80);
            scores.Add(70);
            scores.Add(90);
            scores.Add(90);
            scores.Add(70);
            foreach(int item in scores) {
                Console.WriteLine(item);
            }


        }
    }
}
