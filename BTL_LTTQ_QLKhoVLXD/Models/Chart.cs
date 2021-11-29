using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    internal class Chart
    {
        public int Month { get; }
        public double Income { get; }
        public double Outcome { get; }
        public double Profit { get; }

        private Chart(int month, double income, double outcome, double profit)
        {
            Month = month;
            Income = income;
            Outcome = outcome;
            Profit = profit;
        }

        public static Chart FromData(DataRow data)
        {
            var month = Convert.ToInt32(data["month"]);
            var income = Convert.ToDouble(data["income"]);
            var outcome = Convert.ToDouble(data["outcome"]);
            var profit = Convert.ToDouble(data["profit"]);

            return new Chart(month, income, outcome, profit);
        }
    }
}
