﻿using System;

namespace cs01_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Teorija
            //Console.WriteLine("cs01_paskaita");
            //Console.WriteLine($"4 + 5 = {4 + 5}");

            //int age = 15;
            //string myName = "Vilmantas";
            //Console.WriteLine("Stringas: Koks Jūsų vardas: ");
            //string myName = Console.ReadLine();

            //Console.WriteLine("Integeris: Koks Jūsų amžius: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.ForegroundColor = ConsoleColor.DarkRed; // <-- paspalvoju consolės tekstą

            //Console.WriteLine($"Mano vardas yra {myName} ir man yra {age} metų");
            #endregion

            //Assignment1(); // <-- į šituos daikčiukus kolkas irgi dėmesio nekreipkite, mokoma bus truputėlį vėliau;
            //Assignment2(); //     bet jeigu trumai, tai aš čia atsikomentuodamas eilutę pasileidžiu tam tikrą funkciją
            //Assignment3();
            //Assignment4();
            //Assignment5();
            //Assignment6();
            //Assignment7();
            //Assignment8();
        }

        public static void Assignment1()           // <-- į šitą vietą kolkas nekreipkite dėmesio, 
        {                                          //     čia aš tiesiog izoliuoju kodą, sekančias eilutes tiesiog apsirašykite main metode
            // Parašyti programą, kuri klausia vartotojo jo mėgstamos spalvos.
            // Programa visada turi atsakyti: mano irgi

            // Tai iš esmės užduotyje mus reikės vartotojo įvedamo 1 stringo, tai nuo to ir pradedame:
            string color; // <-- inicijuojame string tipo kintamąjį
            // tuomet sakome konsole skaityk įvestį
            color = Console.ReadLine(); // <-- čia konsolė prie anksčiau inicijuoto kintamojo priskiria reikšmę, kurią įvesite konsolėje
            //tuomet nurodome, kad kompiuteris imtų mūsų stringo reikšmę ir spausdintų ją tarp kitų žodžių:
            Console.WriteLine($"Mano irgi {color}"); // <-- riestiniuose sklaisutuose esantis kintamasis keičiasi priklausomai nuo įvesties
                                                     //     plačiau apie tai, tiesiog google "string interpolation".
        }

        public static void Assignment2()
        {
            //Parašyti programą, kuris išveda dviejų skaičių 17 ir 23 sumą

            int number1 = 17; // <-- elementariai inicijuojame sau kintamąjį
            int number2 = 23;
            //tuomet sakome konsolei spausdink sumą – čia paprasta kaip skaičiuotuve:
            Console.WriteLine($"Bus sudedami du skaičiai: {number1} + {number2}"); // <-- atkreipkite dėmesį, kad jeigu "+" yra ne riestiniuose skliaustuose, kaip
            Console.WriteLine($"Skaičių suma yra {number1 + number2}");            //     ankstesnėje eilutėje, jis neatlieka jokio veiksmo
        }                                                                          //     tik riestiniuose sklaustuose esantys operatoriai atlieka veiksmą.

        public static void Assignment3()
        {
            // Parašyti programą, kuris padalina 24 iš 5

            // Iš esmės tai yra tas pats kaip ir ankstesnėje užduotyje, tik operatorių iš "+" pakeičiame į "/"
            // Todėl, kad neperrašinėti, padarysiu kitu būdu tą patį ir kad vartotojas skaičius įvestų
            Console.WriteLine("Vartotojau įvesk 2 skaičius: "); // <-- consolė parašo vartotojui tekstą
            // Čia mes sukuriame du kintamuosius, kurių vertes įves vartotojas:
            int number3 = int.Parse(Console.ReadLine()); // <-- čia mes naudojame parse funckciją. Ką tai reiškia?
            int number4 = int.Parse(Console.ReadLine()); //     by default consolė priima stringą, parse funckija čia tiesiog pasako, kad čia yra įvedamas skaičius
            // Tuomet konsolė, kaip ir ankstesnėje užduotyje spausdina, ką jei nurodome; šį kartą optimalesniu būdu
            // Vienoje eilutėje nurodoma ir kokie skaičiai sudedami ir jų suma:
            Console.WriteLine($"Vartotojas dalybai įvedė skaičius {number3} ir {number4}, padalinus juos gauname: {number3 / number4}");
        }
        public static void Assignment4()
        {
            // Parašyti programą, kuri išveda rezultatą
            // -6+3*5
            // (13-2) * 7
            // (5+-2) + (20/10)

            // Užduotis yra analogiška ankstesnėms savo logika, todėl sprendimą aprašau trumpai:
            Console.WriteLine($"Lygtis: {-6} + {3} * {5} = {-6 + 3 * 5}");
            Console.WriteLine($"Lygtis: ({13} - {2}) * {7} = {(13 - 2) * 7}");
            Console.WriteLine($"Lygtis: ({5} + {-2}) + ({20} / {10}) = {(5 + -2) + (20 / 10)}");
            // Šita sprendimą galima buvo aprašyti ir paprasčiau, kad spausdintų tik atsakymus:
            Console.WriteLine($"{ -6 + 3 * 5}");
            Console.WriteLine($"{(13 - 2) * 7}");
            Console.WriteLine($"{(5 + -2) + (20 / 10)}");
            // Iš esmės pirma dalis yra tik dėl grožio, kad matytųsi veiksmai, ne tik atsakymas konsolėje.
            // Čia pavyzdžiui galime, nors užduotis ir neprašo pabandyti įsivesti patys sau skaičius apibrėžtai lygčiai, pavyzdžiui:
            Console.WriteLine("Įveskite skaičius X, Y, Z, kurie bus skaičiuojami pagal lygti X + Y * Z");
            // Čia inicijuojame vienu metu tris kintamuosius
            int X, Y, Z;
            //Tuomet konsolėje rašome vartotojui – įvesk X kintamąjį:
            Console.WriteLine("Įveskite X");
            X = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite Y");
            Y = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite Z");
            Z = int.Parse(Console.ReadLine());

            // Tuomet konsolėje dėl grožio pakartojame, kokia yra vartotojo įvestis:
            Console.WriteLine($"Vartotojo įvestis yra X = {X}, Y = {Y}, Z = {Z}, ");
            // Tuomet dėl grožio parašome kaip atrodys lygtis su kintamaisiais"
            Console.WriteLine($"Lygtis su kintamaisiais yra {X} + {Y} * {Z}");
            // Ir tuomet kaip ankstesnėse užduotyse aprašome paduodame atsakymą:
            Console.WriteLine($"Atsakymas yra {X + Y * Z}");
        }

        public static void Assignment5()
        {
            // Parašyti programa kuri išveda dviejų vartotojo įvedamų skaičių
            // sumą, skirtumą, sandaugą ir dalybą

            Console.WriteLine("Vartotojau įvesk du skaitmenis");
            Console.WriteLine("kurie bus sudėti, atimti, padauginti ir padalinti"); // <-- čia atskiros dvi eilutės atliekamas tik tam,
                                                                                    //     kad consolė spausdintų kitoje eilutėje
            int num1 = int.Parse(Console.ReadLine()); // <-- čia kaip matote, skirtingai nei anksčiau inicializuojami kintamieji kitaip
            int num2 = int.Parse(Console.ReadLine()); //     t. y. vienoje eil. ir inicializuojami ir iškarto priskiriama reikšmę, kurią įves vartotojas

            Console.WriteLine("Rezultatas sudėjus: ");
            Console.WriteLine(num1 + num2);             // <-- Čia kaip matote matematinę operaciją galima daryti ir be interpoliacijos
            Console.WriteLine("Rezultatas atėmus: ");   //     tiesiog "cw+tab+tab" ir vedate kintamųjų vardus (num1 num2) ir operatorių (+ - * /) tarp jų"
            Console.WriteLine(num1 - num2);
            Console.WriteLine("Rezultatas padauginus: ");
            Console.WriteLine(num1 * num2);
            Console.WriteLine("Rezultatas padalinus: ");
            Console.WriteLine(num1 / num2);
        }

        public static void Assignment6()
        {
            // Parašyti programą, kuri prašo
            // vartotojo skaičiaus įvesties ir išveda
            // įvesto skaičiau daugybos lentelę

            // šiaip, kaip antroje paskaitoje ir minėta, daugybos lentelei reikia ciklo,
            // panaudojimo. Aprašau sprendimą, bet šitą dalyką dar tik dėstys

            Console.WriteLine("Vartotojau įveskite skaičių");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Skaičiaus {num3} daugybos lentelė");
            for (int i = 1; i < 11; i++) // <-- Čia yra ciklo aprašymas, bet jeigu noride susipažinti dabar google'inkite.
            {
                Console.WriteLine($"{num3} * {i} = {num3 * i}");
            }
            // Va čia neblogai paaiškina "for", "for each" ir "while loop'ą": https://www.youtube.com/watch?v=fhW5pekSBaU, jeigu nekantrautumėte.
        }

        public static void Assignment7()
        {
            // Parašyti programą, kuri prašo vartotojo įvesti 4 skaičius ir išveda jų vidurkį

            // Čia toks pats uždavinys kaip ir nakstesni, tik skiriasi operatoriai ir lygitis
            Console.WriteLine("Įveskite 4 skaičius, programa išves jų vidurkį");
            double a = double.Parse(Console.ReadLine()); // <-- tik atkreipkite dėmesį, kad naudojame jau ne int, o double (arba galima float), nes int neturi decimal point
            double b = double.Parse(Console.ReadLine()); //     ir atsakymas būtų apvalinamas, o double turi decimal point (yra tikslesnis mūsų atveju)
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            // rezultato išvestį galima apsirašyti labai paprastai:
            Console.WriteLine((a+b+c+d)/4);
            // arba gražiau su string interpoliacija:
            Console.WriteLine($"({a} + {b} + {c} + {d}) / 4 = {(a + b + c + d) / 4}");
        }

        public static void Assignment8()
        {
            // Parašyti programą, kuri prašo įvesti 3 skaičius(A, B, C)
            // ir išveda(A + B) * C, bei A * C + B * C

            // Šios užduoties sprendimo nebeaprašau, nes tokį netyčia aprašiau Assignment4
            // bet parašysiu trumpiausiu įmanomu būdu
            Console.WriteLine("Enter 3 numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"(A + B) * C = {(a + b) * c}");
            Console.WriteLine($"A * C + B * C = {a * c + b * c}");
        }
    }
}

