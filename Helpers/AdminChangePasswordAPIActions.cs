using Xunit.Abstractions;
using System;
using System.Text.Json;
using RestSharp;
using AutomacaoAltoroJRestAPI.Models;

namespace AutomacaoAltoroJRestAPI.Helpers
{
    public class AdminChangePasswordAPIActions
    {
        private readonly ITestOutputHelper LoggerOutput;

        public AdminChangePasswordAPIActions(ITestOutputHelper loggerOutput)
        {
            this.LoggerOutput = loggerOutput;
        }
        public bool PostAdminChangePassword(string Token, CreateAdminChangePassword_Request requestBody)
        {
            RestClient restClient = new RestClient();
            RestRequest restRequest = new RestRequest(Method.POST);
            IRestResponse restResponse;
            restRequest.AddParameter("Authorization", string.Format("Bearer " + Token), ParameterType.HttpHeader);
            restClient.BaseUrl = new Uri(APIMethods.Admin + "/" + "changePassword");
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
