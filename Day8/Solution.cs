using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(String[] args)
    {
       int numberTests = Convert.ToInt32(Console.ReadLine());
       
       Dictionary<string, string> dictionary = new Dictionary<string, string>();
       
        string queryKey;
       
       for(var i = 0; i < numberTests; i++)
       {
          string[] inputs = Console.ReadLine().Split();
          dictionary[inputs[0]] = inputs[1];
       }
       
       while ((queryKey = Console.ReadLine()) != null) 
        {
            if (dictionary.ContainsKey(queryKey)) 
            {
                 Console.WriteLine($"{queryKey}={dictionary[queryKey]}");
            } 
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}