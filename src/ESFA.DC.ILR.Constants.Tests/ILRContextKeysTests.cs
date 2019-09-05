using FluentAssertions;
using Xunit;

namespace ESFA.DC.ILR.Constants.Tests
{
    public class ILRContextKeysTests
    {
        [InlineData(ILRContextKeys.AppEarnHistoryDatabaseConnectionString, "AppEarnHistoryDatabaseConnectionString")]
        [InlineData(ILRContextKeys.CollectionYear, "CollectionYear")]
        [InlineData(ILRContextKeys.Container, "Container")]
        [InlineData(ILRContextKeys.Filename, "Filename")]
        [InlineData(ILRContextKeys.ReferenceDataFilename, "ReferenceDataFilename")]
        [InlineData(ILRContextKeys.FileSizeInBytes, "FileSizeInBytes")]
        [InlineData(ILRContextKeys.FundingFm81Output, "FundingFm81Output")]
        [InlineData(ILRContextKeys.FundingFm70Output, "FundingFm70Output")]
        [InlineData(ILRContextKeys.FundingFm36Output, "FundingFm36Output")]
        [InlineData(ILRContextKeys.FundingFm35Output, "FundingFm35Output")]
        [InlineData(ILRContextKeys.FundingFm25Output, "FundingFm25Output")]
        [InlineData(ILRContextKeys.FundingAlbOutput, "FundingAlbOutput")]
        [InlineData(ILRContextKeys.IlrDatabaseConnectionString, "IlrDatabaseConnectionString")]
        [InlineData(ILRContextKeys.IlrReferenceData, "IlrReferenceData")]
        [InlineData(ILRContextKeys.InvalidLearnRefNumbers, "InvalidLearnRefNumbers")]
        [InlineData(ILRContextKeys.InvalidLearnRefNumbersCount, "InvalidLearnRefNumbersCount")]
        [InlineData(ILRContextKeys.OriginalFilename, "OriginalFilename")]
        [InlineData(ILRContextKeys.ReturnPeriod, "ReturnPeriod")]
        [InlineData(ILRContextKeys.ReportTasks, "ReportTasks")]
        [InlineData(ILRContextKeys.ReportOutputFileNames, "ReportOutputFileNames")]
        [InlineData(ILRContextKeys.Ukprn, "UkPrn")]
        [InlineData(ILRContextKeys.ValidLearnRefNumbers, "ValidLearnRefNumbers")]
        [InlineData(ILRContextKeys.ValidLearnRefNumbersCount, "ValidLearnRefNumbersCount")]
        [InlineData(ILRContextKeys.ValidationErrors, "ValidationErrors")]
        [InlineData(ILRContextKeys.ValidationErrorLookups, "ValidationErrorLookups")]
        [InlineData(ILRContextKeys.ValidationTotalErrorCount, "ValidationTotalErrorCount")]
        [InlineData(ILRContextKeys.ValidationTotalWarningCount, "ValidationTotalWarningCount")]
        [Theory]
        public void ILRContextKeyValue(string actual, string expected)
        {
            actual.Should().Be(expected);
        }
    }
}
