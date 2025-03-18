using System.Linq.Expressions;

namespace PRA_Vaje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NalogaS12();
        }

        // Seznami

        public static void NalogaS12() 
        {
            List<char> seznam = new List<char>() { 'a', 'b', 'e', 'o', 'c', 'd', 'i'};

            List<char> samoglasniki = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            // izbrisat samoglasnike
            for (int i = 0; i < seznam.Count(); i++) 
            {
                if (samoglasniki.Contains(seznam[i])) 
                {
                    seznam.RemoveAt(i); // izbriše na i-tem mestu
                    //seznam.Remove(seznam[i]); // izbriše prvo pojavitev
                    i--;
                }
            }

            // izpis končnega seznama
            for (int i = 0; i < seznam.Count(); i++)
            {
                Console.Write(seznam[i] + " ");
            }
            Console.WriteLine();
        }

        public static void NalogaS1_2() 
        {
            // inicializiramo prazen seznam
            List<int> seznam = new List<int>();

            // dodamo nekaj elementov v seznam
            seznam.Add(1); seznam.Add(2); seznam.Add(3);
            seznam.Add(4); seznam.Add(5); seznam.Add(6);
            seznam.Add(7); seznam.Add(8); seznam.Add(9);

            int moznaVelikost = seznam.Capacity;
            // izpisimo seznam - z indeksi
            for (int i = 0; i < seznam.Count(); i++) 
            {
                Console.Write(seznam[i] + " ");
            }
            Console.WriteLine();

            seznam.Insert(5, 11); // indeks, element

            for (int i = 0; i < seznam.Count(); i++)
            {
                Console.Write(seznam[i] + " ");
            }
            Console.WriteLine();
        }

        // Tabele

        public static void Tabele() 
        {
            int[,] tabela = { {1,2,3 }, {4,5,6 }, {7,8,9 } }; // 2d tabela = tabela tabel
            int[,,] tabela2 = new int[3,4,5]; // 3 elementi, kjer je vsak 2d tabela
                                              // vsak element je 2d tabela s 4 elementi, kjer je vsak tabela
                                              // s 5 elementi
                                              // izpis spremenljivke tabela (2d) 
            for (int i = 0; i < tabela.GetLength(0); i++) 
            {
                for (int j = 0; j < tabela.GetLength(1); j++) 
                {
                    Console.Write(tabela[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Naloga10_2()
        {
            int[] tabela = [12, 22, 3, 10, 33, 6, 17, 25];
            // vnos uporabnika
            Console.WriteLine("Vnesi celo stevilo");
            string vnos = Console.ReadLine();
            int n = int.Parse(vnos);
            int stevecSodih = 0;
            bool pogoj = false; // da nam pove ali smo našli n-to sodo število
            for (int i = 0; i < tabela.Length; i++)
            {
                // prestejmo soda stevila
                if (tabela[i] % 2 == 0)
                {
                    stevecSodih++;
                }
                if (stevecSodih == n)
                {
                    Console.WriteLine(tabela[i]);
                    pogoj = true;
                    break;
                }
            }
            if (pogoj == false) 
            {
                Console.WriteLine("Tako stevilo ne obstaja.");
            }
        }

        public static void Naloga10() 
        {
            int[] tabela = [12, 22, 3, 10, 33, 6, 17, 25];

            // vnos uporabnika
            Console.WriteLine("Vnesi celo stevilo");
            string vnos = Console.ReadLine();
            int n = int.Parse(vnos);

            // prestejmo soda stevila
            int stevecSodih = 0;
            for (int i = 0; i < tabela.Length; i++) 
            {
                if (tabela[i] % 2 == 0) 
                {
                    stevecSodih++;
                }
            }

            if (n < 1 || stevecSodih < n)
            {
                Console.WriteLine("Tak element ne obstaja");
            }
            else // če je dovolj sodih elementov, gremo iskat n-ti sodi element
            {
                int stevec = 0;
                // sprehod po tabeli
                for (int i = 0; i < tabela.Length; i++) 
                {
                    // šteje soda števila v tabeli
                    if (tabela[i] % 2 == 0) 
                    {
                        stevec++;
                    }
                    // če smo našli n-to sodo število, ga izpišemo in končamo iskanje
                    if (stevec == n) 
                    {
                        Console.WriteLine(tabela[i]);
                        break;
                    }
                }
            }
        }

        public static void Naloga9() 
        {
            int[] tabela = [12, 21, 3, 10, 33, 5, 17, 25];

            // 1) Spremenljivke: max, min, ixMax, ixMin
            int max = tabela[0];
            int min = tabela[0];
            int ixMax = 0;
            int ixMin = 0;

            // 2) Sprehod po tabeli
            for (int i = 0; i <= tabela.Length; i++) 
            {
                // 3) Primerjamo trenutni element s prejšnjima min in max
                if (tabela[i] > max) 
                {
                    max = tabela[i];
                    ixMax = i;
                }
                if (tabela[i] < min) 
                {
                    min = tabela[i];
                    ixMin = i;
                }
            }
            Console.WriteLine(max + " " + min);
            Console.WriteLine(ixMax + " " + ixMin);
        }

        public static void Izpis(char[] tabela)  
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                Console.Write(tabela[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Naloga4() 
        {
            char[] tabela = ['a', 'b', 'c', 'd', 'e'];

            // z novo tabelo
            char[] novaTabela = new char[tabela.Length];
            for (int i = 0; i < tabela.Length; i++) 
            {
                novaTabela[tabela.Length - 1 - i] = tabela[i];
            }
            Izpis(novaTabela);

            // brez nove tabele
            for (int i = 0; i < tabela.Length/2; i++) 
            {
                char temp = tabela[i];
                tabela[i] = tabela[tabela.Length - 1 - i];
                tabela[tabela.Length - 1 - i] = temp;
            }
            Izpis(tabela);
        }

        public static void Naloga3() 
        {
            char[] tabela = ['a', 'b', 'c', 'd', 'e'];

            // i++ - post-increment
            // ++i - pre-increment
            for (int i = tabela.Length - 1; i >= 0; i--) 
            {
                Console.Write(tabela[i] + " ");
            }
            Console.WriteLine();

            // z while zanko od indeksa 0 naprej
            int j = 0;
            while (j < tabela.Length) 
            {
                Console.Write(tabela[j] + " ");
                j++;
            }
            Console.WriteLine();
        }

        public static void Naloga2() 
        {
            char[] tabela = ['1', '2', '3', '4', '5'];

            //tabela[0] + " " + tabela[1] + " " + tabela[2] + " "

            // klasičen sprehod preko tabele - z indeksi
            char crka;
            for (int i = 0; i < tabela.Length; i++) 
            {
                crka = tabela[i];
                Console.Write(crka + " ");
            }
            Console.WriteLine();

            // sprehod preko tabele - preko elementov
            foreach (char znak in tabela) 
            {
                Console.Write(znak + " ");
            }
            Console.WriteLine();
        }

        public static void Naloga1() 
        {
            // prvi način - podamo število elementov
            // ustvarimo tabelo s 5 polji,
            // s privzeto vrednostjo izbranega tipa ("")
            string[] tabela = new string[5];

            // drugi način - podamo elemente tabele
            int[] tabela2 = [1, 2, 3, 4, 5];

            Console.WriteLine("Prvi element obeh tabel");
            Console.WriteLine(tabela[0] + " " + tabela2[0]);

            Console.WriteLine("Zadnji element obeh tabel");
            Console.WriteLine(tabela[4] + " " + tabela2[4]);

            // splošen način za zadnji element
            int dolzinaTabele2 = tabela2.Length;
            Console.WriteLine(tabela2[dolzinaTabele2 - 1]);
        }
    }
}
