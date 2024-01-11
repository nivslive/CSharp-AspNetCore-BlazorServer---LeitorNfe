using NUnit.Framework;
using System.IO;

namespace LeitorNfe.XML.Tests
{
    [TestFixture]
    public class CanDeserializeNFeXmlTest
    {
        [Test]
        public void CanDeserializeNFeXmlTest()
        {
            // Arrange
            string xmlFilePath = "wwwroot/XML/000000024.xml";
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(NFe));

            // Act
            NFe result;

            using (var reader = new StreamReader(xmlFilePath))
            {
                result = (NFe)serializer.Deserialize(reader);
            }

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.InfNFe);
        }
    }
}
