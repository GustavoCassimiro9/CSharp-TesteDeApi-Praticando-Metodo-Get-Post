using Xunit.Abstractions;
using System;
using System.Text.Json;
using RestSharp;
using AutomacaoAltoroJRestAPI.Models;

namespace AutomacaoAltoroJRestAPI.Helpers
{
    public class FeedbackSubmitAPIActions
    {
        private readonly ITestOutputHelper LoggerOutput;

        public FeedbackSubmitAPIActions(ITestOutputHelper loggerOutput)
        {
            this.LoggerOutput = loggerOutput;
        }
        public bool PostFeedbackSubmit(CreateFeedbackSubmit_Request requestBody)
        {
            RestClient restClient = new RestClient();
            RestRequest restRequest = new RestRequest(Method.POST);
            IRestResponse restResponse;
            restClient.BaseUrl = new Uri(APIMethods.Feedback + "/" + "submit");
            restRequest.AddJsonBody(JsonSerializer.Serialize(requestBody));// Adiciona o corpo Json na requisição 
            restResponse = restClient.Execute(restRequest);

            if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoggerOutput.WriteLine("RestResponse: " + restResponse.Content);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
