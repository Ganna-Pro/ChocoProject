using Chocolate.Migrations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chocolate.Models
{
    public class FlavoursRepositary : IFlavourRepository
    {
        private readonly AppDBContext _dbContext;

        public FlavoursRepositary(AppDBContext dBContext)
        {
            _dbContext = dBContext;
        }


        public Flavours Add(Flavours flavours)
        {
            _dbContext.Flavours.Add(flavours);
            _dbContext.SaveChanges();
            return flavours;

        }

        public Flavours Delete(int Id)
        {
            var flv = _dbContext.Flavours.Find(Id);
                if(flv != null)
                {
                _dbContext.Flavours.Remove();
                _dbContext.SaveChanges();
                }
                return flv;

        }

        public IEnumerable<Flavours> GetAllFlavours()
        {
            throw new NotImplementedException();
        }



        public Flavours GetFlavours(int Id)
        {
            return _dbContext.Flavours.Find(Id);
        }

        Flavours IFlavourRepository.Add(Flavours flavours)
        {
            throw new NotImplementedException();
        }

        Flavours IFlavourRepository.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Flavours> IFlavourRepository.GetAllFlavours()
        {
            throw new NotImplementedException();
        }

        Flavours IFlavourRepository.GetFlavours(int Id)
        {
            throw new NotImplementedException();
        }

        Flavours IFlavourRepository.Update(Flavours flavoursChanges)
        {
            throw new NotImplementedException();
        }
    }
}
