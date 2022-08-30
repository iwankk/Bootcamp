using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juragan99
{
    internal interface IVehicle
    {
        public List<Vehicle> InitDataVehicle();

        public void ShowList<T>(ref List<T> list);
        
        public Dictionary<string,int> GetTotalVehiclesByType(List<Vehicle> list);
        public void ShowDictionary(ref Dictionary<string, int> dict);

        public Dictionary<string,decimal> GetTotalRevenueByType(List<Vehicle> list);

        public void ShowDictionaryRevenue(ref Dictionary<string,decimal> dict);
 
        public List<Vehicle>FindRevenueByRange(List<Vehicle> list ,decimal startFrom , decimal endTo);
    
    }
}
