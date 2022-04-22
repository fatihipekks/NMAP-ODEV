using System;
using System.Diagnostics;

namespace odevNmap
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;

            Console.Write("Lütfen İP Giriniz: ");
            a = Console.ReadLine();
            
            //Process Sınıfı Oluşturduk.
            Process process = new Process();
        
            process.StartInfo.FileName = "nmap.exe";
            process.StartInfo.Arguments = "nmap -T4 -A -v " + a;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
            
            // Process'i bitirir.
            process.WaitForExit();

        }
    }
}