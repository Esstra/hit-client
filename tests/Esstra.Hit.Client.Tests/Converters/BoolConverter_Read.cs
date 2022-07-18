namespace Esstra.Hit.Client.Tests.Converters
{
    using Esstra.Hit.Client.Converters;

    using System.Text;
    using System.Text.Json;

    [TestClass]
    public class BoolConverter_Read
    {
        [TestMethod]
        [DataRow("{\"MyProperty\":1}", true)]
        [DataRow("{\"MyProperty\":0}", false)]
        [DataRow("{\"MyProperty\":null}", null)]
        public void When_ValueIsValid_Expect_ValidResult(string json, bool? expected)
        {
            var sut = new BoolConverter();

            var jsonBytes = Encoding.UTF8.GetBytes(json);
            var reader = new Utf8JsonReader(jsonBytes);

            reader.Read();
            reader.Read();
            reader.Read();

            var result = sut.Read(ref reader, typeof(bool?), new JsonSerializerOptions());

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void When_ValueIsInvalid_Expect_FormatException()
        {
            var sut = new BoolConverter();

            var jsonBytes = Encoding.UTF8.GetBytes("{\"MyProperty\":\"0\"}");
            var reader = new Utf8JsonReader(jsonBytes);

            reader.Read();
            reader.Read();
            reader.Read();

            _ = sut.Read(ref reader, typeof(bool?), new JsonSerializerOptions());
        }

        public class TestClass
        {
            public bool? MyProperty { get; set; }
        }
    }
}
