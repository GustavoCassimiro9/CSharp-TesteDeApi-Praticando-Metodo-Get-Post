using AutomacaoAltoroJRestAPI.Services;
using Xunit;
using Xunit.Abstractions;

namespace AutomacaoAltoroJRestAPI.Tests
{
    public class AdminTest
    {
        private readonly ITestOutputHelper output;

        public AdminTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Validate_AdminAddUser()
        {
            new AdminServiceWorkFlow(output).Validate_AdminAddUser(CustomConfigurationProvider.GetSection("Token"), CustomConfigurationProvider.GetSection("AdminAddUser"));
        }
        [Fact]
        public void Validate_AdminChangePassword()
        {
            new AdminServiceWorkFlow(output).Validate_AdminChangePassword(CustomConfigurationProvider.GetSection("Token"), CustomConfigurationProvider.GetSection("AdminAddUser"));
        }
    }
}
