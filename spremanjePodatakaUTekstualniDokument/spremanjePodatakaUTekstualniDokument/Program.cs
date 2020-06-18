using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spremanjePodatakaUTekstualniDokument
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\Vjezba";
            string fileName = "Test.txt";
            string fullPath = folder + fileName;
            string[] test = { Console.ReadLine() };
            File.WriteAllLines(fullPath, test);
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
            Console.ReadKey();
        }
    }
}