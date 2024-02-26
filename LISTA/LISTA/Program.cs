using System.Collections.Generic;

namespace LISTA
{
    class Program { 
    static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("bob");
            list.Add("Anna");
            list.Insert(2, "marco");

            foreach (string nome in list) {
                Console.WriteLine(nome);
            }
            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach(string nome in list2) {
                Console.WriteLine(nome);
            }
        }
    }

}