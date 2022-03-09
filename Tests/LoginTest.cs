using AutomacaoAltoroJRestAPI.Services;
using Xunit;
using Xunit.Abstractions;

namespace AutomacaoAltoroJRestAPI.Tests
{
    public class LoginTest
    {
        private readonly ITestOutputHelper output;

        public LoginTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact(DisplayName = "Get Login")]
        [Trait("category", "Login")]
        public void Get_Login()
        {
            new LoginServiceWorkFlow(output).Get_ValidateLogin(CustomConfigurationProvider.GetSection("Token"));
        }
        [Fact]
        public void Get_LoginMethod()
        {
            new LoginServiceWorkFlow(output).Get_ValidateLoginMethod(CustomConfigurationProvider.GetSection("login"));
        }
    }
}
