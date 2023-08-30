using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KanbanNET.Data.Migrations
{
    /// <inheritdoc />
    public partial class InclusaoTabelasIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    BoardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1024)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.BoardId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "CardListas",
                columns: table => new
                {
                    CardListaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Ordem = table.Column<short>(type: "smallint", nullable: false),
                    BoardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardListas", x => x.CardListaId);
                    table.ForeignKey(
                        name: "FK_CardListas_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoardUsuario",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardUsuario", x => new { x.BoardId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_BoardUsuario_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoardUsuario_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1024)", nullable: false),
                    Ordem = table.Column<short>(type: "smallint", nullable: false),
                    CardListaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_CardListas_CardListaId",
                        column: x => x.CardListaId,
                        principalTable: "CardListas",
                        principalColumn: "CardListaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardComentarios",
                columns: table => new
                {
                    CardComentarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comentario = table.Column<string>(type: "ntext", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardComentarios", x => x.CardComentarioId);
                    table.ForeignKey(
                        name: "FK_CardComentarios_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardComentarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardUsuario_UsuarioId",
                table: "BoardUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CardComentarios_CardId",
                table: "CardComentarios",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardComentarios_UsuarioId",
                table: "CardComentarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CardListas_BoardId",
                table: "CardListas",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardListaId",
                table: "Cards",
                column: "CardListaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardUsuario");

            migrationBuilder.DropTable(
                name: "CardComentarios");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CardListas");

            migrationBuilder.DropTable(
                name: "Boards");
        }
    }
}
