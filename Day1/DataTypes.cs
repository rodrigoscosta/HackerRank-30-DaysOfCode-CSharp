using System.IO;

class DataTypes
{
    static void Main(String[] args) 
    {
    int i = 4;
    double d = 4.0;
    string s = "HackerRank ";
 
    int i2 = Convert.ToInt32(Console.ReadLine());    

    double d2 = Convert.ToDouble(Console.ReadLine());
    
    string s2 = Console.ReadLine();

        int i3 = i + i2;
        double d3 = d + d2;
        string s3 = s + s2;
        Console.WriteLine(i3);
        Console.WriteLine("{0:F1}", d3);
        Console.WriteLine(s3);

        Console.ReadKey();     
    }
}