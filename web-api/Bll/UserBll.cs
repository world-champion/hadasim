using AutoMapper;
using Bll.Interfaces;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.interfaces;

namespace Bll
{
    public class UserBll : IUserBll
    {
        IUserDal userDal;
        IMapper mapper;
        public UserBll(IUserDal userDal, IMapper mapper)
        {
            this.userDal = userDal;
            this.mapper = mapper;
        }

        public UserDto addUser(UserDto user)
        {

            userDal.addUser(mapper.Map<User>(user));
            return user;
        }


        public List<UserDto> getUsers()
        {
            return mapper.Map<List<UserDto>>(userDal.getAllUser());
        }
    }
}
