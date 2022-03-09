using System;
using Xunit.Abstractions;
using RestSharp;
using System.Text.Json;
using AutomacaoAltoroJRestAPI.Models;

namespace AutomacaoAltoroJRestAPI.Helpers
{
    public class AccountTransactionAPIActions
    {
        ITestOutputHelper LoggerOutput;
        public ITestOutputHelper Logger
        {
            get { return LoggerOutput; }
            set { LoggerOutput = value; }
        }
        public AccountTransactionAPIActions(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;
        }
        public GetAccountTransaction_Response Get_AccountTransaction(string Token, string AccountId)
        {
            RestClient restClient = new RestClient();
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse restResponse;
            restRequest.AddParameter("Authorization", string.Format("Bearer " + Token), ParameterType.HttpHeader);
            restClient.BaseUrl = new Uri(APIMethods.Account + "/" + AccountId+"/"+ "transactions");
            restResponse = restClient.Execute(restRequest);
            if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoggerOutput.WriteLine("Verificação bem sucedida!");
                return JsonSerializer.Deserialize<GetAccountTransaction_Response>(restResponse.Content);
            }
            else
            {
                LoggerOutput.WriteLine("Verificação Falhou! Estava esperando o cod:" + System.Net.HttpStatusCode.OK + ",mas foi retornado:" + restResponse.StatusCode);
                return null;
            }

        }













    }
}
