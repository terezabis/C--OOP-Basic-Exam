using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_July_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<HouseHold> kermen = new List<HouseHold>();
            int counter = 0;

            while (input != "Democracy")
            {
                counter++;
                try
                {
                    HouseHold entity = HouseHoldFactury.CreateHouseHold(input);
                    kermen.Add(entity);
                }
                catch (Exception)
                {

                }

                if (counter % 3 == 0)
                {
                    kermen.ForEach(x => x.GetIncome());

                    //foreach (var household in kermen)
                    //{
                    //    household.GetIncome();
                    //}
                }

                if (input == "EVN bill")
                {
                    kermen.RemoveAll(x => !x.CanPayBills());
                    kermen.ForEach(x => x.PayBills());
                    //foreach (HouseHold household in kermen)
                    //{
                    //    if (household.CanPayBills())
                    //    {
                    //        household.PayBills();
                    //    }
                    //}
                }
                else if (input == "EVN")
                {
                    Console.WriteLine($"Total consumption: {kermen.Sum(x => x.Consumption)}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total population: {kermen.Sum(x => x.Population)}");
        }
    }
}
