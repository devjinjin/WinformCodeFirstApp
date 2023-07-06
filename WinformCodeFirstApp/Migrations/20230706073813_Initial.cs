using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinformCodeFirstApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diags",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bV = table.Column<int>(type: "int", nullable: true),
                    bC = table.Column<short>(type: "smallint", nullable: true),
                    vehS = table.Column<byte>(type: "tinyint", nullable: true),
                    tht = table.Column<byte>(type: "tinyint", nullable: true),
                    tarT = table.Column<byte>(type: "tinyint", nullable: true),
                    actT = table.Column<byte>(type: "tinyint", nullable: false),
                    watT = table.Column<short>(type: "smallint", nullable: true),
                    mcufT = table.Column<short>(type: "smallint", nullable: true),
                    coilT = table.Column<short>(type: "smallint", nullable: true),
                    b0T = table.Column<short>(type: "smallint", nullable: true),
                    b1T = table.Column<short>(type: "smallint", nullable: true),
                    b0fT = table.Column<short>(type: "smallint", nullable: true),
                    b1fT = table.Column<short>(type: "smallint", nullable: true),
                    soc0 = table.Column<byte>(type: "tinyint", nullable: true),
                    soc1 = table.Column<byte>(type: "tinyint", nullable: true),
                    avaD = table.Column<int>(type: "int", nullable: true),
                    brkB = table.Column<bool>(type: "bit", nullable: false),
                    brkB_T = table.Column<long>(type: "bigint", nullable: true),
                    regB = table.Column<bool>(type: "bit", nullable: true),
                    regB_T = table.Column<long>(type: "bigint", nullable: true),
                    bstS = table.Column<byte>(type: "tinyint", nullable: true),
                    bstS_T = table.Column<long>(type: "bigint", nullable: true),
                    bms0S = table.Column<byte>(type: "tinyint", nullable: true),
                    bms0S_T = table.Column<long>(type: "bigint", nullable: true),
                    bms1S = table.Column<byte>(type: "tinyint", nullable: true),
                    bsm1S_T = table.Column<long>(type: "bigint", nullable: true),
                    mcuS = table.Column<byte>(type: "tinyint", nullable: true),
                    mcuS_T = table.Column<long>(type: "bigint", nullable: true),
                    vcuS = table.Column<byte>(type: "tinyint", nullable: true),
                    vcuS_T = table.Column<long>(type: "bigint", nullable: true),
                    err = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    err_T = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Drivings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    raN = table.Column<int>(type: "int", nullable: true),
                    rdN = table.Column<int>(type: "int", nullable: true),
                    avDS = table.Column<byte>(type: "tinyint", nullable: true),
                    mxDS = table.Column<byte>(type: "tinyint", nullable: true),
                    aveE = table.Column<byte>(type: "tinyint", nullable: true),
                    idlT = table.Column<int>(type: "int", nullable: true),
                    driD = table.Column<float>(type: "real", nullable: true),
                    totD = table.Column<long>(type: "bigint", nullable: true),
                    onT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    offT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mxWT = table.Column<short>(type: "smallint", nullable: true),
                    mxCT = table.Column<short>(type: "smallint", nullable: true),
                    mxMT = table.Column<short>(type: "smallint", nullable: true),
                    mxTA = table.Column<byte>(type: "tinyint", nullable: true),
                    mnTA = table.Column<byte>(type: "tinyint", nullable: true),
                    brkN = table.Column<int>(type: "int", nullable: true),
                    ewpT = table.Column<int>(type: "int", nullable: true),
                    sopT = table.Column<int>(type: "int", nullable: true),
                    limB = table.Column<int>(type: "int", nullable: true),
                    dm1T = table.Column<byte>(type: "tinyint", nullable: true),
                    dm2T = table.Column<byte>(type: "tinyint", nullable: true),
                    dm3T = table.Column<byte>(type: "tinyint", nullable: true),
                    mxMR = table.Column<short>(type: "smallint", nullable: true),
                    mxb1T = table.Column<short>(type: "smallint", nullable: true),
                    mnb1T = table.Column<short>(type: "smallint", nullable: true),
                    mxb2T = table.Column<short>(type: "smallint", nullable: true),
                    mnb2T = table.Column<short>(type: "smallint", nullable: true),
                    b1lf = table.Column<byte>(type: "tinyint", nullable: true),
                    b2lf = table.Column<byte>(type: "tinyint", nullable: true),
                    mxbV = table.Column<byte>(type: "tinyint", nullable: true),
                    mnbV = table.Column<byte>(type: "tinyint", nullable: true),
                    mxbc0V = table.Column<byte>(type: "tinyint", nullable: true),
                    mnbc0V = table.Column<byte>(type: "tinyint", nullable: true),
                    mxbc1V = table.Column<byte>(type: "tinyint", nullable: true),
                    mnbc1V = table.Column<byte>(type: "tinyint", nullable: true),
                    bcID = table.Column<long>(type: "bigint", nullable: true),
                    bc = table.Column<short>(type: "smallint", nullable: true),
                    mcc = table.Column<short>(type: "smallint", nullable: true),
                    bcc = table.Column<short>(type: "smallint", nullable: true),
                    sbV = table.Column<int>(type: "int", nullable: true),
                    kyID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soc0 = table.Column<byte>(type: "tinyint", nullable: true),
                    soc1 = table.Column<byte>(type: "tinyint", nullable: true),
                    avaD = table.Column<int>(type: "int", nullable: true),
                    tp0 = table.Column<byte>(type: "tinyint", nullable: true),
                    tp1 = table.Column<byte>(type: "tinyint", nullable: true),
                    glatI = table.Column<decimal>(type: "decimal(10,6)", nullable: true),
                    glatD = table.Column<short>(type: "smallint", nullable: true),
                    glonI = table.Column<decimal>(type: "decimal(10,6)", nullable: true),
                    glonD = table.Column<short>(type: "smallint", nullable: true),
                    gpsS = table.Column<bool>(type: "bit", nullable: true),
                    _lock = table.Column<bool>(type: "bit", nullable: true),
                    b1ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    b2ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mstat = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diags");

            migrationBuilder.DropTable(
                name: "Drivings");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
