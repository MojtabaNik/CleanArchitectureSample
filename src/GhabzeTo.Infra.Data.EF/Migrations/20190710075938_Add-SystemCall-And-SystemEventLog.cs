using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GhabzeTo.Infra.Data.EF.Migrations
{
    public partial class AddSystemCallAndSystemEventLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemCall",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    InputWay = table.Column<string>(nullable: true),
                    InputData = table.Column<string>(nullable: true),
                    InputMetaData = table.Column<string>(nullable: true),
                    Output = table.Column<string>(nullable: true),
                    CreateDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemCall", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemEventLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    FirstCallerInfo = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    CreateDateTime = table.Column<DateTime>(nullable: false),
                    SystemEventLogType = table.Column<int>(nullable: false),
                    SystemCallId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemEventLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemEventLog_SystemCall_SystemCallId",
                        column: x => x.SystemCallId,
                        principalTable: "SystemCall",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SystemEventLog_SystemCallId",
                table: "SystemEventLog",
                column: "SystemCallId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemEventLog");

            migrationBuilder.DropTable(
                name: "SystemCall");
        }
    }
}
