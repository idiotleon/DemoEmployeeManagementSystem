using Lib.Database.FakeApi;
using Model;
using System;
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
            try
            {
                return await api.getAllEmployees();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task updateAll(List<Employee> employees)
        {
            try
            {
                await api.updateAll(employees);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
