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
    static void solve(double meal_cost, int tip_percent, int tax_percent) 
    {  
        double tip = tip_percent *(meal_cost/100);
        double tax = tax_percent *(meal_cost/100);
        double totalCost = meal_cost + tip + tax;
        Console.WriteLine(Math.Round(totalCost));
    }

    static void Main(string[] args) 
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());
        
        solve(meal_cost,tip_percent,tax_percent);
    }
}
