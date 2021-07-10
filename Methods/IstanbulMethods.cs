using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusAPP.Enums;
using BusAPP.Models;

namespace BusAPP.Methods
{
    public class IstanbulMethods
    {
        double balance;
        double DeductedAmount;
        double Num;
        public void GetBalanceBus(IstanbulCard card)
        {

            balance = card.Balance;
            switch (card.CustomerType)
            {
                case CustomerType.FullFare:
                    switch (card.TransportNumber)
                    {
                        case 0: DeductedAmount = 2.6; break;
                        case 1: DeductedAmount = 1.85; break;
                        case 2: DeductedAmount = 1.4; break;
                        case 3: case 4: case 5: DeductedAmount = 0.9; break;
                        default: DeductedAmount = 0; break;
                    }
                    break;
                case CustomerType.Student:
                    switch (card.TransportNumber)
                    {
                        case 0: DeductedAmount = 1.25; break;
                        case 1: DeductedAmount = 0.55; break;
                        case 2: DeductedAmount = 0.50; break;
                        case 3: case 4: case 5: DeductedAmount = 0.45; break;
                        default: DeductedAmount = 0; break;
                    }
                    break;
                case CustomerType.Teacher:
                    switch (card.TransportNumber)
                    {
                        case 0: DeductedAmount = 1.85; break;
                        case 1: DeductedAmount = 1.1; break;
                        case 2: DeductedAmount = 0.85; break;
                        case 3: case 4: case 5: DeductedAmount = 0.55; break;
                        default: DeductedAmount = 0; break;
                    }
                    break;
                default:
                    DeductedAmount = 0; break;
            }
            balance -= DeductedAmount;
        }
        public double GetBalance()
        {
            return balance;
        }
        public double GetDeductedAmount()
        {
            return DeductedAmount;
        }
        public void GetBalanceMetroBus(IstanbulCard card)
        {
            Num = Convert.ToDouble(card.NumberOfStops);
            balance = card.Balance;
            switch (card.CustomerType)
            {
                case CustomerType.FullFare:
                    if (Num <= 3)
                        DeductedAmount = 1.95;
                    else if (Num <= 9)
                        DeductedAmount = 3;
                    else if (Num <= 15)
                        DeductedAmount = 3.25;
                    else if (Num <= 21)
                        DeductedAmount = 3.4;
                    else if (Num <= 27)
                        DeductedAmount = 3.5;
                    else if (Num <= 33)
                        DeductedAmount = 3.6;
                    else
                        DeductedAmount = 3.85;
                    break;
                case CustomerType.Student:
                    if (Num <= 3)
                        DeductedAmount = 1.1;
                    else if (Num <= 9)
                        DeductedAmount = 1.2;
                    else
                        DeductedAmount = 1.25;
                    break;
                case CustomerType.Teacher:
                    if (Num <= 3)
                        DeductedAmount = 1.45;
                    else if (Num <= 9)
                        DeductedAmount = 1.85;
                    else if (Num <= 15)
                        DeductedAmount = 1.9;
                    else if (Num <= 27)
                        DeductedAmount = 2;
                    else
                        DeductedAmount = 2.1;
                    break;
                default: DeductedAmount = 0; break;
            }
            balance -= DeductedAmount;
        }
    }
}
