using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_room
{
    class Program
    {
        static void Main(string[] args)
        {
            string inptMonth = Console.ReadLine();
            int nightsRented = int.Parse(Console.ReadLine());

            double priceStudio, priceApartment;
            double discountStudio=0,
                   discountApartment=0;

            if(inptMonth=="May"||inptMonth=="October")
            {
                priceApartment = 65;
                priceStudio = 50;
                if (nightsRented > 7 && nightsRented <= 14) discountStudio = 5;
                else if (nightsRented > 14) discountStudio = 30;
            }
            else if (inptMonth == "June" || inptMonth == "September")
            {
                priceApartment = 68.70;
                priceStudio = 75.20;
                if (nightsRented > 14) discountStudio = 20;
            }
            else
            {
                priceApartment = 77;
                priceStudio = 76;      
            }

            if (nightsRented > 14) discountApartment = 10;

            double sumApartment = (priceApartment - priceApartment * discountApartment / 100) * nightsRented;
            double sumStudio = (priceStudio - priceStudio * discountStudio / 100) * nightsRented;

 
           Console.WriteLine("Apartment: {0:F2} lv.",sumApartment);
            Console.WriteLine("Studio: {0:F2} lv.",sumStudio);

        }
    }
}