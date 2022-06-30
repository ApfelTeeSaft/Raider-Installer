using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Reflection;

namespace NextFN_Installer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Raider Gameserver Installer | created by ApfelTeeSaft#7181";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("== [ ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("My Server: https://discord.gg/YcCxXVsBZE Raider Discord: https://discord.gg/BFAUDG4tzt ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("] ==\n\n");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the Raider installer");
            Console.WriteLine("How would you like to install?");
            Console.WriteLine("1. Full (takes up to 10 Gigabytes because of Fortnite! please choose 'lite' if you already have fortnite 3.5 installed)");
            Console.WriteLine("2. Lite (Only downloads Raider, Lawin and UUU doesnt take up that much space)");
            Console.WriteLine("3. Exit");
            Console.Write("Selection: ");
            var Num = Console.ReadLine();

            switch(Num)
            {
                case "1":
                    Install();
                break;
                case "one":
                    Install();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                case "three":
                    Environment.Exit(0);
                    break;
                case "2":
                    InstallLite();
                    break;
                case "two":
                    InstallLite();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Incorrect input, press any key to close");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }

        public static void Install()
        {
            Console.Write("Where would you like to install to: ");
            var Dir = Console.ReadLine();
            var DirFinish = Dir + @"\downloaded.zip";
            using (var client = new WebClient())
            {
                Console.Clear();
                Console.WriteLine("Installation has Started");
                client.DownloadFile("https://cdn-125.anonfiles.com/B5f9Dbt8y8/6421622a-1656587901/Raider_with_Fortnite.zip", Dir + @"\downloaded.zip");
                System.IO.Compression.ZipFile.ExtractToDirectory(DirFinish, Dir);
                File.Delete(DirFinish);
                Console.WriteLine("Installation has completed!");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.Write("The installation has completed successfully!\n");
                Console.Write("Please make sure to join these Discords!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("My Server: https://discord.gg/YcCxXVsBZE Raider Discord: https://discord.gg/BFAUDG4tzt\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public static void InstallLite()
        {
            Console.Write("Where would you like to install to: ");
            var Dir = Console.ReadLine();
            var DirFinish = Dir + @"\downloaded.zip";
            using (var client = new WebClient())
            {
                Console.Clear();
                Console.WriteLine("Installation has Started");
                client.DownloadFile("https://cdn-146.anonfiles.com/N1b7Bct8y8/b3b52e3b-1656588359/Raider.zip", Dir + @"\downloaded.zip");
                System.IO.Compression.ZipFile.ExtractToDirectory(DirFinish, Dir);
                File.Delete(DirFinish);
                Console.WriteLine("Installation has completed!");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.Write("The installation has completed successfully!\n");
                Console.Write("Please make sure to join these Discords!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("My Server: https://discord.gg/YcCxXVsBZE Raider Discord: https://discord.gg/BFAUDG4tzt\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
