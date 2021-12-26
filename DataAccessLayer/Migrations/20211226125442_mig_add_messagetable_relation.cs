using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_messagetable_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message2s",
                columns: table => new
                {
                    messageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    senderID = table.Column<int>(type: "int", nullable: true),
                    receiverID = table.Column<int>(type: "int", nullable: true),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    messageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    messageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    messageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message2s", x => x.messageID);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_receiverID",
                        column: x => x.receiverID,
                        principalTable: "Writers",
                        principalColumn: "writerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_senderID",
                        column: x => x.senderID,
                        principalTable: "Writers",
                        principalColumn: "writerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_receiverID",
                table: "Message2s",
                column: "receiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_senderID",
                table: "Message2s",
                column: "senderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message2s");
        }
    }
}
