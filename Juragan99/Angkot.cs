using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juragan99
{
    internal class Angkot : Vehicle
    {
        private int hargatiket, totalpen;
        public Angkot(string noPolId, int tahun, int hargatiket, int totalpen) : base(noPolId, tahun)
        {
            this.hargatiket = hargatiket;
            this.totalpen = totalpen;
            Type = "Angkot";
            totalRevenue = hargatiket * totalpen;
        }

        public int Hargatiket { get => hargatiket; set => hargatiket = value; }
        public int Totalpen { get => totalpen; set => totalpen = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Harga Tiket = {hargatiket} | Total Penumpang :" +
                $" {totalpen} | Total Revenue : {totalRevenue.ToString("C", new CultureInfo("Id-ID"))}";
        }
    }
}
