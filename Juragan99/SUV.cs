using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juragan99
{
    internal class SUV : Vehicle
    {
        private decimal sewa, supir;

        public SUV(string noPolId, int tahun, decimal sewa, decimal supir) : base(noPolId,tahun)
        {
            this.sewa = sewa;
            this.supir = supir;
            Type = "SUV";
            totalRevenue = sewa + supir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Supir { get => supir; set => supir = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Sewa = {this.sewa.ToString("C", new CultureInfo("Id-ID"))} | Supir : {this.supir.ToString("C", new CultureInfo("Id-ID"))}" +
                $"| Total Revenue : {this.totalRevenue.ToString("C", new CultureInfo("Id-ID"))}";
        }
    }

}
