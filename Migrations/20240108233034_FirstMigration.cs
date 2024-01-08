using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeitorNfe.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CanonicalizationMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Algorithm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanonicalizationMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DigestMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Algorithm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigestMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnderDest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    xLgr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xBairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cMun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xMun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cPais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xPais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderDest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnderEmit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    xLgr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xBairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cMun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xMun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cPais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xPais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderEmit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NFat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VOrig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VLiq = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ICMSSN102",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Orig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSOSN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICMSSN102", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ICMSTot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VICMS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VICMSDeson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFCPUFDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VICMSUFDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VICMSUFRemet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFCP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VBCST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFCPST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFCPSTRet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFrete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VSeg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VII = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIPI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIPIDevol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VCOFINS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VOutro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICMSTot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cUF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cNF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    natOp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nNF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dhEmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dhSaiEnt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tpNF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cMunFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tpImp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tpEmis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cDV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tpAmb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    finNFe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    indFinal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    indPres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    procEmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    verProc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ide", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfAdic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    infCpl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfAdic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfRespTec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xContato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfRespTec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IPINT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CST = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPINT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cEAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NCM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CFOP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uCom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qCom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vUnCom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cEANTrib = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uTrib = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qTrib = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vUnTrib = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    indTot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xPed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nItemPed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignatureMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Algorithm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignatureMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transform",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Algorithm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QVol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "X509Data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X509Certificate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X509Data", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enderDestId = table.Column<int>(type: "int", nullable: true),
                    indIEDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dest_EnderDest_enderDestId",
                        column: x => x.enderDestId,
                        principalTable: "EnderDest",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Emit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    xFant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enderEmitId = table.Column<int>(type: "int", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emit_EnderEmit_enderEmitId",
                        column: x => x.enderEmitId,
                        principalTable: "EnderEmit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cobr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cobr_Fat_FatId",
                        column: x => x.FatId,
                        principalTable: "Fat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ICMS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ICMSSN102Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICMS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ICMS_ICMSSN102_ICMSSN102Id",
                        column: x => x.ICMSSN102Id,
                        principalTable: "ICMSSN102",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Total",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ICMSTotId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Total", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Total_ICMSTot_ICMSTotId",
                        column: x => x.ICMSTotId,
                        principalTable: "ICMSTot",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IPI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cEnq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPINTId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPI_IPINT_IPINTId",
                        column: x => x.IPINTId,
                        principalTable: "IPINT",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransformId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transforms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transforms_Transform_TransformId",
                        column: x => x.TransformId,
                        principalTable: "Transform",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModFrete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transp_Vol_VolId",
                        column: x => x.VolId,
                        principalTable: "Vol",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KeyInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X509DataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyInfo_X509Data_X509DataId",
                        column: x => x.X509DataId,
                        principalTable: "X509Data",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NDup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DVenc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CobrId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dup_Cobr_CobrId",
                        column: x => x.CobrId,
                        principalTable: "Cobr",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Imposto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VTotTrib = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICMSId = table.Column<int>(type: "int", nullable: true),
                    IPIId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imposto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imposto_ICMS_ICMSId",
                        column: x => x.ICMSId,
                        principalTable: "ICMS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Imposto_IPI_IPIId",
                        column: x => x.IPIId,
                        principalTable: "IPI",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransformsId = table.Column<int>(type: "int", nullable: true),
                    DigestMethodId = table.Column<int>(type: "int", nullable: true),
                    DigestValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reference_DigestMethod_DigestMethodId",
                        column: x => x.DigestMethodId,
                        principalTable: "DigestMethod",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reference_Transforms_TransformsId",
                        column: x => x.TransformsId,
                        principalTable: "Transforms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InfNFe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeId = table.Column<int>(type: "int", nullable: true),
                    EmitId = table.Column<int>(type: "int", nullable: true),
                    DestId = table.Column<int>(type: "int", nullable: true),
                    TotalId = table.Column<int>(type: "int", nullable: true),
                    TranspId = table.Column<int>(type: "int", nullable: true),
                    CobrId = table.Column<int>(type: "int", nullable: true),
                    InfAdicId = table.Column<int>(type: "int", nullable: true),
                    InfRespTecId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfNFe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfNFe_Cobr_CobrId",
                        column: x => x.CobrId,
                        principalTable: "Cobr",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfNFe_Dest_DestId",
                        column: x => x.DestId,
                        principalTable: "Dest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfNFe_Emit_EmitId",
                        column: x => x.EmitId,
                        principalTable: "Emit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfNFe_Ide_IdeId",
                        column: x => x.IdeId,
                        principalTable: "Ide",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfNFe_InfAdic_InfAdicId",
                        column: x => x.InfAdicId,
                        principalTable: "InfAdic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfNFe_InfRespTec_InfRespTecId",
                        column: x => x.InfRespTecId,
                        principalTable: "InfRespTec",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfNFe_Total_TotalId",
                        column: x => x.TotalId,
                        principalTable: "Total",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfNFe_Transp_TranspId",
                        column: x => x.TranspId,
                        principalTable: "Transp",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignedInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanonicalizationMethodId = table.Column<int>(type: "int", nullable: true),
                    SignatureMethodId = table.Column<int>(type: "int", nullable: true),
                    ReferenceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignedInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignedInfo_CanonicalizationMethod_CanonicalizationMethodId",
                        column: x => x.CanonicalizationMethodId,
                        principalTable: "CanonicalizationMethod",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignedInfo_Reference_ReferenceId",
                        column: x => x.ReferenceId,
                        principalTable: "Reference",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignedInfo_SignatureMethod_SignatureMethodId",
                        column: x => x.SignatureMethodId,
                        principalTable: "SignatureMethod",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Det",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdId = table.Column<int>(type: "int", nullable: true),
                    ImpostoId = table.Column<int>(type: "int", nullable: true),
                    InfNFeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Det", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Det_Imposto_ImpostoId",
                        column: x => x.ImpostoId,
                        principalTable: "Imposto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Det_InfNFe_InfNFeId",
                        column: x => x.InfNFeId,
                        principalTable: "InfNFe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Det_Prod_ProdId",
                        column: x => x.ProdId,
                        principalTable: "Prod",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Signature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignedInfoId = table.Column<int>(type: "int", nullable: true),
                    SignatureValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signature_KeyInfo_KeyInfoId",
                        column: x => x.KeyInfoId,
                        principalTable: "KeyInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Signature_SignedInfo_SignedInfoId",
                        column: x => x.SignedInfoId,
                        principalTable: "SignedInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NFes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfNFeId = table.Column<int>(type: "int", nullable: true),
                    SignatureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NFes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NFes_InfNFe_InfNFeId",
                        column: x => x.InfNFeId,
                        principalTable: "InfNFe",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NFes_Signature_SignatureId",
                        column: x => x.SignatureId,
                        principalTable: "Signature",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NFesInStorage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NFeId = table.Column<int>(type: "int", nullable: false),
                    directory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NFesInStorage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NFesInStorage_NFes_NFeId",
                        column: x => x.NFeId,
                        principalTable: "NFes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cobr_FatId",
                table: "Cobr",
                column: "FatId");

            migrationBuilder.CreateIndex(
                name: "IX_Dest_enderDestId",
                table: "Dest",
                column: "enderDestId");

            migrationBuilder.CreateIndex(
                name: "IX_Det_ImpostoId",
                table: "Det",
                column: "ImpostoId");

            migrationBuilder.CreateIndex(
                name: "IX_Det_InfNFeId",
                table: "Det",
                column: "InfNFeId");

            migrationBuilder.CreateIndex(
                name: "IX_Det_ProdId",
                table: "Det",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_Dup_CobrId",
                table: "Dup",
                column: "CobrId");

            migrationBuilder.CreateIndex(
                name: "IX_Emit_enderEmitId",
                table: "Emit",
                column: "enderEmitId");

            migrationBuilder.CreateIndex(
                name: "IX_ICMS_ICMSSN102Id",
                table: "ICMS",
                column: "ICMSSN102Id");

            migrationBuilder.CreateIndex(
                name: "IX_Imposto_ICMSId",
                table: "Imposto",
                column: "ICMSId");

            migrationBuilder.CreateIndex(
                name: "IX_Imposto_IPIId",
                table: "Imposto",
                column: "IPIId");

            migrationBuilder.CreateIndex(
                name: "IX_InfNFe_CobrId",
                table: "InfNFe",
                column: "CobrId");

            migrationBuilder.CreateIndex(
                name: "IX_InfNFe_DestId",
                table: "InfNFe",
                column: "DestId");

            migrationBuilder.CreateIndex(
                name: "IX_InfNFe_EmitId",
                table: "InfNFe",
                column: "EmitId");

            migrationBuilder.CreateIndex(
                name: "IX_InfNFe_IdeId",
                table: "InfNFe",
                column: "IdeId");

            migrationBuilder.CreateIndex(
                name: "IX_InfNFe_InfAdicId",
                table: "InfNFe",
                column: "InfAdicId");

            migrationBuilder.CreateIndex(
                name: "IX_InfNFe_InfRespTecId",
                table: "InfNFe",
                column: "InfRespTecId");

            migrationBuilder.CreateIndex(
                name: "IX_InfNFe_TotalId",
                table: "InfNFe",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_InfNFe_TranspId",
                table: "InfNFe",
                column: "TranspId");

            migrationBuilder.CreateIndex(
                name: "IX_IPI_IPINTId",
                table: "IPI",
                column: "IPINTId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyInfo_X509DataId",
                table: "KeyInfo",
                column: "X509DataId");

            migrationBuilder.CreateIndex(
                name: "IX_NFes_InfNFeId",
                table: "NFes",
                column: "InfNFeId");

            migrationBuilder.CreateIndex(
                name: "IX_NFes_SignatureId",
                table: "NFes",
                column: "SignatureId");

            migrationBuilder.CreateIndex(
                name: "IX_NFesInStorage_NFeId",
                table: "NFesInStorage",
                column: "NFeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_DigestMethodId",
                table: "Reference",
                column: "DigestMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Reference_TransformsId",
                table: "Reference",
                column: "TransformsId");

            migrationBuilder.CreateIndex(
                name: "IX_Signature_KeyInfoId",
                table: "Signature",
                column: "KeyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Signature_SignedInfoId",
                table: "Signature",
                column: "SignedInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_SignedInfo_CanonicalizationMethodId",
                table: "SignedInfo",
                column: "CanonicalizationMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_SignedInfo_ReferenceId",
                table: "SignedInfo",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SignedInfo_SignatureMethodId",
                table: "SignedInfo",
                column: "SignatureMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Total_ICMSTotId",
                table: "Total",
                column: "ICMSTotId");

            migrationBuilder.CreateIndex(
                name: "IX_Transforms_TransformId",
                table: "Transforms",
                column: "TransformId");

            migrationBuilder.CreateIndex(
                name: "IX_Transp_VolId",
                table: "Transp",
                column: "VolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Det");

            migrationBuilder.DropTable(
                name: "Dup");

            migrationBuilder.DropTable(
                name: "NFesInStorage");

            migrationBuilder.DropTable(
                name: "Imposto");

            migrationBuilder.DropTable(
                name: "Prod");

            migrationBuilder.DropTable(
                name: "NFes");

            migrationBuilder.DropTable(
                name: "ICMS");

            migrationBuilder.DropTable(
                name: "IPI");

            migrationBuilder.DropTable(
                name: "InfNFe");

            migrationBuilder.DropTable(
                name: "Signature");

            migrationBuilder.DropTable(
                name: "ICMSSN102");

            migrationBuilder.DropTable(
                name: "IPINT");

            migrationBuilder.DropTable(
                name: "Cobr");

            migrationBuilder.DropTable(
                name: "Dest");

            migrationBuilder.DropTable(
                name: "Emit");

            migrationBuilder.DropTable(
                name: "Ide");

            migrationBuilder.DropTable(
                name: "InfAdic");

            migrationBuilder.DropTable(
                name: "InfRespTec");

            migrationBuilder.DropTable(
                name: "Total");

            migrationBuilder.DropTable(
                name: "Transp");

            migrationBuilder.DropTable(
                name: "KeyInfo");

            migrationBuilder.DropTable(
                name: "SignedInfo");

            migrationBuilder.DropTable(
                name: "Fat");

            migrationBuilder.DropTable(
                name: "EnderDest");

            migrationBuilder.DropTable(
                name: "EnderEmit");

            migrationBuilder.DropTable(
                name: "ICMSTot");

            migrationBuilder.DropTable(
                name: "Vol");

            migrationBuilder.DropTable(
                name: "X509Data");

            migrationBuilder.DropTable(
                name: "CanonicalizationMethod");

            migrationBuilder.DropTable(
                name: "Reference");

            migrationBuilder.DropTable(
                name: "SignatureMethod");

            migrationBuilder.DropTable(
                name: "DigestMethod");

            migrationBuilder.DropTable(
                name: "Transforms");

            migrationBuilder.DropTable(
                name: "Transform");
        }
    }
}
