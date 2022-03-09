using AutomacaoAltoroJRestAPI.Services;
using Xunit;
using Xunit.Abstractions;

namespace AutomacaoAltoroJRestAPI.Tests
{
    public class TransferTest
    {
        private readonly ITestOutputHelper output;

        public TransferTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Validate_Transfer()
        {
            new TransferServiceWorkFlow(output).Validate_Transfer(CustomConfigurationProvider.GetSection("Token"),CustomConfigurationProvider.GetSection("Transfer"));
        }
    }
}
