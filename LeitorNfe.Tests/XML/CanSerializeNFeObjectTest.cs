
using System.IO;
using System.Xml.Serialization;
using Xunit;
using LeitorNfe.Core.Models;

namespace LeitorNfe.XML.Tests
{
    public class CanSerializeNFeObjectTest
    {

        [Fact]
        public void CanSerializeNFeObject()
        {
            // Arrange
            var nfe = new NFe
            {
                InfNFe = new InfNFe
                {
                    Ide = new Ide
                    {
                        Id = 1,
                        cUF = "35",
                        cNF = "12345678",
                    },
                    Emit = new Emit
                    {
                        CNPJ = "12345678901234",
                        xNome = "Company Name",
                    },
                    Dest = new Dest
                    {
                        CPF = "12345678901",
                        xNome = "Customer Name",
                    },
                },
                Signature = new Signature
                {
                    SignedInfo = new SignedInfo
                    {
                        CanonicalizationMethod = new CanonicalizationMethod
                        {
                            Algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315",
                        },
                        SignatureMethod = new SignatureMethod
                        {
                            Algorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1",
                        },
                        Reference = new Reference
                        {
                            URI = "#Id",
                            Transforms = new Transforms
                            {
                                Transform = new Transform
                                {
                                    Algorithm = "http://www.w3.org/2000/09/xmldsig#enveloped-signature",
                                },
                            },
                            DigestMethod = new DigestMethod
                            {
                                Algorithm = "http://www.w3.org/2000/09/xmldsig#sha1",
                            },
                            // Set other properties accordingly
                        },
                        // Set other properties accordingly
                    },
                    SignatureValue = "abc123",
                    KeyInfo = new KeyInfo
                    {
                        X509Data = new X509Data
                        {
                            X509Certificate = "xyz456",
                        },
                    },
                },
            };

            var serializer = new XmlSerializer(typeof(NFe));
            var stringWriter = new StringWriter();

            // Act
            serializer.Serialize(stringWriter, nfe);
            var xmlString = stringWriter.ToString();

            // Assert
            Assert.NotNull(xmlString);
            // Add more assertions based on your specific XML structure and data
        }

    }
}
