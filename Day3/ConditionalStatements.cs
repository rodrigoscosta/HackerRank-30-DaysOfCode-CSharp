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

class ConditionalStatements
{
    static void Main(string[] args) 
    {
        int N = Convert.ToInt32(Console.ReadLine());
        
        if (N%2 == 1 || (N > 5 && N < 21))
        {
            Console.WriteLine("Weird");
        }
        else
        {
            Console.WriteLine("Not Weird");
        }
    }
}