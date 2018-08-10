using System.Collections.Generic;
using Thaco.Peugeot.Company.Dto;

namespace Thaco.Peugeot.Web.Models.Company
{
    public class CompanyListViewModel
    {
        public IReadOnlyList<CompanyDto> Companies { get; set; }
    }
}
