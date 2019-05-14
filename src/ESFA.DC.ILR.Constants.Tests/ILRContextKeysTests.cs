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
        [InlineData(ILRContextKeys.FileSizeInBytes, "FileSizeInBytes")]
        [InlineData(ILRContextKeys.FundingFm81Output, "FundingFm81Output")]
        [InlineData(ILRContextKeys.FundingFm70Output, "FundingFm70Output")]
        [InlineData(ILRContextKeys.FundingFm36Output, "FundingFm36Output")]
        [InlineData(ILRContextKeys.FundingFm35Output, "FundingFm35Output")]
        [InlineData(ILRContextKeys.FundingFm25Output, "FundingFm25Output")]
        [InlineData(ILRContextKeys.FundingAlbOutput, "FundingAlbOutput")]
        [InlineData(ILRContextKeys.IlrDatabaseConnectionString, "IlrDatabaseConnectionString")]
        [InlineData(ILRContextKeys.InvalidLearnRefNumbersCount, "InvalidLearnRefNumbersCount")]
        [InlineData(ILRContextKeys.OriginalFilename, "OriginalFilename")]
        [InlineData(ILRContextKeys.ReturnPeriod, "ReturnPeriod")]
        [InlineData(ILRContextKeys.Ukprn, "Ukprn")]
        [InlineData(ILRContextKeys.ValidLearnRefNumbers, "ValidLearnRefNumbers")]
        [InlineData(ILRContextKeys.ValidLearnRefNumbersCount, "ValidLearnRefNumbersCount")]
        [InlineData(ILRContextKeys.ValidationErrors, "ValidationErrors")]
        [InlineData(ILRContextKeys.ValidationTotalErrorCount, "ValidationTotalErrorCount")]
        [InlineData(ILRContextKeys.ValidationTotalWarningCount, "ValidationTotalWarningCount")]
        [Theory]
        public void ILRContextKeyValue(string actual, string expected)
        {
            actual.Should().Be(expected);
        }


        public const string AppEarnHistoryDatabaseConnectionString = "AppEarnHistoryDatabaseConnectionString";
        public const string CollectionYear = "CollectionYear";
        public const string Container = "Container";
        public const string Filename = "Filename";
        public const string FileSizeInBytes = "FileSizeInBytes";
        public const string FundingFm81Output = "FundingFm81Output";
        public const string FundingFm70Output = "FundingFm70Output";
        public const string FundingFm36Output = "FundingFm36Output";
        public const string FundingFm35Output = "FundingFm35Output";
        public const string FundingFm25Output = "FundingFm25Output";
        public const string FundingAlbOutput = "FundingAlbOutput";
        public const string IlrDatabaseConnectionString = "IlrDatabaseConnectionString";
        public const string InvalidLearnRefNumbersCount = "InvalidLearnRefNumbersCount";
        public const string OriginalFilename = "OriginalFilename";
        public const string ReturnPeriod = "ReturnPeriod";
        public const string Ukprn = "Ukprn";
        public const string ValidLearnRefNumbers = "ValidLearnRefNumbers";
        public const string ValidLearnRefNumbersCount = "ValidLearnRefNumbersCount";
        public const string ValidationErrors = "ValidationErrors";
        public const string ValidationTotalErrorCount = "ValidationTotalErrorCount";
        public const string ValidationTotalWarningCount = "ValidationTotalWarningCount";
    }
}
