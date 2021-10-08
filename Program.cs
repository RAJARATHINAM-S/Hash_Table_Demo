using HashTable;
using System;

namespace HashTableDemo
{
    class Program
    {
       
            

        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo"); //() []
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);
            string hash2 = hash.Get("2");
            Console.WriteLine("2th index value: " + hash2);
            Console.ReadKey();
            MyMapNode<string, string> table = new MyMapNode<string, string>(18);
            //UC 2*******************************************************************************************            //  “Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into //paranoid avoidable
            table.Add("0","Paranoids");
            table.Add("1", "are ");
            table.Add("2", "not");
            table.Add("3", "paranoid");
            table.Add("4", "because");
            table.Add("5", "they");
            table.Add("6", "are");
            table.Add("7", "paranoid");
            table.Add("8", "but");
            table.Add("9", "because");
            table.Add("10", "they");
            table.Add("11", "keep");
            table.Add("12", "putting");
            table.Add("13", "deliberately");
            table.Add("14", "themselves");
            table.Add("15", "into");
            table.Add("16", "paranoid");
            table.Add("17", "avoidable");
            table.Add("18", "suitations");

            string table5 = table.Get("5");


            Console.WriteLine("5th index value: " + table5);
            string table2 = table.Get("2");
            Console.WriteLine("2th index value: " + table2);
            Console.ReadKey();

            //UC4*****************************************************************((((UC4))))//
           
            var remove = table.Get("17");
            if (table.Remove("17"))
            {
                Console.WriteLine("The Deleted Word is..."+remove);
            }
            
            Console.ReadKey();
        }
    }
}
