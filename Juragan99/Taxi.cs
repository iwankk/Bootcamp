using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juragan99
{
    internal class Taxi : Vehicle
    {
        private int order, orderPerKM, totalKM;
        private decimal bonus;
        public Taxi(string noPolId, int tahun, int order, int orderPerKM, int totalKM, decimal bonus) : base(noPolId, tahun)
        {
            this.order = order;
            this.orderPerKM = orderPerKM;
            this.totalKM = totalKM;
            this.bonus = bonus;
            Type = "Taxi";
            totalRevenue = (order*bonus) + (orderPerKM*totalKM);
        }

        public int Order { get => order; set => order = value; }
        public int OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public int TotalKM { get => totalKM; set => totalKM = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Order = {order} | OrderPerKM : {orderPerKM}| Total KM : {totalKM} |bonus : {bonus.ToString("C", new CultureInfo("Id-ID"))}|total Revenue :{totalRevenue.ToString("C", new CultureInfo("Id-ID"))}";
        }
    }
}
