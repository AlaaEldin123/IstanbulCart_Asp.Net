using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusAPP.AddClasses;

namespace BusAPP.Bl
{   public class ClsIstanbul
    {
        public List<AddClasses.IstanbulCard> GetAll()
        {
            BusAPPContext oContext = new BusAPPContext();
            List<AddClasses.IstanbulCard> LS = oContext.IstanbulCards.ToList();
            return LS;
        }

        public bool Add(AddClasses.IstanbulCard ist)
        {
            try
            {
                BusAPPContext ctx = new BusAPPContext();
                ctx.IstanbulCards.Add(ist);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
