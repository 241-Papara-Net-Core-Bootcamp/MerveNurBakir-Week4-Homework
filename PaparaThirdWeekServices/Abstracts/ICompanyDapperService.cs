using PaparaThirdWeek.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaThirdWeek.Services.Abstracts
{
    internal interface ICompanyDapperService
    {
        public IReadOnlyList<CompanyDto> GetAll();
        public void Add(CompanyDto dto);
        public void Delete(int id);
        public void Update(int id, CompanyDto dto);
    }
}
