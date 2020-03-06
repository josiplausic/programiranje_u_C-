using System;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                long l = long.MaxValue;
                //int i = Convert.ToInt32(l);
                int i = checked((int)l);
                Console.WriteLine("Broj: {0}",i);
            }
            catch (System.IO.IOException e) {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
