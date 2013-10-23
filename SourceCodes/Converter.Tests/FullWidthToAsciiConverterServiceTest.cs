using Converter.Services;
using Converter.Services.Interfaces;
using NUnit.Framework;
using System.Linq;

namespace Converter.Tests
{
    [TestFixture]
    public class FullWidthToAsciiConverterServiceTest
    {
        private IConverterHelper _helper;
        private BaseConverterService _service;

        #region SetUp / TearDown

        [SetUp]
        public void Init()
        {
            this._helper = new ConverterHelper();
            this._service = new FullWidthToAsciiConverterService(this._helper);
        }

        [TearDown]
        public void Dispose()
        {
            this._service.Dispose();
            this._helper.Dispose();
        }

        #endregion SetUp / TearDown

        #region Tests

        [Test]
        [TestCase("（ＦＯＲ　ＦＣＴ）　", "(FOR FCT) ")]
        public void ConvertFullWidthToAscii_SendFullWidth_ReturnAsciiConverted(string original, string expected)
        {
            var result = this._service.Convert(original).First();
            Assert.AreEqual(expected, result);
        }

        #endregion Tests
    }
}