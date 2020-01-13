using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoFluentValidation.Domain.Entities;
using DemoFluentValidation.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoFluentValidation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]Company company)
        {
            return Ok(await _companyService.Add(company));
        }
    }
}