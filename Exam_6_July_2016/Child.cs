using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_6_July_2016
{
    public class Child
    {
        decimal[] consumption;

        public Child(decimal[] consumption)
        {
            this.consumption = consumption;
        }

        public decimal GetTotalConsumption()
        {
            return this.consumption.Sum();
        }
    }
}