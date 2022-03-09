using Xunit;
using Xunit.Abstractions;
using System;
using AutomacaoAltoroJRestAPI.Helpers;
using AutomacaoAltoroJRestAPI.Models;
using System.Text.Json;

namespace AutomacaoAltoroJRestAPI.Services
{
    public class AccountServiceWorkFlow
    {
        private readonly ITestOutputHelper LoggerOutput;
        public AccountServiceWorkFlow(ITestOutputHelper LoggerOutput)
        {
            this.LoggerOutput = LoggerOutput;

        }
        public void Get_ValidateAccount(string Token)
        {
            var response = new AccountAPIActions(LoggerOutput).Get_Account(Token);

            if (response != null)
            {
                
                for(int i = 0; i < response.accounts.Count; i++)
                {
                    Assert.True(response.accounts[i].name != null);
                    Assert.True(response.accounts[i].id != null);
                    LoggerOutput.WriteLine("Nome: " + response.accounts[i].name + "  id: " + response.accounts[i].id);
                }
            }
            else
            {
                LoggerOutput.WriteLine("Response: " + response);
                Assert.NotNull(response);
            }
        }

        public void Get_ValidateAccountNo(string Token, string AccountId)
        {
            var response = new AccountNoAPIActions(LoggerOutput).Get_AccountNo(Token,AccountId);
     
            if (response != null)
            {
                for(int i=0; i<response.credits.Count; i++)
                {
                    Assert.True(response.credits[i].date != null);
                    Assert.True(response.credits[i].amount != null);
                    Assert.True(response.credits[i].account != null);
                    Assert.True(response.credits[i].description != null);
                    LoggerOutput.WriteLine(" date: " + response.credits[i].date + " amount: " + response.credits[i].amount+
                        " account: "+ response.credits[i].account + " description: "+ response.credits[i].description
                    );


                }
                Assert.True(response.accountId != null);
                Assert.True(response.balance != null);

            }
            else
            {
                LoggerOutput.WriteLine("Response: " + response);
                Assert.NotNull(response);
            }

        }
        public void Get_ValidateAccountTransaction(string Token, string AccountId)
        {
            var response = new AccountTransactionAPIActions(LoggerOutput).Get_AccountTransaction(Token, AccountId);

            if (response != null)
            {
                for (int i = 0; i < response.last_10_transactions.Count; i++)
                {
                    Assert.True(response.last_10_transactions[i].transactionType != null);
                    Assert.True(response.last_10_transactions[i].date != null);
                    Assert.True(response.last_10_transactions[i].ammount != null);

                   LoggerOutput.WriteLine(" Date: " + response.last_10_transactions[i].date + " TransactionType: " + response.last_10_transactions[i].transactionType +
                        " Ammount: " + response.last_10_transactions[i].ammount);

                }
                
            }
            else
            {
                LoggerOutput.WriteLine("Response: " + response);
                Assert.NotNull(response);
            }

        }
        public void Validate_AccountTransaction( string Token, string AccountId, object jsonInput)
        {
            //Arranjo
            CreateAccountTransaction_Request requestObject = JsonSerializer.Deserialize<CreateAccountTransaction_Request>(jsonInput.ToString());

            //Act
            var response = new AccountTransactionDataAPI(LoggerOutput).PostAccountTransaction(Token, AccountId, requestObject);

            //Assert
            Assert.True(response);
        }

    }
}
