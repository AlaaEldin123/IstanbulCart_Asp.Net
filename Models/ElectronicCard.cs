using BusAPP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusAPP.Models
{
    public class ElectronicCard:Card
    {
        public double TransportNumber { get; set; }
        public double NumberOfStops { get; set; }
        public Vehicles Vehicles { get; set; }
        public int Points { get; set; }
        public int DeductedAmount { get; set; }
        public int AvailableBalance { get; set; }

        public override void Bus(int trans)
        {
            throw new NotImplementedException();
        }

        public override void Metrobus(int stops)
        {
            throw new NotImplementedException();
        }
    }
}
