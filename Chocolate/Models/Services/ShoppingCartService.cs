using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Chocolate.Models.Services
{
    public class ShoppingCartService
    {
        public Flavours AddFlavours(Flavours flavoursmodel)
        {
            _dbContext.Add(flavoursmodel);
            _dbContext.SaveChanges();
            return flavoursmodel;
        }
    }
}
