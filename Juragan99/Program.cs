using static System.Console;
using System.Globalization;
using Juragan99;

/*SUV su1 = new SUV("D 1001 UM", 2015,100_000, 600_000);
SUV su2 = new SUV("D 1002 UM",2019,500_000,100_000);

WriteLine($"Total Revenue SUV : {Vehicle.totalRV}");


Taxi ta1 = new Taxi("D 88 UK", 2018, 5, 4500, 40, 10_000);
Taxi ta2 = new Taxi("D 89 UK",2018,10,4500,100,10_000);



Angkot an1 = new Angkot("D 55 UJ", 2016, 4500, 35);
Angkot an2 = new Angkot("D 55 UK",2015,4500,40);
List<Vehicle> listEmps = new List<Vehicle> { su1 ,su2, ta1 ,ta2, an1 ,an2};

foreach (var item in listEmps)
{
    WriteLine(item.ToString());
    WriteLine();
}
*/
IVehicle veInf = new VehicleImpl();
var listOfEmps = veInf.InitDataVehicle();
veInf.ShowList(ref listOfEmps);

WriteLine("======TOTAL VEHICLE BY TYPE======");
var veh = veInf.GetTotalVehiclesByType(listOfEmps);
veInf.ShowDictionary(ref veh);

WriteLine("======TOTAL REVENUE BY TYPE======");
var reh = veInf.GetTotalRevenueByType(listOfEmps);
veInf.ShowDictionaryRevenue(ref reh);

WriteLine("============Find Revenue By Range=============");
var empsRange = veInf.FindRevenueByRange(listOfEmps, 500_000, 600_000);
veInf.ShowList(ref empsRange);

ReadLine();