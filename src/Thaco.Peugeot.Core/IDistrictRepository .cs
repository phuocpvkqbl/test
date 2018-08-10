using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Thaco.Peugeot.Entities;

namespace Thaco.Peugeot.Irepo
{
    public interface IDistrictRepository: IRepository<District,int>
    {
        IList<District> GetAllWithCity(int? cityId);
    }
}
