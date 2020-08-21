using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chocolate.Models
{
    public interface IFlavourRepository
    {
        Flavours Add(Flavours flavours);
        Flavours Update(Flavours flavoursChanges);
        Flavours Delete(int Id);
        Flavours GetFlavours(int Id);
        IEnumerable<Flavours> GetAllFlavours();
    }
}
