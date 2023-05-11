using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Interfaces
{
    public interface ICoronaDetailsBll
    {
        CoronaDtailseDto addCoronaDetails(CoronaDtailseDto details);
        List<CoronaDtailseDto> getCoronaDetails();
    }
}
