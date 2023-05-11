using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal.interfaces
{
    public interface ICoronaDetailsDal
    {
        CoronaDetails addCoronaDetails(CoronaDetails details, User user);
        List<CoronaDetails> getCoronaDetails();
    }
}
