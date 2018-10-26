using System;
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

            public void näytä_tila()
            {
                Console.WriteLine(pää_teksti);
                Console.WriteLine("1."+vaihtoehto_1);
                Console.WriteLine("2."+vaihtoehto_2);
                Console.WriteLine("3."+vaihtoehto_3);
            }
            public Peli_tila(string pt,string v1,string v2,string v3,bool pl,bool pv)
            {
                pää_teksti = pt;
                vaihtoehto_1 = v1;
                vaihtoehto_2 = v2;
                vaihtoehto_3 = v3;
                peli_loppu = pl;
                peli_voitettu = pv;
            }
        } // Luokka Peli_tila loppuu
         static void Main(string[] args)
        {
            Peli_tila alku = new Peli_tila("Olet vankisellissä odottamassa häpeäpaalua. Mitä teet?",
                                            "Huuda vartioita", "Tutki sellin läpikotaisin",
                                            "Vaivu epätoivoon", false, false);
            alku.näytä_tila();
            // Luo vartijat -kohdasta instanssi
            Peli_tila vartijat = new Peli_tila("Huudat vartioita.Yksi tulee.",
                                            "Väität vartiajalle löytäneesi sellistä kultaharkon ja pyydät tätä sisään.",
                                            "Alat kiroilemaan vartiajalle.","", false, false);

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
