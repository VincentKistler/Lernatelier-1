using System.ComponentModel.Design;

namespace Zahleraten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random zufallszahlengenerator = new Random();
            int geheimeZahl = zufallszahlengenerator.Next(1, 20);
            
            bool geraten = false;
            Console.WriteLine("Ich habe mir eine Zahl zwischen 1 und 20 ausgewählt, versuche diese zu erraten.");

            while (!geraten)
            {
                Console.Write("Dein Tipp: ");
                if (int.TryParse(Console.ReadLine(), out int tipp))
                {


                    if (tipp < geheimeZahl)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist größer.");
                    }
                    else if (tipp > geheimeZahl)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                    }
                    else
                    {
                        geraten = true;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl zwischen 1 und 100 ein.");
                }
            }

                    Console.WriteLine($"Glückwunsch! Du hast die geheime Zahl {geheimeZahl} erraten.");
                }
           }




















}
            
        
    

