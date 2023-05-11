using Dal.interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CoronaVaccineDal:ICoronaVaccineDal
    {
        ProjectContext projectContext;
        public CoronaVaccineDal(ProjectContext projectContext)
        {
            this.projectContext = projectContext;
        }
        public CoronaVaccine addCoronaVaccine(CoronaVaccine vaccine, User u)
        {
            vaccine.user = u;
            this.projectContext.vaccines.Add(vaccine);
            projectContext.SaveChanges();
            return vaccine;
        }

        public List<CoronaVaccine> getCoronaVaccineList()
        {
            return projectContext.vaccines.ToList();
        }

        
    }
}
