using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dto;
using Bll.Interfaces;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaDetails : Controller
    {
        ICoronaDetailsBll coronaDetailsBll;

        public CoronaDetails(ICoronaDetailsBll coronaDetailsBll)
        {
            this.coronaDetailsBll = coronaDetailsBll;
        }

        [HttpGet]
        public List<CoronaDtailseDto> Get() {
            return this.coronaDetailsBll.getCoronaDetails();
        }

        [HttpPost]
        public CoronaDtailseDto Post([FromBody] CoronaDtailseDto c)
        {
            return this.coronaDetailsBll.addCoronaDetails(c);
        }
    }
}
