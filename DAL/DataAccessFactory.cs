using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Children_information, int, bool> GroupDataAccess()
        {
            return new BIRTHREGISTER();
        }
        public static IRepo<Hosital_information, int, Hosital_information> Children_informationDataAccess()
        {
            return new HospitalRepo();
        }
        public static IRepo<User, string, User> UserDataAccess()
        {
            return new UserRepo();

        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }


        public static IRepo<VolInfo, int, bool> VolenteerDataAccess()
        {
            return new VolenteerRepo();
        }
        public static IRepo<HospitalEmployee, int, HospitalEmployee> HospitalEmployeeDataAccess()
        {
            return new HospitalEmployeeRepo();
        }
        public static IRepo<Employee, string, Employee> EmployeeDataAccess()
        {
            return new EmployeeRepo();
        }
        public static EAuth EAuthDataAccess()
        {
            return new EmployeeRepo();
        }
    }
}
    
