using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal.interfaces
{
    public interface ICoronaVaccineDal
    {
        CoronaVaccine addCoronaVaccine(CoronaVaccine vaccine, User u);

        List<CoronaVaccine> getCoronaVaccineList();
    }
}
