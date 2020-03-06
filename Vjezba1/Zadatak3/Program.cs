using System;
using System.Collections.Generic;

namespace Zadatak3
{
    class Program
    {
        public enum VrstaRacuna {
            Štednja, 
            Tekući_račun, 
            Žiro_račun
        }
        public struct BankAccount {
            public int BrojRacuna { get; set; }
            public double IznosNaRacunu { get; set; }
            public VrstaRacuna VR { get; set; }

            
            public BankAccount(int br, double iznos, VrstaRacuna vr) {
                BrojRacuna = br;
                IznosNaRacunu = iznos;
                VR = vr;
            }


            public void PrintAccount()
            {
                Console.WriteLine("Broj računa: " + this.BrojRacuna);
                Console.WriteLine("Iznos na računu: " + this.IznosNaRacunu.ToString("C"));
                Console.WriteLine("Vrsta računa: " + this.VR);
            }

        }

        public static bool ProvjeraBrojevaRacuna(List<BankAccount> ba, int br)
        {
            foreach(BankAccount b in ba)
            {
               if(br == b.BrojRacuna)
                {
                    return true;
                }
            }
            return false;
        }

        public static void PrintAll(List<BankAccount> ba) {
            foreach (BankAccount b in ba) {
                b.PrintAccount();
                Console.WriteLine();
            }
        }

        public static BankAccount NewBankAccount(List<BankAccount> listaRacuna)
        {
            Console.WriteLine("Unesite broj računa: ");
            int br = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (ProvjeraBrojevaRacuna(listaRacuna, br) == true)
                {
                    Console.WriteLine("Uneseni broj računa je zauzet, unesite ponovno: ");
                    br = Convert.ToInt32(Console.ReadLine());
                }
                else { break; }
            }
            Console.WriteLine();

            Console.WriteLine("Unesite iznos na računu: ");
            double iznos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            VrstaRacuna vr;
            while (true)
            {
                Console.WriteLine("Odaberite vrstu računa: ");
                Console.WriteLine("0 - Štednja");
                Console.WriteLine("1 - Tekući_račun");
                Console.WriteLine("2 - Žiro_račun");
                string odabir = Console.ReadLine();
                if (odabir == "0")
                {
                    vr = VrstaRacuna.Štednja;
                    break;
                }
                else if (odabir == "1")
                {
                    vr = VrstaRacuna.Tekući_račun;
                    break;
                }
                else if (odabir == "2")
                {
                    vr = VrstaRacuna.Žiro_račun;
                    break;
                }
                else
                {
                    Console.WriteLine("Odabir netočan!");
                }
            }
            return  new BankAccount(br, iznos, vr);
        }

        public static void Main(string[] args) {
            List<BankAccount> listaRacuna = new List<BankAccount>
            {
                new BankAccount(1, 555.44, VrstaRacuna.Žiro_račun),
                new BankAccount(2, -200.95, VrstaRacuna.Tekući_račun),
                new BankAccount(3, 200000.01, VrstaRacuna.Štednja),
                new BankAccount(4, 0, VrstaRacuna.Štednja),
                new BankAccount(5, -18257.53, VrstaRacuna.Tekući_račun)
            };

            string izbor;
            while (true) {
                Console.WriteLine("            Izbornik     ");
                Console.WriteLine();
                Console.WriteLine("1 - Upis novog računa");
                Console.WriteLine("2 - Ispis svih računa");
                Console.WriteLine("Q - Izlaz");
                Console.WriteLine("Izbor: ");
                izbor = Console.ReadLine();
                Console.WriteLine();

                if (izbor == "1")
                {
                    listaRacuna.Add(NewBankAccount(listaRacuna));
                }

                else if (izbor == "2")
                {
                    PrintAll(listaRacuna);
                }

                else if(izbor.ToUpper() == "Q") {
                    Console.WriteLine("Izlazak iz aplikacije!");
                    break;
                }

                else {
                    Console.WriteLine("Greška odabira izbora!");
                    break;
                }

                Console.WriteLine("Press Enter to continue!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
