using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_6_July_2016
{
    public abstract class Single : HouseHold
    {
        public Single(decimal income, int numberOfRooms, decimal roomElectricity) 
            : base(income, numberOfRooms, roomElectricity)
        {
        }
    }
}