using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6_Working_with_Lists__Add__Remove__Search_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("List of Person Names:");
            List<string> Person = new List<string>();
            Person.Add("Abdul Hannan");
            Person.Add("Abdul Rehman");
            Person.Add("Muhammad SAW");
            Person.Add("Mueen");
            Person.Add("Ghanam");
            foreach (var item in Person) 
            {
                Console.WriteLine(item);
            }
            Person.Remove("Mueen");
            Console.WriteLine("\nList after Remove 'Mueen' :");
            foreach (var item in Person)
            {
                Console.WriteLine(item);
            }
            if (Person.Contains("Muhammad SAW"))
            {

                Console.WriteLine("\n'Muhammad SAW' Found in the List.");
            }
            else 
            {
                Console.WriteLine("\n'Muhammad SAW' Found in the List.");
            }
        }
    }
}
