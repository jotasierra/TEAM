using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoEnvios.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cli_tipo_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_num_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fun_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fun_apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pro_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mer_alto = table.Column<float>(type: "real", nullable: true),
                    mer_largo = table.Column<float>(type: "real", nullable: true),
                    mer_ancho = table.Column<float>(type: "real", nullable: true),
                    mer_peso = table.Column<float>(type: "real", nullable: true),
                    mer_liquidarTarifa = table.Column<float>(type: "real", nullable: true),
                    mer_valorDeclarado = table.Column<float>(type: "real", nullable: true),
                    paq_peso = table.Column<float>(type: "real", nullable: true),
                    paq_liquidarTarifa = table.Column<float>(type: "real", nullable: true),
                    paq_valorDeclarado = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Envios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productoId = table.Column<int>(type: "int", nullable: true),
                    clienteId = table.Column<int>(type: "int", nullable: true),
                    cli_fac_pro_fechaEnvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fac_pro_origen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fac_pro_destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fac_pro_fechaEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fac_pro_contenido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fac_pro_remitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fac_pro_tipoCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fac_pro_tiempoEnvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cli_fac_pro_trayecto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Envios_Clientes_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Envios_Productos_productoId",
                        column: x => x.productoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    envioId = table.Column<int>(type: "int", nullable: true),
                    fac_num_factura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fac_liquidacion = table.Column<int>(type: "int", nullable: false),
                    fac_tipo_factura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    funcionarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Envios_envioId",
                        column: x => x.envioId,
                        principalTable: "Envios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Funcionarios_funcionarioId",
                        column: x => x.funcionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Envios_clienteId",
                table: "Envios",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_productoId",
                table: "Envios",
                column: "productoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_envioId",
                table: "Facturas",
                column: "envioId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_funcionarioId",
                table: "Facturas",
                column: "funcionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Envios");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
