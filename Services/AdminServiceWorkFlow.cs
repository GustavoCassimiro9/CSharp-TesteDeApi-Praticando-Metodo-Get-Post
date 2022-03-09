using Xunit;
using Xunit.Abstractions;
using AutomacaoAltoroJRestAPI.Helpers;
using AutomacaoAltoroJRestAPI.Models;
using System.Text.Json;

namespace AutomacaoAltoroJRestAPI.Services
{
    public class AdminServiceWorkFlow
    {
        private readonly ITestOutputHelper LoggerOutput;

        public AdminServiceWorkFlow(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;

        }
        public void Validate_AdminAddUser(string Token,object jsonInput)
        {
            //Arranjo
            CreateAdminAddUser_Request requestObject = JsonSerializer.Deserialize<CreateAdminAddUser_Request>(jsonInput.ToString());

            //Act
            var response = new AdminAddUserAPIActions(LoggerOutput).PostAdminAddUser(Token ,requestObject);

            //Assert
            Assert.True(response);
        }
        public void Validate_AdminChangePassword(string Token, object jsonInput)
        {
            //Arranjo
            CreateAdminChangePassword_Request requestObject = JsonSerializer.Deserialize<CreateAdminChangePassword_Request>(jsonInput.ToString());

            //Act
            var response = new AdminChangePasswordAPIActions(LoggerOutput).PostAdminChangePassword(Token, requestObject);

            //Assert
            Assert.True(response);
        }
    }
}
