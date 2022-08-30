using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juragan99
{
    internal class VehicleImpl : IVehicle
    {
        public List<Vehicle> FindRevenueByRange(List<Vehicle> list, decimal startFrom, decimal endTo)
        {
            var empRange = new List<Vehicle>();
            foreach (var item in list)
            {
                if (item.totalRevenue >= startFrom && item.totalRevenue <= endTo)
                {
                    empRange.Add(item);
                }
            }
            return empRange;
        }

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Vehicle> list)
        {
            var TR = new Dictionary<string, decimal>();

            decimal SumSV = 0;
            decimal SumTaxi = 0;
            decimal SumAngkot = 0;
            foreach (var item in list.OfType<Vehicle>())
            {
                if (item.Type == "SUV")
                {
                    SumSV += item.totalRevenue;
                }
                else if (item.Type == "Taxi")
                {
                    SumTaxi += item.totalRevenue;
                }
                else if (item.Type == "Angkot")
                {
                    SumAngkot += item.totalRevenue;
                }
            }
            TR.Add("SUV", SumSV);
            TR.Add("Taxi", SumTaxi);
            TR.Add("Angkot", SumAngkot);
            return TR;   

        }

        public Dictionary<string, int> GetTotalVehiclesByType(List<Vehicle> list)
        {
            var VC = new Dictionary<string, int>();

            var SV = 0;
            var Taxi = 0;
            var Angkot = 0;
            //throw new NotImplementedException();
            foreach (var item in list.OfType<Vehicle>())
            {
                if (item.Type == "SUV")
                {
                    SV++;
                }
                else if (item.Type == "Taxi")
                {
                    Taxi++;
                }
                else if(item.Type == "Angkot")
                {
                    Angkot++;
                }
            }
            VC.Add("SUV", SV);
            VC.Add("Taxi", Taxi);
            VC.Add("Angkot", Angkot);
            return VC;
        }

        public List<Vehicle> InitDataVehicle()
        {
            //throw new NotImplementedException();
            SUV su1 = new SUV("D 1001 UM", 2015, 500_000, 100_000);
            SUV su2 = new SUV("D 1002 UM", 2019, 500_000, 100_000);
            Taxi ta1 = new Taxi("D 88 UK", 2018, 5, 4500, 40, 10_000);
            Taxi ta2 = new Taxi("D 89 UK", 2018, 10, 4500, 100, 10_000);
            Angkot an1 = new Angkot("D 55 UJ", 2016, 4500, 35);
            Angkot an2 = new Angkot("D 55 UK", 2015, 4500, 40);
      
            return new List<Vehicle> { su1, su2, ta1, ta2 ,an1,an2};
        }

        public void ShowDictionary(ref Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }

        public void ShowDictionaryRevenue(ref Dictionary<string, decimal> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }


    }
}
