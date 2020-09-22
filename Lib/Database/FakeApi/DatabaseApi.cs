using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lib.Database.FakeApi
{
    public class DatabaseApi
    {
        private string accessToken;

        public DatabaseApi(string accessToken)
        {
            this.accessToken = accessToken;
        }

        public async Task<List<Employee>> getAllEmployees()
        {
            // assuming the `ACCESS_TOKEN` have been applied here

            // assuming the right table/collection has been found here

            // to mimic/fake the `getAllEmployees()` functionality
            List<Employee> employees = new List<Employee>();

            return await Task.Run(() =>
            {
                return employees;
            });
        }

        public async Task updateAll(List<Employee> employees)
        {
            await Task.Run(() =>
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine($"updated - {employee}");
                }
            });
        }
    }
}