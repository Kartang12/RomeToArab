using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml;

namespace Rome
{
    class Program
    {
        static Dictionary<int, string> ra1 = new Dictionary<int, string>
        { { 1000, "M" },  { 500, "D" }, { 100, "C" },
                          { 50 , "L" }, { 10 , "X" },
                          { 5  , "V" }, { 1  , "I" } };

        static Dictionary<int, string> ra2 = new Dictionary<int, string>
        { { 900, "CM" },  { 400, "CD" },
                          { 90 , "XC" },  { 40 , "XL" },
                          { 9  , "IX" },  { 4  , "IV" }};

        static void Main(string[] args)
        {
            string rome = Console.ReadLine();

            int a = GetIs(ref rome, ra2);
            a += GetIs(ref rome, ra1);
            //Node last = createTree(rome);
            //List<int> numbers = TreeToList(last);

            //foreach (int a in numbers)
            Console.WriteLine(a);
        }

        //static Node createTree(char[] arr)
        //{
        //    Node parrent;
        //    Node current = null;


        //    foreach (char c in arr)
        //    {
        //        if (current == null)
        //        {
        //            current = new Node(c);
        //            parrent = current;
        //            continue;
        //        }

        //        if (checkI(c))
        //        {
        //            if (current.HasLeft())
        //            {
        //                parrent = current;
        //                current = current.left;
        //                current.parrent = parrent;
        //            }

        //            current.left = new Node(c);

        //            Console.WriteLine("Add I");
        //        }
        //        else
        //        {
        //            if (current.HasRight())
        //            {
        //                parrent = current;
        //                current = current.right;
        //                current.parrent = parrent;
        //            }
        //            current.right = new Node(c);

        //            Console.WriteLine($"Add {c}");
        //        }
        //    }

        //    return current;
        //}

        //static bool checkI(char c)
        //{
        //    return c.Equals('I');
        //}

        //static List<int> TreeToList(Node last)
        //{
        //    List<int> numbers = new List<int>();
        //    while (last.HasParent())
        //    {
        //        if (last.HasRight())
        //            numbers.Add(ra[last.right.value]);
        //        if (last.HasLeft())
        //            numbers.Add(ra[last.left.value]);

        //        last = last.parrent;
        //    }

        //    if (last.HasRight())
        //        numbers.Add(ra[last.right.value]);
        //    if (last.HasLeft())
        //        numbers.Add(ra[last.left.value]);
        //    if (last.parrent == null)
        //        numbers.Add(ra[last.value]);

        //    return numbers;
        //}
        
        static int GetIs(ref string input, Dictionary<int, string> dictionary)
        {
            int result = 0;
            foreach(KeyValuePair<int, string> value in dictionary)
            {
                int index = -1;
                while((index = input.IndexOf(value.Value)) > -1)
                {
                    input = input.Remove(index, value.Value.Length);
                    result += value.Key;
                }
            }
            return result;
        }

    }
}
