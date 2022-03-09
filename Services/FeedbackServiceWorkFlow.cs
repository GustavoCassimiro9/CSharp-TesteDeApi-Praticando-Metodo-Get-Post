using Xunit;
using Xunit.Abstractions;
using AutomacaoAltoroJRestAPI.Helpers;
using AutomacaoAltoroJRestAPI.Models;
using System.Text.Json;

namespace AutomacaoAltoroJRestAPI.Services
{
    public class FeedbackServiceWorkFlow
    {
        private readonly ITestOutputHelper LoggerOutput;

        public FeedbackServiceWorkFlow(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;

        }
        public void Validate_FeedbackSubmit(object jsonInput)
        {
            //Arranjo
            CreateFeedbackSubmit_Request requestObject = JsonSerializer.Deserialize<CreateFeedbackSubmit_Request>(jsonInput.ToString());

            //Act
            var response = new FeedbackSubmitAPIActions(LoggerOutput).PostFeedbackSubmit(requestObject);

            //Assert
            Assert.True(response);
        }

    }
}
