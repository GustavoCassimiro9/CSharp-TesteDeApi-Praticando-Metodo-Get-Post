using System;
using Xunit.Abstractions;
using RestSharp;
using System.Text.Json;
using AutomacaoAltoroJRestAPI.Models;
namespace AutomacaoAltoroJRestAPI.Helpers
{
    public class LogoutAPIActions
    {
        ITestOutputHelper LoggerOutput;
        public ITestOutputHelper Logger
        {
            get { return LoggerOutput; }
            set { LoggerOutput = value; }
        }
        public LogoutAPIActions(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;
        }
        public GetLogout_Response Get_Logout()
        {
            RestClient restClient = new RestClient();
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse restResponse;
            restClient.BaseUrl = new Uri(APIMethods.Geral+ "logout");
            restResponse = restClient.Execute(restRequest);
            if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoggerOutput.WriteLine("Verificação bem sucedida!");
                return JsonSerializer.Deserialize<GetLogout_Response>(restResponse.Content);
            }
            else
            {
                LoggerOutput.WriteLine("Verificação Falhou! Estava esperando o cod:" + System.Net.HttpStatusCode.OK + ",mas foi retornado:" + restResponse.StatusCode);
                return null;
            }

        }
    }
}
