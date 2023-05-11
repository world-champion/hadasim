using Dal.interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CoronaDetailsDal : ICoronaDetailsDal
    {
        ProjectContext projectContext;

        public  CoronaDetailsDal(ProjectContext projectContext)
        {
            this.projectContext = projectContext;
        }

            public CoronaDetails addCoronaDetails(CoronaDetails details, User u)
        {
            details.user = u;
            this.projectContext.details.Add(details);
            this.projectContext.SaveChanges();
            return details;
        }

        public List<CoronaDetails> getCoronaDetails()
        {
            return this.projectContext.details.ToList();
        }
    }
}
