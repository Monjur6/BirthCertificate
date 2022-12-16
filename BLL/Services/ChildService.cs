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
    public class ChildService
    {
        public static List<ChildinfoDTO> GetGroups()
        {
            var data = DataAccessFactory.GroupDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Children_information, ChildinfoDTO>());
            var mapper = new Mapper(config);
            var groups = mapper.Map<List<ChildinfoDTO>>(data);
            return groups;

        }

        public static ChildinfoDTO Get(int id)
        {
            var data = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Children_information, ChildinfoDTO>());
            var mapper = new Mapper(config);
            var group = mapper.Map<ChildinfoDTO>(data);
            return group;

        }

        public static bool Add(ChildinfoDTO dto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Children_information, ChildinfoDTO>();
                cfg.CreateMap< ChildinfoDTO, Children_information>();
            });

            var mapper = new Mapper(config);
            var group = mapper.Map<ChildinfoDTO>(dto);
            var result = DataAccessFactory.GroupDataAccess().Add(default);
            return result;


        }



        public ChildinfoDTO Delete(ChildinfoDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Children_information, ChildinfoDTO>();
                cfg.CreateMap<ChildinfoDTO, Children_information>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<Children_information>(dto);
            var result = DataAccessFactory.GroupDataAccess().Add(data);
            var redata = mapper.Map<ChildinfoDTO>(result);
            return redata;
        }
    }
}

