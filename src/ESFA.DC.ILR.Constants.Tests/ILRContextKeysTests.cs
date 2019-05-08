using FluentAssertions;
using Xunit;

namespace ESFA.DC.ILR.Constants.Tests
{
    public class ILRContextKeysTests
    {
        [InlineData(ILRContextKeys.Container, "Container")]
        [InlineData(ILRContextKeys.Filename, "Filename")]
        [InlineData(ILRContextKeys.OriginalFilename, "OriginalFilename")]
        [InlineData(ILRContextKeys.ValidationErrors, "ValidationErrors")]
        [Theory]
        public void ILRContextKeyValue(string actual, string expected)
        {
            actual.Should().Be(expected);
        }
    }
}
