using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programering1._1
{
    internal class Demonstration
    {
        public Demonstration()
        {
        }
        public void Upg1A()
        {
            Console.WriteLine("Hej, vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej " + namn + ", Varmt välkommen!");
            Console.WriteLine();
        }

        public void Upg1B()
        {
            float bredd = 9.6f;
            float höjd = 5.4f;
            float area;

            area = höjd * bredd / 2;
            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("bredd: " + bredd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();
        }

        public void Upg1C()
        {
            string höjd;
            string bredd;
            double area;

            Console.WriteLine("Vad är triangelns höjd? ");
            höjd = Console.ReadLine();
            Console.WriteLine("Vad är triangelns bredd? ");
            bredd = Console.ReadLine();

            double DecimalH = Convert.ToDouble(höjd);
            double DecimalB = Convert.ToDouble(bredd);
            
            area = DecimalH * DecimalB /2;

            Console.WriteLine("höjd: " + höjd);
            Console.WriteLine("bredd: " + bredd);
            Console.WriteLine("area: " + area);
            Console.WriteLine();
        }

        public void Upg1D()
        {
            string tal1;
            string tal2;

            Console.WriteLine("skriv in 2 tal(enter mellan talen):");
            tal1 = Console.ReadLine();
            tal2 = Console.ReadLine();
            
            int heltal1 = Convert.ToInt32(tal1);
            int heltal2 = Convert.ToInt32(tal2);
            int summa = heltal1 + heltal2;

            Console.WriteLine("Summan av " + tal1 + " och " + tal2 + " är " + summa);
            Console.WriteLine();
        }

        public void Upg2A()
        {
            string guess;

            Console.WriteLine("Gissa mitt favorittal:");
            guess = Console.ReadLine();

            if (guess == "3")
            {
                Console.WriteLine("Du gissade rätt");
                Console.WriteLine();
            } 

            else
            {
                Console.WriteLine("Du gissade fel!");
                Upg2A();
            }
        }

        public void Upg2B()
        {
            Random random = new Random();
            int tärning1;
            int tärning2;

            tärning1 = random.Next(1, 7);
            tärning2 = random.Next(1, 7);
            
            if (tärning1 == tärning2)
            {
                Console.WriteLine("vinst");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("förlust");
                Console.WriteLine();
            }
            

            
        }

        public void Upg3A()
        {
            int i = 0;

            while (i++ < 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void Upg3B()
        {
            int i = 0;
            int tal = 5;

            while (i++ < 6)
            {
                Console.WriteLine(tal);
                tal = tal + 3;
            }
            Console.WriteLine();
        }

        public void Upg3C()
        {
            int i = 11;

            while (i-- > 0)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void Upg4A()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void Upg4B()
        {
            int tal = 5;

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine(tal);
                tal = tal + 3;
            }
            Console.WriteLine();
        }

        public void Upg4C()
        {
            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public void Upg5A()
        {
            string guess;

            Console.WriteLine("Gissa på talet jag tänker på:");
            guess = Console.ReadLine();

            if (guess == "15")
            {
                Console.WriteLine("Du gissade rätt");
            }

            else
            {
                Console.WriteLine("Gissa igen");
                Upg5A();
            }
            Console.WriteLine();
        }

        public void Upg6A()
        {
            Random random = new Random();
            int tärning1;
            int tärning2;

            tärning1 = random.Next(1, 7);
            tärning2 = random.Next(1, 7);

            if (tärning1 == 6 && tärning2 == 6)
            {
                Console.WriteLine("StorVinst");               
            }
            else if (tärning1 == tärning2)
            {
                Console.WriteLine("Vinst");               
            }
            else
            {
                Console.WriteLine("förlust");
            }
            Console.WriteLine();
        }

        public void Upg7och8()
        {
            int[] list = { 3, 5, 7, 9, 11, 13 };
            int i = 0;
            foreach (int tal in list)
            {
                Console.Write(tal + ", ");
                list[i] = list[i] + 1;
                i++;
            }
            Console.WriteLine();
            foreach (int tal in list)
            {
                Console.Write(tal + ", ");
            }
            Console.WriteLine();
        }

        public void Upg9()
        {
            welcome();
            
            Console.WriteLine("Hur många tal ska du använda?");
            string antalInp = Console.ReadLine();
            int antal = Convert.ToInt32(antalInp);
            
            double[] talLista = numbers(antal);

            double summa = summera(talLista);
            Console.WriteLine("summan är " + summa);
        }

        public void welcome()
        {
            Console.WriteLine("välkommen agent X");
        }

        public double[] numbers(int antal)
        {
            double[] talLista = new double[antal];

            for (int i = 0; i < talLista.Length; i++)
            {
                Console.WriteLine("skriv in ett tal");
                string input = Console.ReadLine();
                double tal = Convert.ToDouble(input);
                talLista[i] = tal;
             
            }
            return talLista;
            
        }

        public double summera(double[] talLista)
        {
            double summa = 0;

            for (int i = 0; i < talLista.Length;i++)
            {
                summa += talLista[i];
            }
            return summa;
        }

        public void Upg10()
        {
            
            inputs();
        }

        public void inputs()
        {
            List<string> inköpsLista = new List<string>();
            string temp = "";
            Console.WriteLine("Vad är din första vara?,Skriv stop när du inte vill lägga till mer varor");
            temp = Console.ReadLine();
            while (temp != "stop")
            {
                inköpsLista.Add(temp);
                Console.WriteLine("vad vill du lägga till?");
                temp = Console.ReadLine();
            }
            tack(inköpsLista);

        }

        public void tack(List<string> inköpsLista)
        {
            foreach (string vara in inköpsLista)
            {
                Console.WriteLine("din inköpslista innehåller " + vara);
            }
        }
    }
}
