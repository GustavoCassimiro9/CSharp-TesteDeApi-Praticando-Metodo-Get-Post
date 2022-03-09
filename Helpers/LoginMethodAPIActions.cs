
using System;
using Xunit.Abstractions;
using RestSharp;
using System.Text.Json;
using AutomacaoAltoroJRestAPI.Models;

namespace AutomacaoAltoroJRestAPI.Helpers
{
    public class LoginMethodAPIActions
    {
        private ITestOutputHelper LoggerOutput;

        public LoginMethodAPIActions(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;
        }

        public bool Get_LoginMethod(GetLoginMethod_Response requestBody)
        {
            RestClient restClient = new RestClient();
            RestRequest restRequest = new RestRequest(Method.POST);
            IRestResponse restResponse;
            restClient.BaseUrl = new Uri(APIMethods.Login);
            restRequest.AddJsonBody(JsonSerializer.Serialize(requestBody));
            restResponse = restClient.Execute(restRequest);
            var ResponseContent = restResponse.Content;
            if(restResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoggerOutput.WriteLine("Verificação bem sucedida!");
                LoggerOutput.WriteLine("RestResponse contem o Token: " + ResponseContent.Contains("Authorization"));
                LoggerOutput.WriteLine("RestResponse contem a validação de sucesso: " + ResponseContent.Contains("success"));

                return true;
            }
            else
            {
                LoggerOutput.WriteLine("Verificação Falhou! Estava esperando o cod:" + System.Net.HttpStatusCode.OK + ",mas foi retornado:" + restResponse.StatusCode);
                return false;
            }

        }

    }
}
