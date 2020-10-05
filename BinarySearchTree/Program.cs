using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree numbers = new BinarySearchTree();
            numbers.Add(50);
            numbers.Add(17);
            numbers.Add(23);
            numbers.Add(12);
            numbers.Add(54);
            numbers.Search(77);
            Console.ReadLine();
            
           
        }

        
    }
}
