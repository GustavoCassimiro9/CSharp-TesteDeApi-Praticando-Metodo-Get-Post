using AutomacaoAltoroJRestAPI.Services;
using Xunit;
using Xunit.Abstractions;

namespace AutomacaoAltoroJRestAPI.Tests
{
    public class FeedbackTest
    {
        private readonly ITestOutputHelper output;

        public FeedbackTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Validate_FeedbackSubmit()
        {
            new FeedbackServiceWorkFlow(output).Validate_FeedbackSubmit(CustomConfigurationProvider.GetSection("FeedbackSubmit"));
        }
    }
}
