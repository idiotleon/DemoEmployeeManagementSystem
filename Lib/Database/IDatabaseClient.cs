using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lib.Database
{
    public interface IDatabaseClient
    {
        Task<List<Employee>> getAllEmployees();

        Task updateAll(List<Employee> employees);

        // other CRUD operations omitted for brevity
    }
}
