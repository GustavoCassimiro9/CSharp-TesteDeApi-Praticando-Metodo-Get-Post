using Xunit;
using Xunit.Abstractions;
using AutomacaoAltoroJRestAPI.Helpers;
using AutomacaoAltoroJRestAPI.Models;
using System.Text.Json;

namespace AutomacaoAltoroJRestAPI.Services
{
    public class TransferServiceWorkFlow
    {
        private readonly ITestOutputHelper LoggerOutput;

        public TransferServiceWorkFlow(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;

        }
        public void Validate_Transfer(string Token ,object jsonInput)
        {
            //Arranjo
            CreateTransfer_Request requestObject = JsonSerializer.Deserialize<CreateTransfer_Request>(jsonInput.ToString());

            //Act
            var response = new TransferAPIActions(LoggerOutput).PostTransfer(Token, requestObject);

            //Assert
            Assert.True(response);
        }

    }
}
