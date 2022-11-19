using Microsoft.Extensions.Configuration;
using PaparaThirdWeek.Data.Abstracts;
using PaparaThirdWeek.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaThirdWeek.Data.Concretes
{
    internal class DapperRepository<T> : IDapperRepository<T> where T : BaseEntity
    {
        private readonly IConfiguration _conf;

        public DapperRepository(IConfiguration conf)
        {
            _conf = conf;
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
