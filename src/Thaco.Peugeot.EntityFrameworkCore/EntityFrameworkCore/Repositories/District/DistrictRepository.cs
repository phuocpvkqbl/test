using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Thaco.Peugeot.Entities;
using System.Linq;
using Thaco.Peugeot.Irepo;

namespace Thaco.Peugeot.EntityFrameworkCore.Repositories
{
    public class DistrictRepository : PeugeotRepositoryBase<District, int>, IDistrictRepository
    {
        public DistrictRepository(IDbContextProvider<PeugeotDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        }
        public IList<District> GetAllWithCity(int? cityId)
        {
            
            var query = GetAll();
            if (cityId.HasValue)
            {
                query = query.Where(p => p.CityId == cityId.Value);
            }
            return query.ToList();
        }
    }
}
