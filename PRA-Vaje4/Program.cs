namespace PRA_Vaje4
{
    internal class Program
    {
        //public static int c = 10; // globalna spremenljivka
        static void Main(string[] args)
        {
            //int a = 5; // lokalna spremenljivka
            Console.WriteLine(Naloga1(2,4));
            char[] tabela = ['b', 'e', 's', 'e', 'd', 'a'];
            Console.WriteLine(Naloga3(tabela, 'a'));
            Console.WriteLine(Naloga5("To je nek niz!", 'e'));

            List<string> seznam1 = new List<string>() {"ananas", "banana", "avto", "avion", "klub" };
            List<string> seznam = Naloga7(seznam1, 'a');

            //string niz1 = "to je niz";
            string niz1 = "to je niz ";
            
            foreach (string niz in Naloga8(niz1)) 
            {
                Console.WriteLine(niz);
            }

            var par = Naloga9(seznam1);
            Console.WriteLine(par.Item1);
            Console.WriteLine(par.Item2);

            //Console.WriteLine(par.beseda);
            //Console.WriteLine(par.indeks);

            (string niz2, int stevilo) = Naloga9(seznam1);

        }

        // n-terice (dvojice, trojice, četvorke)
        // n-tuple
        public static (string, int) Naloga9(List<string> seznam) 
        {
            string beseda = ""; // trenutno najdaljšo besedo
            int indeks = -1;

            for (int i = 0; i < seznam.Count(); i++) 
            {
                if (beseda.Length < seznam[i].Length) 
                {
                    beseda = seznam[i];
                    indeks = i;
                }
            }

            return (beseda, indeks);
        }

        // naredimo svojo Split metodo za presledke
        public static List<string> Naloga8(string niz)
        {
            List<string> seznam = new List<string>();

            string beseda = "";
            foreach (char znak in niz) 
            {
                if (znak != ' ')
                {
                    beseda += znak;
                }
                else if(beseda != "")
                {
                    seznam.Add(beseda);
                    beseda = "";
                }
            }
            // "to je niz"
            // "to je niz "
            if (beseda != "")
            {
                seznam.Add(beseda);
            }

            return seznam;
        }

        public static List<string> Naloga7(List<string> seznam, char znak) 
        {
            List<string> novSeznam = new List<string>();

            for (int i = 0; i < seznam.Count(); i++) 
            {
                // seznam - tip List<string>
                // seznam[i] - tip string
                // seznam[i][0] - tip char
                if (seznam[i][0] == znak) 
                {
                    novSeznam.Add(seznam[i]);
                }
            }

            return novSeznam;
        }

        public static int Naloga5(string niz, char znak) 
        {
            int stPojavitev = 0;
            for (int i = 0; i < niz.Length; i++) 
            {
                if (niz[i] == znak) 
                {
                    stPojavitev++;
                }
            }
            return stPojavitev;
        }

        public static bool Naloga3(char[] tabela, char znak) 
        {
            for (int i = 0; i < tabela.Length; i++) 
            {
                if (tabela[i] == znak)
                {
                    return true;
                }
            }
            return false;
        }

        // določiloVidnosti določiloStatičnosti tipMetode ImeMetode(argumenti)
        public static int Naloga1(int a, int b) // argumenti 
        {
            int potenca = 1;
            for (int i = 1; i <= b; i++) 
            {
                potenca *= a;
            }
            return potenca;
        }

    }
}
