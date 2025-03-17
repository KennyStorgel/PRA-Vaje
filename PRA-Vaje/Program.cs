using System.Security.AccessControl;

namespace PRA_Vaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Naloga 1.2
            // Deklaracija spremenljivke
            // tip ime = vrednost;

            // Logični tipi
            bool spr1 = true; // false

            // Znakovni tipi
            char spr2 = '6';

            // Celoštevilski tipi
            int spr3 = 4; // 32 bitov
            int steviloVratAvtomobila = 4;
            // byte - 8 bitov
            // short - 16 bitov
            // long - 64 bitov
            long spr4 = 5L;

            // Decimalne tipe
            double spr5 = 5.1; // 64 bitov
            float spr6 = 4.3F; // 32 bitov
            decimal spr7 = 6.4M; // 128 bitov

            // Tip za zaporedje znakov. Ni osnovni tip, ampak je sklicni tip
            string niz = "To je niz!";

            // Naloga 1.3
            // Večvrstični komentarji
            /* To
             je 
             večvrstični
             komentar
             */

            // Naloga 1.4
            string znamka = "Audi";
            int steviloVrat = 5;
            int hitrost1;
            double hitrost2;
            string hitrost3; // z vključeno mersko enoto
            bool jeNov = true; // true - je nov oz. false - ni nov
            char jeNov2 = 'R'; // 'N' - nov, 'R' - rabljen
            string jeNov3 = "nov";

            // Naloga 1.5
            string ime = "IME";
            string priimek = "PRIIMEK";
            Console.WriteLine("Moje ime je: " + ime + " " + priimek);

            // Naloga 1.6
            char unicodeZnak = '\u0041';
            Console.WriteLine(unicodeZnak);
            string ime2 = "\u0049\u004D\u0045";
            Console.WriteLine(ime2);
            char znakI = '\u0049';
            char znakE = '\u0045';
            char znakM = '\u004D';
            Console.WriteLine(znakI + "" + znakM + "" + znakE);

            // Naloga 1.7
            string ulica = "Ulica in hisna stevilka";
            string posta = "Posta in postna stevilka";

            Console.WriteLine(ime + " " + priimek);
            Console.WriteLine(ulica);
            Console.WriteLine(posta);

            // Naloga 1.8
            Console.WriteLine(ime + " " + priimek + "\n" + ulica + "\n" + posta);
            //primer zakaj je več spremenljivk bolje kot manj
            string naslov = "Ime Priimek\nUlica\nPosta";
            string naslov2 = ime + " " + priimek + "\n" + ulica + "\n" + posta;
            Console.WriteLine(naslov);

            // Naloga 1.9 in 1.10
            int st1 = 5;
            int st2 = 3;
            Console.WriteLine(st1 + st2); // seštevanje
            Console.WriteLine(st1 - st2); // odštevanje
            Console.WriteLine(st1 * st2); // množenje
            Console.WriteLine(st1 / st2); // deljenje
            Console.WriteLine(st1 % st2); // ostanek pri deljenju

            // Operacije prednostno
            // 1) multiplikativne: *, /, % .. od leve proti desni
            // 2) aditivne: +, - .. od leve proti desni
            Console.WriteLine("Vsota: " + (st1 + st2));
            Console.WriteLine(st1 + st2 + " je vsota.");

            Console.WriteLine("Razlika: " + (st1 - st2));
            Console.WriteLine(st1 - st2 + " je razlika.");

            Console.WriteLine("Produkt: " + st1 * st2);
            Console.WriteLine(st1 * st2 + " je produkt.");

            // Naloga 1.11
            int stevilo = 5;
            stevilo = 2;
            // pristejmo 2 spremenljivki stevilo
            stevilo = stevilo + 2; // deluje za vse osnovne operacije
            stevilo += 2; // deluje za vse osnovne operacije
            stevilo /= 2;

            // za +1 in za -1
            stevilo++; // +1
            stevilo--; // -1
            Console.WriteLine("Stevilo je: " + stevilo);

            // Naloga 1.15 - c
            // Primerjalne operacije:
            // <, >, <=, >=, ==, !=
            // Logične operacije:
            // &&, ||
            int a = 3, b = 5, c = 8, d = 4;
            bool rezultat = a + d > c && b < c;
            Console.WriteLine(rezultat);
            // shift + stevilka
            // alt gr + črka Q = \, W = |, F = [, G = ], B = {, N = }

            // Zaporedje operacij glede na vrsto operacije
            // Aritmetične, Primerjalne, Logične
            // 1) aritmetične
            // 2) primerjalne
            // 3) logične

            // Naloga 1.16
            string niz1 = "Prvi";
            string niz2 = "Drugi";

            string temp = niz1;
            niz1 = niz2;
            niz2 = temp;


            // Naloga 2.1.1
            int celoStevilo = -2;
            if (celoStevilo % 2 == 0)
            {
                Console.WriteLine("Stevilo je sodo.");
            }
            else 
            {
                Console.WriteLine("Stevilo je liho.");
            }

            // Naloga 2.1.2
            int x = 5;
            int y = 10;
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }

            // Naloga 2.1.5
            x = -6;
            if (x > 0)
            {
                Console.WriteLine("Pozitivno");
            }
            else if (x < 0)
            {
                Console.WriteLine("Negativno");
            }
            else 
            {
                Console.WriteLine("Enako 0");
            }

            // Naloga 2.1.6
            x = 15;
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("Deljivo je z obema.");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("Deljivo je s 3.");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Deljivo je s 5.");
            }
            else 
            {
                Console.WriteLine("Ni deljivo z nobenim.");
            }


            // Ternarni operator

            // Naloga 2.1
            x = 5;
            // pogoj ? izraz1 : izraz2
            string sodoLiho = x % 2 == 0 ? "sodo" : "liho";
            Console.WriteLine(sodoLiho);

            // Naloga 2.2
            x = 10;
            y = -3;
            int min = x < y ? x : y;
            int max = x < y ? y : x;
            max = x > y ? x : y;

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            Console.WriteLine(min + " " + max);


            // Switch stavek

            // Naloga 2.3.1
            int starost = 18;

            switch (starost) 
            {
                case <= 17:
                    Console.WriteLine("NE");
                    break;
                default:
                    Console.WriteLine("DA");
                    break;
            }

            // Naloga 2.3.2
            x = 11;
            // v switch lahko damo: cela števila, bool, char, string
            switch (x % 2 == 0) 
            {
                case true:
                    Console.WriteLine("Sodo stevilo.");
                    break;
                case false:
                    Console.WriteLine("Liho stevilo.");
                    break;
            }

            // switch primer z nizi
            string odgovor = "Da";
            switch (odgovor) 
            {
                case "Nekaj": // odgovor == "Nekaj"
                    Console.WriteLine("Niz je enak Nekaj.");
                    break;
                case "DA": // odgovor == "DA"
                    Console.WriteLine("Pravilno.");
                    break;
                default:
                    Console.WriteLine("Povsem drugacen niz.");
                    break;
            }

            // Naloga 2.3.5
            double stevilo1 = 5.1;
            double stevilo2 = 1.2;
            //Console.WriteLine("Vnesi znak za operacijo.");
            //char operacija = Console.ReadLine()[0];
            char operacija = ' ';

            switch (operacija) 
            {
                case '+':
                    Console.WriteLine(stevilo1 + stevilo2);
                    break;
                case '-':
                    Console.WriteLine(stevilo1 - stevilo2);
                    break;
                case '*':
                    Console.WriteLine(stevilo1 * stevilo2);
                    break;
                case '/':
                    Console.WriteLine(stevilo1 / stevilo2);
                    break;
                case '%':
                    Console.WriteLine(stevilo1 % stevilo2);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }
    }
}
