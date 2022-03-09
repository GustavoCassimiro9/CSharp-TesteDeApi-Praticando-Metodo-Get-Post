using Xunit.Abstractions;
using System;
using System.Text.Json;
using RestSharp;
using AutomacaoAltoroJRestAPI.Models;

namespace AutomacaoAltoroJRestAPI.Helpers
{
    public class AccountTransactionDataAPI
    {
        private readonly ITestOutputHelper LoggerOutput;

        public AccountTransactionDataAPI(ITestOutputHelper loggerOutput)
        {
            this.LoggerOutput = loggerOutput;
        }
        public bool PostAccountTransaction(string Token, string AccountId, CreateAccountTransaction_Request requestBody)
        {
            RestClient restClient = new RestClient();
            RestRequest restRequest = new RestRequest(Method.POST);
            IRestResponse restResponse;
            restRequest.AddParameter("Authorization", string.Format("Bearer " + Token), ParameterType.HttpHeader);
            restClient.BaseUrl = new Uri(APIMethods.Account + "/" + AccountId + "/" + "transactions");
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
