using System;
/*Definirajte klasu Neboder sa sljedećim članicama:
a. privatne varijable:
i. visina,
ii. brojKatova
b. svojstva:
i. Visina koje će vraćati i definirati visinu nebodera.
ii. BrojKatova koje će vraćati i definirati broj katova.
Definirajte objekt Tower tipa Neboder s visinom od 200 m, postavite vrijednost broja
katova na 100, povećajte visinu za 10 m, povećajte broj katova za 1, te pomoću
ToString() metode ispišite podatke o neboderu te prosječnu visinu kata.*/
namespace Zadatak_3_
{
    class Neboder
    {
        private int visina;
        private int brojkatova;

        public Neboder(int avisina, int abrojkatova)
        {
            Visina = avisina;
            Brojkatova = abrojkatova;
        }
        public override string ToString()
        {
            return "prosjecna visina kata je "+Visina/Brojkatova+" m";
        }
        public int Brojkatova { get => brojkatova; set => brojkatova = value; }
public int Visina { get => visina; set => visina = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder(200, 100);
            Tower.Brojkatova = Tower.Brojkatova + 1;
            Tower.Visina = Tower.Visina + 10;
            Console.WriteLine("Neboder je visok "+Tower.Visina + " metara i ima " + Tower.Brojkatova + " katova, a " + Tower.ToString());
            Console.ReadKey();
        }
    }
}
