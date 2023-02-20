using SkillabApi.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkillabApi.Service
{
    public interface IEmployeeService
    {

        public Task<List<Employee>> GetEmployees();

        public Task AddHardCodedEmployees();
    }
}
