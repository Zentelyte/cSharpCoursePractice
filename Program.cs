using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND
{
   
    class Program
    {

        static void Main()
        {
            
            const int FROM_NUMBER = -9;
            const int TO_NUMBER = 9;

            string inputString = "";
            int inputNumber = 0;

            Console.Write("Sveiki!");
            Console.ReadKey();
            while (inputString != " ")
            {
                Console.Write("\n(Enter SPACE to exit.)\nIveskite skaiciu:");
                inputString = Console.ReadLine();
                if (checkIfGoodNumber(inputString))
                {
                    Console.WriteLine("Skaicius teisingas!");
                    inputNumber = Convert.ToInt32(inputString);
                    if (checkIfNumberInRange(FROM_NUMBER, TO_NUMBER, inputNumber))
                    {
                        Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeNumberToText(inputNumber));
                    }
                    else
                    {
                        Console.WriteLine("Blogas skaicius {0}, prasau ivesti skaiciu reziuose: {1}..{2}", inputString, FROM_NUMBER, TO_NUMBER);
                    }
                }
                else
                {
                    Console.WriteLine("Ivesti duomenys:{0} nera skaicius!", inputString);
                }
            }

            Console.WriteLine("\nAciu uz demesi, viso gero.");
            Console.ReadKey();
        }

        // Cia nelabai supratau, ka ta bendra funkcija turi daryti

        static string changeNumberToText(int number)
        {
           // string atsakymas = Convert.ToString(number);
            return changeOnesToText(number);
        }

        static bool checkIfGoodNumber(string dataToCheck)
        {

            for (int i = 0; i < dataToCheck.Length; i++)
            {
                char simbolis = dataToCheck[i];
                switch (simbolis)
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                    case '-':
                        break;
                    default:
                        return false;
                }
            }
            return true;

        }

        private static bool checkIfNumberInRange(int fromNumber, int toNumber, int checkNumber)
        {
            if (checkNumber >= fromNumber && checkNumber <= toNumber)

            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static string changeOnesToText(int number)
        {
            //string[] SkZodziais = new string[] { "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni", "nulis", "minus" };
            //for (int i = 0; i < SkZodziais.Length; i++) { }

            // Bandziau su ciklu ir masyvu, bet nezinau, kaip testi... Ka aprasiau veikia, jeigu ivedu skaicius be minuso, su minusu nespausdina...
            string atsakymas = Convert.ToString(number);
            switch (atsakymas)
            {

                case "1":
                    return "vienas";
                case "2":
                    return "du";
                case "3":
                    return "trys";
                case "4":
                    return "keturi";
                case "5":
                    return "penki";
                case "6":
                    return "sesi";
                case "7":
                    return "septyni";
                case "8":
                    return "astuoni";
                case "9":
                    return "devyni";
                case "0":
                    return "nulis";
                case "-":
                    return "minus";
                default:
                    break;
            }
            return atsakymas;
        }
    }

}

       
