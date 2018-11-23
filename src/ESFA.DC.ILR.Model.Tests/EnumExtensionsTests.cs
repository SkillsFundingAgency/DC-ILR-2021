using System.Xml.Serialization;
using ESFA.DC.ILR.Model.Extension;
using FluentAssertions;
using Xunit;

namespace ESFA.DC.ILR.Model.Tests
{
    public class EnumExtensionsTests
    {
        public enum TestData
        {
            [XmlEnum("NoSpace")]
            NoSpace,

            [XmlEnum("Space Bar")]
            Space,

            NoAttribute,
        }

        [Fact]
        public void NoSpace()
        {
            TestData.NoSpace.XmlEnumToString().Should().Be("NoSpace");
        }

        [Fact]
        public void Space()
        {
            TestData.Space.XmlEnumToString().Should().Be("Space Bar");
        }

        [Fact]
        public void NoAttribute()
        {
            TestData.NoAttribute.XmlEnumToString().Should().Be("NoAttribute");
        }
    }
}
