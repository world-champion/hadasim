using AutoMapper;
using Bll.Interfaces;
using Dal;
using Dal.interfaces;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class CoronaVaccineBll : ICoronaVaccineBll
    {
        IUserDal userDal;
        ICoronaVaccineDal coronaVaccineDal;
        IMapper mapper;
        public CoronaVaccineBll(ICoronaVaccineDal coronaVaccineDal, IMapper mapper, IUserDal userDal)
        {
            this.coronaVaccineDal = coronaVaccineDal;
            this.mapper = mapper;
            this.userDal = userDal;
        }
        public CoronaVaccineDto addCoronaVaccine(CoronaVaccineDto vaccine)
        {
                CoronaVaccine vaccine1;
            try {
            User u= (User)userDal.findUser(vaccine.userId);
            if(u==null)
            {
                    throw new Exception($"Could not find user with id {vaccine.userId}");
                    
            }
             else if(userDal.getAllUser().FindAll(x => x.id == vaccine.userId).Count()>=4)
                    throw new Exception($"Could not add more than 4 vaccines to user #{vaccine.userId}");
             else {
                    coronaVaccineDal.addCoronaVaccine(mapper.Map<CoronaVaccine>(vaccine),u); }
             }catch(Exception e)
            {

            }
            return vaccine;
        }

        public List<CoronaVaccineDto> getCoronaVaccineList()
        {
            return mapper.Map<List<CoronaVaccineDto>>(coronaVaccineDal.getCoronaVaccineList());
        }
    }
}
