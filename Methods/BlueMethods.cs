using BusAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAPP.Methods
{
    public class BlueMethods
    {
         
        int points;
        int DeductedAmount;
        int Num;
        public void Bus(BlueCard card)
        {
            points = card.Points;
            DeductedAmount = 1;
            points -= 1;
        }
        public void MetroBus(BlueCard card)
        {
            Num = Convert.ToInt32(card.NumberOfStops);
            points = card.Points;
            if (Num <= 3)
                DeductedAmount = 1;
            else
                DeductedAmount = 2;
            points -= DeductedAmount;
        }
        public int GetPoints()
        {
            return points;
        }
        public int GetAmountDeducted()
        {
            return DeductedAmount;
        }
    }
}
