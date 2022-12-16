using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HospitalService
    {
        public static List<HospitalDTO> Get()
        {
            var dbdata = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Hosital_information, HospitalDTO>());
            var mapper = new Mapper(config);
            var groups = mapper.Map<List<HospitalDTO>>(dbdata);
            return groups;


        }
        public static HospitalDTO Get(int id)
        {
            var dbdata = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Hosital_information, HospitalDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<HospitalDTO>(dbdata);
            return data;

        }
        public static HospitalDTO Add(HospitalDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hosital_information, HospitalDTO>();
                cfg.CreateMap< HospitalDTO, Hosital_information>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<HospitalDTO>(dto);
            var result = DataAccessFactory.GroupDataAccess().Add(default);
            var rdata = mapper.Map<HospitalDTO>(result);
            return rdata;
        }


        public static bool Delete(int id)
        {
            return DataAccessFactory.GroupDataAccess().Delete(id);
        }


        public static HospitalDTO Update(HospitalDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Hosital_information, HospitalDTO>();
                cfg.CreateMap<HospitalDTO, Hosital_information>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<HospitalDTO>(dto);
            var result = DataAccessFactory.GroupDataAccess().Add(default);
            var rdata = mapper.Map<HospitalDTO>(result);
            return rdata;
        }

        public static object Delete(HospitalDTO hospital)
        {
            throw new NotImplementedException();
        }
    }
}

