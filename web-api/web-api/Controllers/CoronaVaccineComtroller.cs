using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bll.Interfaces;
using Dto;
using Dal;
using Entity;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaVaccineComtroller : Controller
    {
        ICoronaVaccineBll coronaVaccineBll;
        public CoronaVaccineComtroller(ICoronaVaccineBll coronaVaccineBll)
        {
            this.coronaVaccineBll = coronaVaccineBll;
        }

        [HttpGet]
        public List<CoronaVaccineDto> Get()
        {
            return this.coronaVaccineBll.getCoronaVaccineList();
        }
        [HttpPost]
        public CoronaVaccineDto Post([FromBody] CoronaVaccineDto c)
        {
            return this.coronaVaccineBll.addCoronaVaccine(c);
        }
    }
}

      