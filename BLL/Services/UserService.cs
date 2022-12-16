using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public List<UserDTO> Get()
        {
            var dbdata = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserService, UserDTO>());
            var mapper = new Mapper(config);
            var rdata = mapper.Map<List<UserDTO>>(dbdata);
            return rdata;



        }
        public static UserDTO Get(int id)
        {
            var dbdata = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserService, UserDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<UserDTO>(dbdata);
            return data;

        }
        public UserDTO Add(UserDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap< UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<UserDTO>(dto);
            var result = DataAccessFactory.GroupDataAccess().Add(default);
            var rdata = mapper.Map<UserDTO>(result);
            return rdata;
        }


        public static UserDTO Delete(UserDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserService, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<UserDTO>(dto);
            var result = DataAccessFactory.GroupDataAccess().Delete(default);
            var rdata = mapper.Map<UserDTO>(result);
            return rdata;
        }
    }
}

