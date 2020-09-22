using Lib.Database.FakeApi;
using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lib.Database
{
    public class DatabaseClient : IDatabaseClient
    {
        private readonly DatabaseApi api;

        public DatabaseClient(string accessToken)
        {
            this.api = new DatabaseApi(accessToken);
        }

        public async Task<List<Employee>> getAllEmployees()
        {
            return await api.getAllEmployees();
        }

        public async Task updateAll(List<Employee> employees)
        {
            await api.updateAll(employees);
        }
    }
}
