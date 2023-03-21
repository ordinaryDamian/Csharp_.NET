using System.Globalization;
// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace Program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Damián Nadžady");
            //Console.WriteLine("Sem zadaj svoje meno: ");
            //// STDIN
            //string meno = Console.ReadLine(); //vracia string vždy aj ked by mal var pred
            ////STDOUT
            //Console.WriteLine("Zadal si toto: " + meno);
            //Console.WriteLine("tu máś priklad aby ti nebolo smutno:");

            //Console.Write("3+3+3= ");
            //var vysledok = Console.ReadLine();
            //Console.WriteLine("Je toto tvoj výsledok: " + vysledok);
            //Console.WriteLine(meno + " " + vysledok);
            //Console.WriteLine("Toto si zatial napisal šikulka");

            //int scopevariable;

            //if (1 == 1)
            //{
            //    scopevariable = 10;
            //    Console.WriteLine(scopevariable);  
            //}
            //Console.WriteLine(scopevariable); //premmenna je v scope hore a zapameta si hodnoru v pameti

            //Console.Write("3+3+3= ");
            //var vysledok = Console.ReadLine();
            //int IntVysledok = Convert.ToInt32(vysledok);

            //Console.WriteLine(IntVysledok.GetType());
            //ak viac podmienok v if je platných tak sa vykona iba prva


            //Pretyp a if, elseif
            //Console.Write("Vytaj v autoškole ");
            //Console.Write("Otázočka, koľko mas rokov? ");
            //var vek = Console.ReadLine();
            //var IntVek = Convert.ToInt32(vek);
            //Console.WriteLine(IntVek.GetType());
            //if (IntVek >= 18 && IntVek < 60)
            //{
            //    Console.Write("Pustíme ta do auta");
            //}
            //else
            //{
            //    Console.Write("nemáš tu čo robiť");
            //}

            ////switch
            //Console.Write("Otázočka, koľko mas rokov? ");
            //var Cislo = Console.ReadLine();
            //var IntCislo = Convert.ToInt32(Cislo);

            ////int day = 4; 
            //switch (IntCislo)
            //{
            //    case 1:
            //        Console.WriteLine("Pondelok");
            //        break;
            //    case 2:
            //        Console.WriteLine("Utorok");
            //        break;
            //    case 3:
            //        Console.WriteLine("Streda");
            //        break;
            //    case 4:
            //        Console.WriteLine("štvrtok");
            //        break;
            //    case 5:
            //        Console.WriteLine("piatok");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sobota");
            //        break;
            //    case 7:
            //        Console.WriteLine("Nedela");
            //        break;
            //    default: 
            //        Console.WriteLine("zla hodnota z rozsahu 1-7");
            //        break;
            //}
            // V case musi byt vzdy len hodnota
            // pomoocu switch case vieme urobit porovnanie len na rovnost (nevieme pouzit mensie ako a pod.)
            // kazdy case musi mat aj break
            // miesto else piseme default


            //Podobne ako switch hore ale cez if a elseif
            //int day = 4;

            //if (day == 1)
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if (day == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //else if (day == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //else if (day == 4)
            //{
            //    Console.WriteLine("Thursday");
            //}
            //else if (day == 5)
            //{
            //    Console.WriteLine("Friday");
            //}
            //else if (day == 6)
            //{
            //    Console.WriteLine("Sunday");
            //}
            //else if (day == 7)
            //{
            //    Console.WriteLine("Sunday");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown");
            //}

            //int scopevariable;
            //if (1 == 1)
            //{
            //    scopevariable = 10;
            //    Console.WriteLine(scopevariable);
            //}
            //Console.WriteLine(scopevariable); //premmenna je v scope hore a zapameta si hodnoru v pameti

            //druhý typ writeline a premenných
            //string jedna = "basta";
            //string mudro = "mas problem";
            //Console.WriteLine("si dobrý lebo {0} a ak nie tak {1}", jedna, mudro);

            // int a;
            // a = 4;
            // a = 7;
            // int b, c;
            // b = a;
            // c = a + b;
            // a = a + 4;
            // if (a < b)
            // {
            //     Console.WriteLine("{0} {1} {2}", a, b, c);

            // }
            // else
            // {
            //     Console.WriteLine("{0} {1}", b, c);
            // }
            //Console.WriteLine("{0} {1} {2}",a,b,c);

            // Parse, premena z jedneho na iny variable
            // Console.WriteLine("Hello World");
            // string s = "56";
            // int a = int.Parse(s);
            // Console.WriteLine("{0}", a);

            // Console.WriteLine("Vitaj v kalkulačke");
            // Console.WriteLine("Zadaj svoju hodnotu: ");
            // float a = float.Parse(Console.ReadLine());
            // Console.WriteLine("Zadaj svoju druhú hodnotu: ");
            // float b = float.Parse(Console.ReadLine());
            // float sucet = a + b;
            // float rozdiel = a - b;
            // float sucin = a * b;
            // float podiel = a / b;
            // Console.WriteLine("Súčet " + sucet);
            // Console.WriteLine("Rozdiel " + rozdiel);
            // Console.WriteLine("Súčin " + sucin);
            // Console.WriteLine("Podiel " + podiel);
            // Console.WriteLine("Koniec aplikacie stlačením CTRL + C");

            //string text = "alecaumo";
            //Console.WriteLine(text.StartsWith("ale"));
            //Console.WriteLine(text.Contains("eca"));

            // Console.WriteLine("Napíš prvú premennú(cislo1): ");
            // var cislox = Console.ReadLine();
            // int cislo1 = Convert.ToInt32(cislox);
            // Console.WriteLine("Napíš druhú premennú(cislo2): ");
            // var cisloy = Console.ReadLine();
            // int cislo2 = Convert.ToInt32(cisloy);
            // Console.WriteLine("Napíš tretiu premennú(cislo3): ");
            // var cisloz = Console.ReadLine();
            // int cislo3 = Convert.ToInt32(cisloz);

            // if (cislo1 > cislo2 && cislo1 > cislo3)
            // {
            //     Console.WriteLine("cislo1 je naväčšie a ma hodnotu {0}", cislo1);
            // }
            // else if (cislo2 > cislo1 && cislo2 > cislo3)
            // {
            //     Console.WriteLine("cislo2 je naväčšie a ma hodnotu {0}", cislo2);
            // }
            // else
            // {
            //     Console.WriteLine("cislo3 je naväčšie a ma hodnotu {0}", cislo3);
            // }
            // Console.WriteLine("END");

            // int cisloxyz = cislo1 + cislo2 + cislo3;

            // Console.WriteLine("Súčet čísel je {0}", cisloxyz);

            // Console.WriteLine("Vlož Číslo: ");
            // int num = int.Parse(Console.ReadLine());

            // if (num >= 10 && num <= 20)
            // {
            //     Console.WriteLine("Číslo {0} sa nachádza v rozmedzí 10-20", num);
            // }
            // else
            // {
            //     if (num >= 30 && num <= 40)
            //     {
            //         Console.WriteLine("Číslo {0} sa nachádza v rozmedzí 30-40", num);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Číslo {0} sa nenachádza v žiadnom zo stanovený rozmedzí", num);
            //     }

            // }
            // int[] MozneOperacie = { 1, 2, 3, 4 };
            // int operacie;
            // bool rovnake = false;

            // Console.WriteLine("Napíš prvé čislo: ");
            // int A = int.Parse(Console.ReadLine());
            // Console.WriteLine("Napíš druhé čislo: ");
            // int B = int.Parse(Console.ReadLine());

            // Console.WriteLine("Napís čislo operácie ktorú chceš urobiť ");
            // Console.WriteLine("1 : sčítanie​");
            // Console.WriteLine("2 : odčítanie​​");
            // Console.WriteLine("3 : delenie​​");
            // Console.WriteLine("4 : násobenie​​");

            // while (true)
            // {

            //     operacie = int.Parse(Console.ReadLine());
            //     foreach (int num in MozneOperacie)
            //     {
            //         if (num == operacie)
            //         {
            //             rovnake = true;
            //             break; // exit the loop once a match is found
            //         }
            //     }
            //     if (rovnake)
            //     {
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Zdal si zlú hodnotu, skús znova.");
            //     }
            // }

            // switch (operacie)
            // {
            //     case 1:
            //         Console.WriteLine("{0} + {1} = {2}", A, B, A + B);
            //         break;
            //     case 2:
            //         Console.WriteLine("{0} - {1} = {2}", A, B, A - B);
            //         break;
            //     case 3:
            //         Console.WriteLine("{0} / {1} = {2}", A, B, A / B);
            //         break;
            //     case 4:
            //         Console.WriteLine("{0} * {1} = {2}", A, B, A * B);
            //         break;
            //     default:
            //         Console.WriteLine("Snať sa nestane");
            //         break;
            // }

            // int[] cisla = new int[5];
            // for (int i = 0; i < cisla.Length; i++)
            // {
            //     Console.WriteLine("napíš čislo");
            //     int z = int.Parse(Console.ReadLine());
            //     cisla[i] = z;

            // }
            // Console.WriteLine("Napisal si 5 čísel");
            // Console.WriteLine("čísla v poradi");
            // Array.Sort(cisla);
            // for (int i = 0; i < cisla.Length; i++)
            // {
            //     Console.WriteLine(cisla[i]);
            // }
            // Console.WriteLine("Opačné poradie");
            // Array.Reverse(cisla);
            // for (int i = 0; i < cisla.Length; i++)
            // {
            //     Console.WriteLine(cisla[i]);
            // }
            // Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", cisla[0], cisla[1], cisla[2], cisla[3], cisla[4], cisla[0] + cisla[1] + cisla[2] + cisla[3] + cisla[4]);

            string color = "red";
            Car myObj = new Car();
            Console.WriteLine(myObj.color);



        }
    }
}