using AutomacaoAltoroJRestAPI.Services;
using Xunit;
using Xunit.Abstractions;


namespace AutomacaoAltoroJRestAPI.Tests
{
    public class LogoutTest
    {
        private readonly ITestOutputHelper output;

        public LogoutTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact(DisplayName = "Get logout result")]
        [Trait("category", "Logout")]
        public void Get_ValidateLogout()
        {
            new LogoutServiceWorkFlow(output).Get_ValidateLogout();
        }
    }
}
