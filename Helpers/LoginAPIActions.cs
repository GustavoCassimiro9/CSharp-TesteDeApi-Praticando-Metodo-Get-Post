using System;
using Xunit.Abstractions;
using RestSharp;
using System.Text.Json;
using AutomacaoAltoroJRestAPI.Models;


namespace AutomacaoAltoroJRestAPI.Helpers
{
    public class LoginAPIActions
    {
        private ITestOutputHelper LoggerOutput;

        public ITestOutputHelper Logger
        {
            get { return LoggerOutput; }
            set { LoggerOutput = value; }
        }

        public LoginAPIActions(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;
        }
        public GetLogin_Response Get_Login(string Token)
        {
            RestClient restClient = new RestClient(); //Criar um cliente
            RestRequest restRequest = new RestRequest(Method.GET); // Criar uma requisição 
            IRestResponse restResponse;
            restRequest.AddParameter("Authorization", string.Format("Bearer " + Token), ParameterType.HttpHeader);
            restClient.BaseUrl = new Uri(APIMethods.Login);
            restResponse = restClient.Execute(restRequest);

            if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoggerOutput.WriteLine("Verificação bem sucedida!");
                return JsonSerializer.Deserialize<GetLogin_Response>(restResponse.Content);
            }
            else
            {
                LoggerOutput.WriteLine("Verificação Falhou! Estava esperando o cod:" + System.Net.HttpStatusCode.OK + ",mas foi retornado:" + restResponse.StatusCode);
                return null;
            }
        }
    }
}
