using System;
using System.Collections.Generic;
namespace TokaTesti
{
    class Program
    {
        public class Peli_tila {
            public string pää_teksti;
            public string vaihtoehto_1;
            public string vaihtoehto_2;
            public string vaihtoehto_3;
            public bool peli_loppu;
            public bool peli_voitettu;
            public string[] siirtymätilat;

            public string näytä_tila()
            {
                Console.WriteLine(pää_teksti);
                Console.WriteLine("1."+vaihtoehto_1);
                Console.WriteLine("2."+vaihtoehto_2);
                Console.WriteLine("3."+vaihtoehto_3);
                Console.Write("Mitä teet:");
                //               int valinta = Console.ReadKey();
                // Luetaan käyttäjältä numero ja muutetaan se int:iksi
                int valinta = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Write("\n");
                Console.WriteLine("DEBUG-koodia: MUUTTUJAT");
                Console.WriteLine("valinta = " + valinta);
                  Console.WriteLine("siirtymätilat[0] = "+ siirtymätilat[0]);
                    Console.WriteLine("siirtymätilat[1] = " +siirtymätilat[1]);
                    Console.WriteLine("siirtymätilat[2] = " +siirtymätilat[2]);
                Console.WriteLine("DEBUG-loppuu");

                // Tehtävä:
                // Laita ohjelma toimimaan siten, että palautetaan aina
                // oikea arvo muuttujasta siirtymätilat
                // hyödynnä muuttujia valinta ja siirtymätilat
                return siirtymätilat[valinta - 1];
            }
            public Peli_tila(string pt,string v1,string v2,string v3,bool pl,bool pv,string[] st)
            {
                pää_teksti = pt;
                vaihtoehto_1 = v1;
                vaihtoehto_2 = v2;
                vaihtoehto_3 = v3;
                peli_loppu = pl;
                peli_voitettu = pv;
                siirtymätilat = st;

            }
        } // Luokka Peli_tila loppuu
        static void Main(string[] args)
        {
            string[] arvoja = new[] { "eka", "toka", "kolmas" };
            Console.WriteLine(arvoja[2]);
            int valinta = 1;
            Console.WriteLine(arvoja[valinta]);



     //       Dictionary<string, Peli_tila> peli = new Dictionary<string, Peli_tila>();

            Peli_tila alku = new Peli_tila(
                "Olet vankisellissä odottamassa häpeäpaalua. Mitä teet?",
                "Huuda vartioita",
                "Tutki sellin läpikotaisin",
                "Vaivu epätoivoon",
                false,
                false,
                new[] {  "vartijat", "tutkiselli", "epätoivo"  }
                );
            
            // Luo vartijat -kohdasta instanssi
            Peli_tila vartijat = new Peli_tila(
                "Huudat vartioita.Yksi tulee.",
                 "Väität vartiajalle löytäneesi sellistä kultaharkon ja pyydät tätä sisään.",
                 "Alat kiroilemaan vartiajalle.",
                 "", 
                 false, 
                 false,
                 new[] {"","",""}
                 );

            string seuraava_tila;
            seuraava_tila = alku.näytä_tila();
            Console.WriteLine("Seuraavaksi pitäisi siirtyä tilaan:" + seuraava_tila);
                        
     //       peli.Add("alku", alku);
     //       peli.Add("vartijat", vartijat);
            /*
            vartijat.näytä_tila();
            // (Vartijat)
            string V_pää_teksti = "Huudat vartioita.Yksi tulee.";
            string V_vaihtoehto_1 = "Väität vartiajalle löytäneesi sellistä kultaharkon ja pyydät tätä sisään.";
            string V_vaihtoehto_2 = "Alat kiroilemaan vartiajalle.";
            string V_vaihtoehto_3 = "";
            bool V_peli_loppu = false;
            bool V_peli_voitettu = false;
            Console.WriteLine(alku.pää_teksti);
            // (Alku)
            string A_pää_teksti = "Olet vankisellissä odottamassa häpeäpaalua. Mitä teet?";
            string A_vaihtoehto_1 = "Huuda vartioita";
            string A_vaihtoehto_2 = "Tutki sellin läpikotaisin";
            string A_vaihtoehto_3 = "Vaivu epätoivoon";
            bool A_peli_loppu = false;
            bool A_peli_voitettu = false;
            
            // MINIHAASTE 
 
            
            // (Kultaharkko)
            string K_pää_teksti = "* Vartija tulee sisään ja kääntyy katsomaan osoittamaasi suuntaa.Kolkkaat hänet. ryöstät hänen vaatteet ja pakenet!";
            string K_vaihtoehto_1 = "";
            string K_vaihtoehto_2 = "";
            string K_vaihtoehto_3 = "";
            bool K_peli_loppu = true;
            bool K_peli_voitettu = true;
//            *(kultaharkko)

            //            Vankilapako
            /* (Alku)
             * Olet vankisellissä odottamassa kuolemantuomioita. Mitä teet? 
             * /
             * 1. Huuda vartioita -> Ohjaa Vartiojoihin
             * 2. Tutki sellin läpikotaisin
             * 3. Vaivu epätoivoon 
             * /
             * 
             * (Vartijat)
             * Huudat vartioita. Yksi tulee. 
             * 1. Väität vartiajalle löytäneesi sellistä kultaharkon ja pyydät tätä sisään.
             * 2. Alat kiroilemaan vartiajalle.
             * 
             * (kultaharkko)
             * Vartija tulee sisään ja kääntyy katsomaan osoittamaasi suuntaa. Kolkkaat hänet.
             * ryöstät hänen vaatteet ja pakenet!
             * PELI VOITETTU
             * 
             * (Kiroilu)
             * Vartija nauraa sinulle ja lähtee pois. 
             * 1. Vaivu epätoivoon
             * 
             * (Epätoivo)
             * Aamu koittaa ja loppu tulee.
             * PELI HÄVITTY
             * 
             * (tutki selli)
             * Diktaattori ei ole pistänyt rahaa vankilaan, kalteri lähtee helposti irti. Pääset pakoon.
             * PELI VOITETTU
             */
              // Testatkaa painaa Ctrl + F5

            }
            }
            }
