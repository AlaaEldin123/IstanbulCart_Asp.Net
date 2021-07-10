using BusAPP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusAPP.Models
{
    public class IstanbulCard: Card
    {
        public CustomerType CustomerType { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public override int CardId { get; set; }
        public double TransportNumber { get; set; }
        public double NumberOfStops { get; set; }
        public Vehicles Vehicles { get; set; }
        public double Balance { get; set; }
        public double AvailableBalance { get; set; }
        public double DeductedAmount { get; set; }

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
