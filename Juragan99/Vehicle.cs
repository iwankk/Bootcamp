using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juragan99
{
    internal class Vehicle
    {
        private string noPolId;
        private int tahun;
        private string type;
        public decimal totalRevenue;


        public static decimal totalRV = 0M;
        public Vehicle(string noPolId, int tahun)
        {
            this.noPolId = noPolId;
            this.tahun = tahun;
        }

        /*public Vehicle(string noPolId, int tahun, string type) : (noPolId, tahun, type)
        {
            this.type = type;
        }*/


        public string NoPolId { get => noPolId; set => noPolId = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }

        public override string? ToString()
        {
            return $"Vehicle = {this.noPolId} | {this.tahun} | {this.type}";
        }


    }
}
