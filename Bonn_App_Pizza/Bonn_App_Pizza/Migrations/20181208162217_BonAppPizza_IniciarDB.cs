using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bonn_App_Pizza.Migrations
{
    public partial class BonAppPizza_IniciarDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    IdPais = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NmPais = table.Column<string>(nullable: true),
                    SgPais = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "TiposLogradouros",
                columns: table => new
                {
                    IDTpLogradouro = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoLogradouro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposLogradouros", x => x.IDTpLogradouro);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    IdEstado = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NmEstado = table.Column<string>(nullable: true),
                    SgEstado = table.Column<string>(nullable: true),
                    PaisIdPais = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.IdEstado);
                    table.ForeignKey(
                        name: "FK_Estados_Pais_PaisIdPais",
                        column: x => x.PaisIdPais,
                        principalTable: "Pais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    IdMunicipio = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NmMunicipio = table.Column<string>(nullable: true),
                    EstadoIdEstado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.IdMunicipio);
                    table.ForeignKey(
                        name: "FK_Municipios_Estados_EstadoIdEstado",
                        column: x => x.EstadoIdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pizzarias",
                columns: table => new
                {
                    IdPizzaria = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDivulgacao = table.Column<string>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    Proprietario = table.Column<string>(nullable: true),
                    TpLogradouroIDTpLogradouro = table.Column<int>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    MunicipioIdMunicipio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzarias", x => x.IdPizzaria);
                    table.ForeignKey(
                        name: "FK_Pizzarias_Municipios_MunicipioIdMunicipio",
                        column: x => x.MunicipioIdMunicipio,
                        principalTable: "Municipios",
                        principalColumn: "IdMunicipio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzarias_TiposLogradouros_TpLogradouroIDTpLogradouro",
                        column: x => x.TpLogradouroIDTpLogradouro,
                        principalTable: "TiposLogradouros",
                        principalColumn: "IDTpLogradouro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estados_PaisIdPais",
                table: "Estados",
                column: "PaisIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_EstadoIdEstado",
                table: "Municipios",
                column: "EstadoIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzarias_MunicipioIdMunicipio",
                table: "Pizzarias",
                column: "MunicipioIdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzarias_TpLogradouroIDTpLogradouro",
                table: "Pizzarias",
                column: "TpLogradouroIDTpLogradouro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzarias");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "TiposLogradouros");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
