using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace MeedMarket.Migrations
{
    public partial class SqlScriptForElmah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Migrations\Elmah.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
           name: "ELMAH_Error");

            migrationBuilder.Sql("DROP PROCEDURE ELMAH_LogError");
            migrationBuilder.Sql("DROP PROCEDURE ELMAH_GetErrorXml");
            migrationBuilder.Sql("DROP PROCEDURE ELMAH_GetErrorsXml");

        }
    }
}
