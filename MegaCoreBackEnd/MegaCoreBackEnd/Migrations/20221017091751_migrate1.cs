using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaCoreBackEnd.Migrations
{
    public partial class migrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ms_storage_location",
                schema: "dbo",
                columns: table => new
                {
                    location_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    location_name = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_storage_location", x => x.location_id);
                });

            migrationBuilder.CreateTable(
                name: "tr_bpkb",
                schema: "dbo",
                columns: table => new
                {
                    agreement_number = table.Column<string>(type: "varchar(100)", nullable: false),
                    location_id = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tr_bpkb", x => x.agreement_number);
                    table.ForeignKey(
                        name: "FK_tr_bpkb_ms_storage_location_location_id",
                        column: x => x.location_id,
                        principalSchema: "dbo",
                        principalTable: "ms_storage_location",
                        principalColumn: "location_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tr_bpkb_location_id",
                schema: "dbo",
                table: "tr_bpkb",
                column: "location_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tr_bpkb",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ms_storage_location",
                schema: "dbo");
        }
    }
}
