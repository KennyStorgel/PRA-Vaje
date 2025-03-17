namespace PRA_Vaje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Naloga23();
            //JePalindrom();
        }

        public static void Naloga23()
        {
            int n = 7;
            int stZvezdic = 2*n - 1; // prva vrstica zvezdice
            int stPresledkov = 0; // prva vrstica presledki

            for (int i = 1; i <= n; i++)
            {
                // izpis vseh presledkov
                for (int j = 1; j <= stPresledkov; j++)
                {
                    Console.Write(" ");
                }
                // izpis vseh zvezdic
                for (int j = 1; j <= stZvezdic; j++)
                {
                    Console.Write("*");
                }
                // popravimo zvezdice in presledke za novo vrstico
                stZvezdic -= 2;
                stPresledkov++;

                Console.WriteLine();
            }
        }

        public static void Naloga21_1()
        {
            int n = 7;
            int stZvezdic = n; // prva vrstica zvezdice
            int stPresledkov = 0; // prva vrstica presledki

            for (int i = 1; i <= n; i++)
            {
                // izpis vseh presledkov
                for (int j = 1; j <= stPresledkov; j++) 
                {
                    Console.Write(" ");
                }
                // izpis vseh zvezdic
                for (int j = 1; j <= stZvezdic; j++)
                {
                    Console.Write("*");
                }
                // popravimo zvezdice in presledke za novo vrstico
                stZvezdic--;
                stPresledkov++;

                Console.WriteLine();
            }
        }
        // 3.1.0.6
        public static void Naloga21() 
        {
            int n = 7;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Naloga18()
        {
            int n = 8;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    // i == j - diagonala (zgoraj levo - dol desno)
                    // i + j == n + 1 - obratna diagonala
                    if (i == j || i + j == n + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Naloga17() 
        {
            int n = 7;

            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= n; j++) 
                {
                    // i == 1 - prva vrstica
                    // i == n - zadnja vrstica
                    // j == 1 - prvi stolpec
                    // j == n - zadnji stolpec
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write("*");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        // Naloga 3.1.0.1
        public static void Naloga16() 
        {
            int n = 7;

            for (int i = 1; i <= n; i++) // zunanja zanka - vrstice (primerjava z Excel - številke)
            {
                for (int j = 1; j <= n; j++) // stolpci - izpiše trenutno vrstico (primerjava z Excel - črke)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // postavi se v novo vrstico
            }
        }
        
        public static void Naloga15() 
        {
            // 1) za vsa števila < 1000 (zanka - for)
            // 2) za vsako od števil pogledamo vse kandidate za delitelje (zanka - for)
            // 3) za vsakega od kandidatov pogledali ali je delitelj in ali je lih (if)
            // 4) če je lih končamo trenutno zanko (break)
            // 5) sicer pridemo do konca zanke (ali smo vmes našli lih delitelj)

            // 5)
            bool pogoj = false;
            // 1)
            for (int i = 1; i < 1000; i++) 
            {
                // 2)
                for (int j = 2; j <= i; j++) // gleda delitelje za stevilo i
                {
                    // 3)
                    if (i % j == 0 && j % 2 == 1) // ali je delitelj in ali je lih
                    {
                        // 5)
                        pogoj = true;
                        // 4)
                        break;
                    }
                    // če nikoli ne gremo v if stavek nimamo lihih deliteljev, torej so vsi sodi (z izjemo 1)
                }
                // 5) ali z break ali nikoli ni prišlo v if stavek
                // pogoj = false le če ni lihega delitelja (z izjemo 1) in ga izpiše
                if(!pogoj) // pogoj == false  ---- !true = false, !false = true
                {
                    Console.WriteLine(i);
                }
                pogoj = false;
            }
        }

        public static void Naloga12() 
        {
            Console.WriteLine("Vnesi pozitivno celo stevilo");
            string vnos = Console.ReadLine(); // "12"
            int stevilo = int.Parse(vnos);  // 12
            // double.Parse, float.Parse, long.Parse, bool.Parse

            int vsotaSodih = 0;
            int stevka = 0;
            while (stevilo != 0) 
            {
                stevka = stevilo % 10;

                if (stevka == 0) 
                {
                    break; // prekine zanko / gre vn iz zanke
                }
                if (stevka % 2 == 0) 
                {
                    vsotaSodih += stevka;
                    stevilo /= 10;
                    continue; // preskoči preostanek zanke in gre od začetka
                }
                Console.WriteLine("Stevka: " + stevka);

                stevilo /= 10;
            }
            Console.WriteLine(vsotaSodih);
        }

        public static void JePalindrom() 
        {
            int stevilo = 12321;
            if (stevilo == ObrniStevilo(stevilo))
            {
                Console.WriteLine("Je palindrom.");
            }
            else 
            {
                Console.WriteLine("Ni palindrom.");
            }
        }

        public static int ObrniStevilo(int stevilo)
        {
            int obrnjenoStevilo = 0;
            int stevka = 0;

            while (stevilo != 0)
            {
                stevka = stevilo % 10;

                obrnjenoStevilo *= 10;
                obrnjenoStevilo += stevka;

                stevilo /= 10;
            }
            return obrnjenoStevilo;
        }

        public static void Naloga8() 
        {
            int stevilo = 12321;
            int kopijaStevila = stevilo;
            int obrnjenoStevilo = 0;
            int stevka = 0;

            while (kopijaStevila != 0)
            {
                stevka = kopijaStevila % 10;

                obrnjenoStevilo *= 10;
                obrnjenoStevilo += stevka;

                kopijaStevila /= 10;
            }

            if (obrnjenoStevilo == stevilo)
            {
                Console.WriteLine("Je palindrom.");
            }
            else 
            {
                Console.WriteLine("Ni palindrom.");
            }
        }

        public static void Naloga7() 
        {
            int stevilo = 12345;
            int obrnjenoStevilo = 0;
            int stevka = 0;

            while (stevilo != 0) 
            {
                stevka = stevilo % 10;

                obrnjenoStevilo *= 10;
                obrnjenoStevilo += stevka;
                
                stevilo /= 10;
            }
            Console.WriteLine(obrnjenoStevilo);
        }

        public static void Naloga4() 
        {
            Random random = new Random();
            int stevec = 0; // za štetje zgeneriranih števil
            int stevilo = 0;
            do
            {
                stevilo = random.Next(0, 101); // vključno s 100
                Console.WriteLine(stevilo);
                stevec++;
            } while (stevilo <= 90);
            Console.WriteLine("Stevilo vseh zgeneriranih: "+stevec);
        }

        public static void Naloga3() 
        {
            int stevilo = 12345; // zacetek
            int stevka = 0;
            int vsota = 0;
            // 0
            // zaustavitveni pogoj (Kdaj naj se zanka konča?)
            // ko je stevilo == 0
            // zaustavitveni pogoj negiramo
            while (stevilo != 0) // pogoj
            {
                stevka = stevilo % 10;
                vsota += stevka;
                stevilo /= 10; // korak
            }
            Console.WriteLine(vsota);
        }

        public static void Naloga2() 
        {
            for (int i = 2; i < 100; i += 2) 
            {
                Console.WriteLine(i);
            }
        }

        public static void Naloga1() 
        {
            int vsota = 0;
            // for (zacetek-iterator; pogoj; korak)
            for (int i = 1; i <= 10; i++)
            {
                vsota += i;
            }
            Console.WriteLine(vsota);

            vsota = 0;
            // while (pogoj)
            int j = 1; // zacetek
            while (j <= 10) // pogoj
            {
                vsota += j;
                j++; // korak
            }
            Console.WriteLine(vsota);

            vsota = 0;
            // do - while (pogoj);
            // najprej se ukazi enkrat izvedejo
            // šele nato pogleda pogoj
            int k = 1; // zacetek
            do
            {
                vsota += k;
                k++; // korak
            } while (k <= 10); // pogoj
            Console.WriteLine(vsota);
        }

        
    }
}
