using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

namespace LeitorNfe.Core.Models;


[XmlRoot(ElementName = "nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
public class NFeProc
{
    public int Id {get; set;}
    
    [XmlElement(ElementName = "NFe")]
    public NFe? NFe { get; set; }

}


[XmlRoot(ElementName = "NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
public class NFe
{
    public int Id {get; set;}
    
    [XmlElement(ElementName = "infNFe")]
    public InfNFe? InfNFe { get; set; }

    [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public Signature? Signature { get; set; }
}

public class InfNFe
{

    public int Id {get; set;}

    [XmlElement(ElementName = "ide")]
    public Ide? Ide { get; set; }

    [XmlElement(ElementName = "emit")]
    public Emit? Emit { get; set; }

    [XmlElement(ElementName = "dest")]
    public Dest? Dest { get; set; }

    [XmlElement(ElementName = "det")]
    public List<Det>? Det { get; set; }

    [XmlElement(ElementName = "total")]
    public Total? Total { get; set; }

    [XmlElement(ElementName = "transp")]
    public Transp? Transp { get; set; }

    [XmlElement(ElementName = "cobr")]
    public Cobr? Cobr { get; set; }

    [XmlElement(ElementName = "infAdic")]
    public InfAdic? InfAdic { get; set; }

    [XmlElement(ElementName = "infRespTec")]
    public InfRespTec? InfRespTec { get; set; }
}


[XmlRoot(ElementName = "fat")]
public class Fat
{
    public int Id {get; set;}
    
    [XmlElement(ElementName = "nFat")]
    public string? NFat { get; set; }

    [XmlElement(ElementName = "vOrig")]
    public string? VOrig { get; set; }

    [XmlElement(ElementName = "vDesc")]
    public string? VDesc { get; set; }

    [XmlElement(ElementName = "vLiq")]
    public string? VLiq { get; set; }
}

[XmlRoot(ElementName = "dup")]
public class Dup
{
    public int Id {get; set;}

    [XmlElement(ElementName = "nDup")]
    public string? NDup { get; set; }

    [XmlElement(ElementName = "dVenc")]
    public string? DVenc { get; set; }

    [XmlElement(ElementName = "vDup")]
    public string? VDup { get; set; }
}

[XmlRoot(ElementName = "cobr")]
public class Cobr
{
    public int Id {get; set;}

    [XmlElement(ElementName = "fat")]
    public Fat? Fat { get; set; }

    [XmlElement(ElementName = "dup")]
    public List<Dup>? Dup { get; set; }
}

[XmlRoot(ElementName = "InfAdic")]
public class InfAdic 
{
    public int Id {get; set;}
    public string? infCpl {get; set;}
}

[XmlRoot(ElementName = "ide")]
public class Ide
{
    public int Id {get; set;}
    public string? cUF { get; set; }
    public string? cNF { get; set; }
    public string? natOp { get; set; }
    public string? mod { get; set; }
    public string? serie { get; set; }
    public string? nNF { get; set; }
    public string? dhEmi { get; set; }
    public string? dhSaiEnt { get; set; }
    public string? tpNF { get; set; }
    public string? idDest { get; set; }
    public string? cMunFG { get; set; }
    public string? tpImp { get; set; }
    public string? tpEmis { get; set; }
    public string? cDV { get; set; }
    public string? tpAmb { get; set; }
    public string? finNFe { get; set; }
    public string? indFinal { get; set; }
    public string? indPres { get; set; }
    public string? procEmi { get; set; }
    public string? verProc { get; set; }
}

[XmlRoot(ElementName = "enderEmit")]
public class EnderEmit
{
    public int Id {get; set;}
    public string? xLgr { get; set; }
    public string? nro { get; set; }
    public string? xBairro { get; set; }
    public string? cMun { get; set; }
    public string? xMun { get; set; }
    public string? UF { get; set; }
    public string? CEP { get; set; }
    public string? cPais { get; set; }
    public string? xPais { get; set; }
    public string? fone { get; set; }
}

[XmlRoot(ElementName = "emit")]
public class Emit
{

    public int Id {get; set;}
    public string? CNPJ { get; set; }
    public string? xNome { get; set; }
    public string? xFant { get; set; }
    public EnderEmit? enderEmit { get; set; }
    public string? IE { get; set; }
    public string? CRT { get; set; }
}

[XmlRoot(ElementName = "enderDest")]
public class EnderDest
{
    public int Id {get; set;}
    public string? xLgr { get; set; }
    public string? nro { get; set; }
    public string? xBairro { get; set; }
    public string? cMun { get; set; }
    public string? xMun { get; set; }
    public string? UF { get; set; }
    public string? CEP { get; set; }
    public string? cPais { get; set; }
    public string? xPais { get; set; }
    public string? fone { get; set; }
}

[XmlRoot(ElementName = "dest")]
public class Dest
{
    public int Id {get; set;}
    public string? CPF { get; set; }
    public string? xNome { get; set; }
    public EnderDest? enderDest { get; set; }
    public string? indIEDest { get; set; }
    public string? IE { get; set; }
    public string? email { get; set; }
}

[XmlRoot(ElementName = "prod")]
public class Prod
{

    public int Id {get; set;}
    public string? cProd { get; set; }
    public string? cEAN { get; set; }
    public string? xProd { get; set; }
    public string? NCM { get; set; }
    public string? CFOP { get; set; }
    public string? uCom { get; set; }
    public string? qCom { get; set; }
    public string? vUnCom { get; set; }
    public string? vProd { get; set; }
    public string? cEANTrib { get; set; }
    public string? uTrib { get; set; }
    public string? qTrib { get; set; }
    public string? vUnTrib { get; set; }
    public string? indTot { get; set; }
    public string? xPed { get; set; }
    public string? nItemPed { get; set; }
}

[XmlRoot(ElementName = "det")]
public class Det
{
    public int Id {get; set;}
    [XmlElement(ElementName = "prod")]
    public Prod? Prod { get; set; }

    [XmlElement(ElementName = "imposto")]
    public Imposto? Imposto { get; set; }
}

[XmlRoot(ElementName = "imposto")]
public class Imposto
{
    public int Id {get; set;}
    [XmlElement(ElementName = "vTotTrib")]
    public string? VTotTrib { get; set; }

    [XmlElement(ElementName = "ICMS")]
    public ICMS? ICMS { get; set; }

    [XmlElement(ElementName = "IPI")]
    public IPI? IPI { get; set; }
}

[XmlRoot(ElementName = "ICMS")]
public class ICMS 
{
    public int Id {get; set;}
    [XmlElement(ElementName = "ICMSSN102")]
    public ICMSSN102? ICMSSN102 {get;set;}
}


[XmlRoot(ElementName = "ICMSSN102")]
public class ICMSSN102 
{
    public int Id {get; set;}
    [XmlElement(ElementName = "orig")]
    public string? Orig {get;set;}

    [XmlElement(ElementName = "CSOSN")]
    public string? CSOSN {get;set;}
}

public class IPI {
    public int Id {get; set;}
    public string? cEnq {get;set;}
    public IPINT? IPINT {get;set;}
}

public class IPINT {
    public int Id {get; set;}
    public string? CST {get;set;}
}

[XmlRoot(ElementName = "infRespTec")]
public class InfRespTec
{

    public int Id {get; set;}
    public string? CNPJ { get; set; }
    public string? xContato { get; set; }
    public string? email { get; set; }
    public string? fone { get; set; }
}

[XmlRoot(ElementName = "vol")]
public class Vol
{
    public int Id {get; set;}

    [XmlElement(ElementName = "qVol")]
    public string? QVol { get; set; }
}

[XmlRoot(ElementName = "transp")]
public class Transp
{
    public int Id {get; set;}

    [XmlElement(ElementName = "modFrete")]
    public string? ModFrete { get; set; }

    [XmlElement(ElementName = "vol")]
    public Vol? Vol { get; set; }
}

[XmlRoot(ElementName = "total")]
public class Total
{
    public int Id {get; set;}

    [XmlElement(ElementName = "ICMSTot")]
    public ICMSTot? ICMSTot { get; set; }
}

[XmlRoot(ElementName = "ICMSTot")]
public class ICMSTot
{
    public int Id {get; set;}

    [XmlElement(ElementName = "vBC")]
    public string? VBC { get; set; }

    [XmlElement(ElementName = "vICMS")]
    public string? VICMS { get; set; }

    [XmlElement(ElementName = "vICMSDeson")]
    public string? VICMSDeson { get; set; }

    [XmlElement(ElementName = "vFCPUFDest")]
    public string? VFCPUFDest { get; set; }

    [XmlElement(ElementName = "vICMSUFDest")]
    public string? VICMSUFDest { get; set; }

    [XmlElement(ElementName = "vICMSUFRemet")]
    public string? VICMSUFRemet { get; set; }

    [XmlElement(ElementName = "vFCP")]
    public string? VFCP { get; set; }

    [XmlElement(ElementName = "vBCST")]
    public string? VBCST { get; set; }

    [XmlElement(ElementName = "vST")]
    public string? VST { get; set; }

    [XmlElement(ElementName = "vFCPST")]
    public string? VFCPST { get; set; }

    [XmlElement(ElementName = "vFCPSTRet")]
    public string? VFCPSTRet { get; set; }

    [XmlElement(ElementName = "vProd")]
    public string? VProd { get; set; }

    [XmlElement(ElementName = "vFrete")]
    public string? VFrete { get; set; }

    [XmlElement(ElementName = "vSeg")]
    public string? VSeg { get; set; }

    [XmlElement(ElementName = "vDesc")]
    public string? VDesc { get; set; }

    [XmlElement(ElementName = "vII")]
    public string? VII { get; set; }

    [XmlElement(ElementName = "vIPI")]
    public string? VIPI { get; set; }

    [XmlElement(ElementName = "vIPIDevol")]
    public string? VIPIDevol { get; set; }

    [XmlElement(ElementName = "vPIS")]
    public string? VPIS { get; set; }

    [XmlElement(ElementName = "vCOFINS")]
    public string? VCOFINS { get; set; }

    [XmlElement(ElementName = "vOutro")]
    public string? VOutro { get; set; }

    [XmlElement(ElementName = "vNF")]
    public string? VNF { get; set; }
}



[XmlRoot(ElementName = "Signature")]
public class Signature
{
    [XmlAttribute(AttributeName = "Id", Namespace = "http://www.w3.org/2000/xmlns/")]
    public int Id {get; set;}

    [XmlElement(ElementName = "SignedInfo")]
    public SignedInfo? SignedInfo { get; set; }

    [XmlElement(ElementName = "SignatureValue")]
    public string? SignatureValue { get; set; }

    [XmlElement(ElementName = "KeyInfo")]
    public KeyInfo? KeyInfo { get; set; }



}


[XmlRoot(ElementName = "SignedInfo")]
public class SignedInfo
{
    public int Id {get; set;}

    [XmlElement(ElementName = "CanonicalizationMethod")]
    public CanonicalizationMethod? CanonicalizationMethod { get; set; }

    [XmlElement(ElementName = "SignatureMethod")]
    public SignatureMethod? SignatureMethod { get; set; }

    [XmlElement(ElementName = "Reference")]
    public Reference? Reference { get; set; }
}

public class CanonicalizationMethod
{

    public int Id {get; set;}

    [XmlAttribute(AttributeName = "Algorithm")]
    public string? Algorithm { get; set; }
}

public class SignatureMethod
{

    public int Id {get; set;}


    [XmlAttribute(AttributeName = "Algorithm")]
    public string? Algorithm { get; set; }
}

public class Reference
{
    public int Id {get; set;}

    [XmlAttribute(AttributeName = "URI")]
    public string? URI { get; set; }

    [XmlElement(ElementName = "Transforms")]
    public Transforms? Transforms { get; set; }

    [XmlElement(ElementName = "DigestMethod")]
    public DigestMethod? DigestMethod { get; set; }

    [XmlElement(ElementName = "DigestValue")]
    public string? DigestValue { get; set; }
}

public class Transforms
{
    public int Id {get; set;}

    [XmlElement(ElementName = "Transform")]
    public Transform? Transform { get; set; }
}

public class Transform
{
    public int Id {get; set;}

    [XmlElement(ElementName = "Algorithm")]
    public string? Algorithm { get; set; }
}

public class DigestMethod
{
    public int Id {get; set;}

    [XmlAttribute(AttributeName = "Algorithm")]
    public string? Algorithm { get; set; }
}
public class KeyInfo
{
    public int Id {get; set;}

    [XmlElement(ElementName = "X509Data")]
    public X509Data? X509Data { get; set; }
}

public class X509Data
{
    public int Id {get; set;}
    
    [XmlElement(ElementName = "X509Certificate")]
    public string? X509Certificate { get; set; }
}