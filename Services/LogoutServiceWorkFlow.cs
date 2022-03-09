using Xunit;
using Xunit.Abstractions;
using AutomacaoAltoroJRestAPI.Helpers;
using AutomacaoAltoroJRestAPI.Models;
using System.Text.Json;


namespace AutomacaoAltoroJRestAPI.Services
{
    public class LogoutServiceWorkFlow
    {
        private readonly ITestOutputHelper LoggerOutput;

        public LogoutServiceWorkFlow(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;

        }

        public void Get_ValidateLogout()
        {
            var response = new LogoutAPIActions(LoggerOutput).Get_Logout();

            Assert.NotNull(response);
            Assert.Contains("True",response.LoggedOut);            
        }
    }
    
}
