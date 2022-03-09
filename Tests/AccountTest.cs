using AutomacaoAltoroJRestAPI.Services;
using Xunit;
using Xunit.Abstractions;

namespace AutomacaoAltoroJRestAPI.Tests
{
    public class AccountTest
    {
        private readonly ITestOutputHelper output;

        public AccountTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact(DisplayName = "Get list of property of usuary")]
        [Trait("category", "Account")]
        public void Get_Account()
        {
            new AccountServiceWorkFlow(output).Get_ValidateAccount(CustomConfigurationProvider.GetSection("Token"));
        }

        [Fact(DisplayName = "Get details about a specific account")]
        [Trait("category", "Account")]
        public void Get_AccountNo()
        {
            new AccountServiceWorkFlow(output).Get_ValidateAccountNo(CustomConfigurationProvider.GetSection("Token"), CustomConfigurationProvider.GetSection("AccountId"));
        }
        [Fact(DisplayName = "Get transaction account")]
        [Trait("category", "Account")]
        public void Get_AccountTransaction()
        {
            new AccountServiceWorkFlow(output).Get_ValidateAccountTransaction(CustomConfigurationProvider.GetSection("Token"), CustomConfigurationProvider.GetSection("AccountId"));
        }
        [Fact]
        public void Validate_AccountTransaction()
        {
            new AccountServiceWorkFlow(output).Validate_AccountTransaction(CustomConfigurationProvider.GetSection("Token"), CustomConfigurationProvider.GetSection("AccountId"), CustomConfigurationProvider.GetSection("AccountPost"));
        }
    }
}