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
    public class HospitalEmployeeService
    {
        public static List<HospitalEmployeeDTO> Get()
        {
            var dbdata = DataAccessFactory.HospitalEmployeeDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HospitalEmployee, HospitalEmployeeDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<HospitalEmployeeDTO>>(dbdata);
            return data;

        }

        public static HospitalEmployeeDTO Get(int id)
        {
            var dbdata = DataAccessFactory.HospitalEmployeeDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HospitalEmployee, HospitalEmployeeDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<HospitalEmployeeDTO>(dbdata);
            return data;

        }

        public static HospitalEmployeeDTO  Add(HospitalEmployeeDTO dto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HospitalEmployee, HospitalEmployeeDTO>();
                cfg.CreateMap<HospitalEmployeeDTO, HospitalEmployee>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<HospitalEmployee>(dto);
            var result = DataAccessFactory.HospitalEmployeeDataAccess().Add(data);
            var redata = mapper.Map<HospitalEmployeeDTO>(result);
            return redata;


        }



        //public static HospitalEmployeeDTO Delete(HospitalEmployeeDTO dto)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<HospitalEmployee, HospitalEmployeeDTO>();
        //        cfg.CreateMap<HospitalEmployeeDTO, HospitalEmployee>();
        //    });

        //    var mapper = new Mapper(config);
        //    var group = mapper.Map<HospitalEmployeeDTO>(dto);
        //    var result = DataAccessFactory.GroupDataAccess().Delete(default);

        //    return mapper.Map<HospitalEmployeeDTO>(result);
        //}
    }
}
