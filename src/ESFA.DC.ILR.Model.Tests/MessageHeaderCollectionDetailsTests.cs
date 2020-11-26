using FluentAssertions;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class MessageHeaderCollectionDetailsTests
    {
        [Fact]
        public void CollectionString()
        {
            var collectionDetails = new MessageHeaderCollectionDetails()
            {
                Collection = MessageHeaderCollectionDetailsCollection.ILR
            };

            collectionDetails.CollectionString.Should().Be("ILR");
        }

        [Fact]
        public void YearString()
        {
            var collectionDetails = new MessageHeaderCollectionDetails()
            {
                Year = MessageHeaderCollectionDetailsYear.Item2021
            };

            collectionDetails.YearString.Should().Be("2021");
        }
    }
}
