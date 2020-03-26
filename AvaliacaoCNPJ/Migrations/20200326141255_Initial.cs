using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AvaliacaoCNPJ.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Billing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Free = table.Column<bool>(nullable: false),
                    database = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApiObjeto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    BillingId = table.Column<int>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Abertura = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Fantasia = table.Column<string>(nullable: true),
                    Natureza_juridica = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemnto = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true),
                    Uf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Efr = table.Column<string>(nullable: true),
                    Situacao = table.Column<string>(nullable: true),
                    Data_situacao = table.Column<string>(nullable: true),
                    Motivo_situacao = table.Column<string>(nullable: true),
                    Situacao_especial = table.Column<string>(nullable: true),
                    Data_situacao_especial = table.Column<string>(nullable: true),
                    Capital_social = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiObjeto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApiObjeto_Billing_BillingId",
                        column: x => x.BillingId,
                        principalTable: "Billing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atividade_principal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    ApiObjetoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividade_principal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividade_principal_ApiObjeto_ApiObjetoId",
                        column: x => x.ApiObjetoId,
                        principalTable: "ApiObjeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atividades_secundarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    ApiObjetoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades_secundarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividades_secundarias_ApiObjeto_ApiObjetoId",
                        column: x => x.ApiObjetoId,
                        principalTable: "ApiObjeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Qsa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Qual = table.Column<string>(nullable: true),
                    pais_origem = table.Column<string>(nullable: true),
                    Nome_rep_legal = table.Column<string>(nullable: true),
                    Qual_rep_legal = table.Column<string>(nullable: true),
                    ApiObjetoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qsa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qsa_ApiObjeto_ApiObjetoId",
                        column: x => x.ApiObjetoId,
                        principalTable: "ApiObjeto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiObjeto_BillingId",
                table: "ApiObjeto",
                column: "BillingId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_principal_ApiObjetoId",
                table: "Atividade_principal",
                column: "ApiObjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_secundarias_ApiObjetoId",
                table: "Atividades_secundarias",
                column: "ApiObjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_Qsa_ApiObjetoId",
                table: "Qsa",
                column: "ApiObjetoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atividade_principal");

            migrationBuilder.DropTable(
                name: "Atividades_secundarias");

            migrationBuilder.DropTable(
                name: "Qsa");

            migrationBuilder.DropTable(
                name: "ApiObjeto");

            migrationBuilder.DropTable(
                name: "Billing");
        }
    }
}
