using static System.Console;
using Day05;

Person yuli = new Customer("Faiz", "Senpai", "senpai@gmail.com", new DateTime(1998, 4, 24), "121-001");
Customer widi = new Customer("Widi", "Dios", "Wios@gmail.com", new DateTime(1997, 12, 2), "121-002");
Customer wido = new Customer("Wido", "Dios", "Wios12@gmail.com", new DateTime(1999, 11, 2), "121-003");

var listOfCustomer = new List<Person> { yuli, widi, wido };

var incomeYuli = new Dictionary<string, decimal>
{
    {"Kontrakan", 10_000_000 },
    {"Toko",100_000_000 },
};

//yuli.TotalIncome(incomeYuli);
yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);

var incomeWidi = new Dictionary<string, decimal>
{
    {"Koskosan",20_000_000 },
    {"Jual Online",15_000_000 },
};

widi.TotalRevenue = widi.TotalIncome(incomeWidi);
var incomeWido = new Dictionary<string, decimal>
{
    {"Warung Remang",500_000_000 },
    {"Rental Mobil",100_000_000 },
};

wido.TotalRevenue = wido.TotalIncome(incomeWido);

//yuli.TotalIncome()
foreach (var item in listOfCustomer)
{
    WriteLine(item.ToString());
}
//LinQ Call
//LinQ.IntroLinq();

WriteLine("------- List Range >= 50.000.0000 -------");
var listRange = listOfCustomer.Where(C => C.TotalRevenue >= 50_000_000).ToList();
foreach (var item in listRange)
{
    WriteLine(item.ToString());
}

WriteLine("------- Revenue Minimum -------");
var listMin = listOfCustomer.Min(C => C.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMin}");


WriteLine("------- Revenue Minimum -------");
var listMax = listOfCustomer.Max(C => C.TotalRevenue);
WriteLine($"Cust Max Revenue : {listMax}");

var listLessThanMax = listOfCustomer.Where(C => C.TotalRevenue < listMax);
WriteLine("------- Revenue Lower Than Max -------");
foreach (var item in listLessThanMax)
{
    WriteLine(item.ToString());
}

WriteLine("------- Select -------");
var query = listOfCustomer.Select(cust =>
    new
    {
        FullName = cust.FirstName + " " + cust.LastName,
        Email = cust.Email,
        TotalRevenue = cust.TotalRevenue
    }
);

foreach (var item in query)
{
    WriteLine(item);
}

