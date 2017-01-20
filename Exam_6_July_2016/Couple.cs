﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_6_July_2016
{
    abstract public class Couple : HouseHold
    {
        private decimal tvCost;
        private decimal fridgeCost;

        protected Couple(int numberOfRooms, decimal roomElectricity, decimal income, decimal tvCost, decimal fridgeCost)
            : base(income, numberOfRooms, roomElectricity)
        {
            this.tvCost = tvCost;
            this.fridgeCost = fridgeCost;
        }

        public override decimal Consumption
        {
            get
            {
                return this.tvCost + this.fridgeCost + base.Consumption;
            }
        }

        public override int Population
        {
            get
            {
                return 1 + base.Population;
            }
        }
    }
}