using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_6_July_2016
{
    public abstract class HouseHold
    {
        private int numberOfRooms;
        private decimal roomElectricity;
        private decimal income; // calaries
        private decimal balance; //for bills

        protected HouseHold(decimal income, int numberOfRooms, decimal roomElectricity)
        {
            this.balance = 0;
            this.income = income;
            this.numberOfRooms = numberOfRooms;
            this.roomElectricity = roomElectricity;
        }

        public virtual int Population
        {
            get { return 1; }
        }

        public virtual decimal Consumption
        {
            get { return this.roomElectricity * this.numberOfRooms; }
        }

        public void GetIncome() // pay selaries
        {
            this.balance += this.income;
        }

        public bool CanPayBills()
        {
            return this.balance >= this.Consumption;
        }

        public void PayBills()
        {
            this.balance -= this.Consumption;
        }
    }
}