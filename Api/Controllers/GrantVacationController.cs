using Lib.Database;
using Lib.EmailClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrantVacationController : ControllerBase
    {
        private readonly ILogger<GrantVacationController> _logger;
        private readonly DatabaseClient databaseClient;
        private readonly EmailClient emailClient;

        public GrantVacationController(ILogger<GrantVacationController> logger)
        {
            _logger = logger;
            this.databaseClient = new DatabaseClient("ACCESS_TOKEN");
            this.emailClient = new EmailClient("username", "password");
        }

        [HttpPost]
        public async Task GrantVacation()
        {
            var allEmployees = await databaseClient.getAllEmployees();
            List<EmailTemplateGrantVacation> emails = new List<EmailTemplateGrantVacation>();
            foreach (var employee in allEmployees)
            {
                int yearsEmployed = employee.getYearsEmployed();
                employee.increaseVacationBalance(yearsEmployed);
                emails.Add(new EmailTemplateGrantVacation(employee));
            }

            // to update the database
            await databaseClient.updateAll(allEmployees);
            _logger.Log(LogLevel.Information, "Vacation balances of all employees have been updated");

            // to send the emails
            await emailClient.batchSendEmails(emails);
            _logger.Log(LogLevel.Information, "Emails have been sent to all employees");
        }
    }
}
