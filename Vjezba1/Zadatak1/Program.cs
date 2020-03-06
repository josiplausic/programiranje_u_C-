using System;

namespace Zadatak1 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Unesite prvi broj:");
                int prvi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesite drugi broj:");
                int drugi = Convert.ToInt32(Console.ReadLine());

                int rez = prvi / drugi;
                Console.WriteLine("Currency: " + rez.ToString("C"));
                Console.WriteLine("Integer: " + rez.ToString("D"));
                Console.WriteLine("Scientific: " + rez.ToString("E"));
                Console.WriteLine("Fixed-point: " + rez.ToString("F"));
                Console.WriteLine("General: " + rez.ToString("G"));
                Console.WriteLine("Number: " + rez.ToString("N"));
                Console.WriteLine("Hexadecimal: " + rez.ToString("X"));

            }
            catch (System.IO.IOException e) {
                Console.WriteLine(e.Message);
            }
            catch (OutOfMemoryException e) {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        } 
    }
}
