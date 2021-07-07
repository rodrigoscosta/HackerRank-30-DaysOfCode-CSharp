using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    public static void Main(string[] args)
    {
        int numberTest = Convert.ToInt32(Console.ReadLine());
        
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        foreach(var i in array.Reverse())
        {
            Console.Write($"{i} ");
        }
    }
}