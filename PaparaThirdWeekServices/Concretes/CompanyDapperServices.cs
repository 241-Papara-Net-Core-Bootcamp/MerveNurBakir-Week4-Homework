using AutoMapper;
using PaparaThirdWeek.Data.Abstracts;
using System;
using System.Collections.Generic;
using PaparaThirdWeek.Services.Abstracts;
using PaparaThirdWeek.Services.DTOs;
using PaparaThirdWeek.Domain.Entities;

namespace PaparaThirdWeek.Services.Concretes
{
    internal class CompanyDapperServices
    {
        private readonly IDapperRepository<Company> _repository;
        private readonly IMapper _mapper;

        public CompanyDapperServices(IDapperRepository<Company> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IReadOnlyList<CompanyDto> GetAll()
        {
            var companies = _mapper.Map<List<CompanyDto>>(_repository.GetAll());
            return companies;
        }

        public void Add(CompanyDto company)
        {
            _repository.Add(_mapper.Map<Company>(company));

        }

        public void Delete(int id)
        {
            _repository.Remove(id);
        }

        public void Update(int id, CompanyDto company)
        {
            _repository.Update(id, _mapper.Map<Company>(company));
        }
    }
}
