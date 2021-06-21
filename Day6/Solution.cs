using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int T = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i< T; i++)
        { 
            char[] S = Console.ReadLine().ToCharArray();
        
            string firstS= string.Empty;
            string lastS= string.Empty;
        
            for(int j = 0; j < S.Length; j++)
            {
             firstS+= (j % 2)==0 ? S[j].ToString() : "";
             lastS+= (j % 2)!=0 ? S[j].ToString() : "";
            }
            Console.WriteLine($"{firstS} {lastS}");
        } 
    }
}