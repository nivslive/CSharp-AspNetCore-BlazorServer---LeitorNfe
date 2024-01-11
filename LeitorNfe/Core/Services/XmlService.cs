using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Microsoft.AspNetCore.Hosting;
using LeitorNfe.Core.Models;
using System.Xml.Serialization;

namespace LeitorNfe.Core.Services;

public interface IXmlService
{
    List<NFe> ReadXMLAndConvertToObject(string xmlString);
    // void WriteXML(List<Nfe> nfes, string fileName);
}


public class XmlService : IXmlService
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public XmlService(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    public List<NFe> ReadXMLAndConvertToObject(string xmlString)
    {
        List<NFe> NfeList = new List<NFe>();

        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);

            if (xmlDoc.DocumentElement?.Name != "nfeProc")
            {
                throw new InvalidOperationException("Invalid XML format. Expected 'nfeProc' as the root element.");
            }

            foreach (XmlNode nfeNode in xmlDoc.DocumentElement.ChildNodes)
            {
                if (nfeNode.Name == "NFe")
                {
                    // Create an instance of the XmlSerializer with the appropriate type
                    XmlSerializer serializer = new XmlSerializer(typeof(NFe));

                    // Deserialize the XmlNode into an instance of the Nfe class
                    NFe nfe = (NFe)serializer.Deserialize(new XmlNodeReader(nfeNode));

                    NfeList.Add(nfe);
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions during XML reading
            throw new InvalidOperationException($"Error reading XML: {ex.Message}");
        }

        return NfeList;
    }


    // public void WriteXML(List<Nfe> nfes, string fileName)
    // {
    //     XmlDocument xmlDoc = new XmlDocument();

    //     XmlElement root = xmlDoc.CreateElement("Nfe");
    //     xmlDoc.AppendChild(root);

    //     foreach (var nfe in nfes)
    //     {
    //         XmlElement element = xmlDoc.CreateElement("Nfe");

    //         XmlElement idElement = xmlDoc.CreateElement("Id");

    //         // Add other properties as needed

    //         root.AppendChild(element);
    //     }

    //     // Get the path to the wwwroot/xml folder
    //     string wwwrootPath = _webHostEnvironment.WebRootPath;
    //     string xmlFolderPath = Path.Combine(wwwrootPath, "xml");

    //     // Check if the xml folder exists, if not, create it
    //     if (!Directory.Exists(xmlFolderPath))
    //     {
    //         Directory.CreateDirectory(xmlFolderPath);
    //     }

    //     // Combine the folder path with the file name
    //     string xmlFilePath = Path.Combine(xmlFolderPath, fileName);

    //     // Save the XML file
    //     xmlDoc.Save(xmlFilePath);
    // }
}
