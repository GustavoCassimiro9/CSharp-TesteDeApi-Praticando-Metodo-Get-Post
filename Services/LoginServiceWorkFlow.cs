using Xunit;
using Xunit.Abstractions;
using AutomacaoAltoroJRestAPI.Helpers;
using AutomacaoAltoroJRestAPI.Models;
using System.Text.Json;

namespace AutomacaoAltoroJRestAPI.Services
{
    public class LoginServiceWorkFlow
    {
        private readonly ITestOutputHelper LoggerOutput;

        public LoginServiceWorkFlow(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;

        }
        public void Get_ValidateLogin(string Token)
        {
            var response = new LoginAPIActions(LoggerOutput).Get_Login(Token);

            if (response != null)
            {
                LoggerOutput.WriteLine("Loggedin:  " + response.loggedin);
                Assert.Contains("true",response.loggedin);
            }
            else
            {
                 LoggerOutput.WriteLine("Response" + response.loggedin);
                Assert.NotNull(response);
            }
        }

        public void Get_ValidateLoginMethod(object jsonInput)
        {
            GetLoginMethod_Response requestObject = JsonSerializer.Deserialize<GetLoginMethod_Response>(jsonInput.ToString());

            var response = new LoginMethodAPIActions(LoggerOutput).Get_LoginMethod(requestObject);
            Assert.True(response);

            LoggerOutput.WriteLine("test "+response);


        }




    }
}
