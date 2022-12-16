using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class EmployeeRepo : IRepo<Employee, string, Employee>, EAuth
    {
        public Employee Add(Employee obj)
        {
            throw new NotImplementedException();
        }

        public Employee Authenticate(string uname, string password)
        {
            throw null;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public Employee Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
