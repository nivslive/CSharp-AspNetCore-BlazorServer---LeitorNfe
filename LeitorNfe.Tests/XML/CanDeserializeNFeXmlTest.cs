using Xunit;
using System.IO;
using LeitorNfe.Core.Models;

namespace LeitorNfe.XML.Tests
{
    public class CanDeserializeNFeXmlTest
    {
        [Fact]
        public void CanDeserializeNFeXml()
        {
            // Arrange
            string xmlFilePath = Path.Combine( "..", "..",  "..", "..", "LeitorNfe", "wwwroot", "XML", "000038971.xml");
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(NFe));

            // Act
            NFe result;

            using (var reader = new StreamReader(xmlFilePath))
            {
                result = (NFe)serializer.Deserialize(reader);
            }

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.InfNFe);
        }
    }
}
