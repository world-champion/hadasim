using AutoMapper;
using Bll.Interfaces;
using Dal;
using Dal.interfaces;
using Dto;
using Entity;
using System.Reflection.PortableExecutable;

namespace Bll
{
    public class CoronaDtailseBll : ICoronaDetailsBll
    {
        IUserDal userDal;
        ICoronaDetailsDal coronaDetailsDal;
        IMapper mapper;
        public CoronaDtailseBll(ICoronaDetailsDal coronaDetailsDal, IMapper mapper, IUserDal userDal)
        {
            this.coronaDetailsDal = coronaDetailsDal;
            this.mapper = mapper;
            this.userDal = userDal;
        }
        public CoronaDtailseDto addCoronaDetails(CoronaDtailseDto details)
        {
            try
            {
                User u = (User)userDal.findUser(details.user_id);
                if (u == null)
                {
                    throw new Exception($"Could not find user with id {details.user_id}");
                }
                else
                    coronaDetailsDal.addCoronaDetails(mapper.Map<CoronaDetails>(details), u);
                return details;
            }
            catch (Exception e) {  }
            return details;
        }

        public List<CoronaDtailseDto> getCoronaDetails()
        {
            return mapper.Map<List<CoronaDtailseDto>>(coronaDetailsDal.getCoronaDetails());
        }
    }
}
