
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.Abstracts;
using PaparaThirdWeek.Services.DTOs;
using System.Threading.Tasks;
using System;
using PaparaThirdWeek.Services.Concretes;
using System.Xml.Linq;

namespace PaparaThirdWeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyService companyService,IMapper mapper)
        {
            this.companyService = companyService;
            _mapper = mapper;
        }

       
        [HttpGet("Companies")]
        public IActionResult Get()
        {
            var result = companyService.GetAll();
            return Ok(result);   
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            companyService.GetById(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(CompanyDto company)
        {

            var companyModel = _mapper.Map<Company>(company);

            companyModel.Name = company.Name;
            companyModel.Adress = company.Adress;
            companyModel.City = company.City;
            companyModel.CreatedBy = "Samet";
            companyModel.CreatedDate = System.DateTime.Now;
            companyModel.Email = company.Email;
            companyModel.IsDeleted = false;
            companyModel.TaxNumber = company.TaxNumber;

            companyService.Add(companyModel);
            return Ok();

        }

        [HttpPut]
        public IActionResult Update(Company company)
        {
            var companyModel = _mapper.Map<Company>(company);

            companyModel.City = company.City;
            companyModel.LastUpdateBy = "MerveBakir";
            companyModel.LastUpdateAt = DateTime.Now;

            companyService.Update(companyModel);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Company company)
        {
            companyService.HardRemove(company);
            return Ok();
        }

    }
}
