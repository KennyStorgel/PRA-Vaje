namespace Sudoku
{
    internal class Program
    {
        public static int[,] igralnoPolje = {
                                                {0, 5, 0, 0, 0, 0, 3, 7, 0 },
                                                {3, 0, 0, 0, 5, 1, 0, 8, 0 },
                                                {0, 8, 0, 0, 9, 0, 0, 0, 1 },
                                                {0, 0, 0, 0, 0, 0, 0, 0, 7 },
                                                {8, 7, 6, 0, 0, 0, 2, 9, 5 },
                                                {9, 0, 0, 0, 0, 0, 0, 0, 0 },
                                                {4, 0, 0, 0, 2, 0, 0, 1, 0 },
                                                {0, 6, 0, 4, 7, 0, 0, 0, 2 },
                                                {0, 3, 2, 0, 0, 0, 0, 6, 0 }
                                            };

        public static bool[,] lahkoSpremenim = new bool[9, 9];

        static void Main(string[] args)
        {
            NadzorMoznihSprememb();
            while (JeKonec() == false) 
            {
                Izpis();
                if (!VnosVrednosti()) 
                {
                    Console.WriteLine("Prekinjam igro!");
                    return;
                }
                
            }
            Console.WriteLine("Zmagali ste!");
        }

        public static void NadzorMoznihSprememb() 
        {
            for (int i = 0; i < 9; i++) 
            {
                for (int j = 0; j < 9; j++) 
                {
                    if (igralnoPolje[i, j] == 0) 
                    {
                        lahkoSpremenim[i, j] = true;
                    }
                }
            }
        }

        public static bool JeKonec() 
        {
            for (int i = 0; i < 9; i++) 
            {
                for (int j = 0; j < 9; j++) 
                {
                    if (igralnoPolje[i, j] < 1 || igralnoPolje[i, j] > 9) 
                    {
                        return false; // nismo še končali
                    }
                }
            }
            return true; // vse je pravilno izpolnjeno
        }

        public static bool VnosVrednosti() 
        {
            Console.WriteLine("Vnesi vrstico (1-9), stolpec (1-9) in vrednost (1-9) (locene le s presledkom).");
            Console.WriteLine("Vrednost 0 izbrise vnos, vrednost -1 prekine igranje.");
            string vnos = Console.ReadLine();
            string[] podatki = vnos.Split(' ');

            int vrstica = int.Parse(podatki[0]);
            int stolpec = int.Parse(podatki[1]);
            int vrednost = int.Parse(podatki[2]);

            if (vrednost == -1) 
            {
                return false;
            }

            if (vrednost == 0 && lahkoSpremenim[vrstica - 1, stolpec - 1]) 
            {
                igralnoPolje[vrstica - 1, stolpec - 1] = 0;
            }
            // če ni konflikta vpiši vrednost
            else if (lahkoSpremenim[vrstica - 1, stolpec - 1] && PreveriVnos(vrstica, stolpec, vrednost))
            {
                igralnoPolje[vrstica - 1, stolpec - 1] = vrednost;
            }
            else if (!lahkoSpremenim[vrstica - 1, stolpec - 1]) 
            {
                Console.WriteLine("Ne morete spreminjati začetnih vrednosti!");
            }
            else
            {
                Console.WriteLine("Vrednost je že v stolpcu/vrstici/škatli");
            }
            return true;
        }

        // stolpec in vrstica med 1 in 9
        public static bool PreveriVnos(int vrstica, int stolpec, int vrednost) 
        {
            // preveri stolpec
            for (int i = 0; i < 9; i++) 
            {
                if (igralnoPolje[i, stolpec - 1] == vrednost) 
                {
                    return false;
                }
            }

            // preveri vrstico
            for (int i = 0; i < 9; i++)
            {
                if (igralnoPolje[vrstica - 1, i] == vrednost)
                {
                    return false;
                }
            }

            // TODO: preveri 3x3 - vrstica (1-9) stolpec (1-9)
            int k = -1; // vrstica za 3x3 škatle
            int l = -1; // stolpec za 3x3 škatle
            if (vrstica >= 1 && vrstica <= 3)
            {
                k = 0;
            }
            else if (vrstica >= 4 && vrstica <= 6) 
            {
                k = 1;
            }
            else if (vrstica >= 7 && vrstica <= 9)
            {
                k = 2;
            }

            if (stolpec >= 1 && stolpec <= 3)
            {
                l = 0;
            }
            else if (stolpec >= 4 && stolpec <= 6)
            {
                l = 1;
            }
            else if (stolpec >= 7 && stolpec <= 9)
            {
                l = 2;
            }

            for (int i = 3*k; i < 3*k + 3; i++) 
            {
                for (int j = 3 * l; j < 3 * l + 3; j++) 
                {
                    if (igralnoPolje[i, j] == vrednost)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void Izpis() 
        {
            for (int i = 0; i < 9; i++) 
            {
                for (int j = 0; j < 9; j++) 
                {
                    if (igralnoPolje[i, j] == 0)
                    {
                        Console.Write(". ");
                    }
                    else if (!lahkoSpremenim[i, j]) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(igralnoPolje[i, j] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(igralnoPolje[i, j] + " ");
                    }
                    if (j == 2 || j == 5) 
                    {
                        Console.Write("| ");
                    }
                }
                Console.WriteLine();

                if (i == 2 || i == 5) 
                {
                    Console.WriteLine("---------------------");
                }
            }
        }
    }
}
