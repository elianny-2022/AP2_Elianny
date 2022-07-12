using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AP2_Verduras.Migrations
{
    public partial class Nuevamigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnidadDeMedida",
                table: "Vitaminas",
                newName: "Existencia");

            migrationBuilder.AddColumn<string>(
                name: "UnidadMedida",
                table: "Vitaminas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 1,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Vitamina C", 0.0, "mg" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 2,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Vitamina E ", 0.0, "mg" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 3,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Vitamina K ", 0.0, "mcg" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 4,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Vitamina A ", 0.0, "mcg RAE" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 5,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Betaína", 0.0, "mcg RAE" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 6,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Tiamina(B1)", 0.0, "mg" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 7,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Riboflavina(B2)", 0.0, "mg" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 8,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Ácido fólico(B9)", 0.0, "(mg)" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 9,
                columns: new[] { "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { "Choline", 0.0, "(mg)" });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 10,
                columns: new[] { "Existencia", "UnidadMedida" },
                values: new object[] { 0.0, "(μg)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnidadMedida",
                table: "Vitaminas");

            migrationBuilder.RenameColumn(
                name: "Existencia",
                table: "Vitaminas",
                newName: "UnidadDeMedida");

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 1,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Vitamina C (mg)", 120.0 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 2,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Vitamina E (mg)", 1.54 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 3,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Vitamina K (mcg)", 390.0 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 4,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Vitamina A (mcg RAE)", 90.0 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 5,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Betaína (mg)", 700.0 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 6,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Tiamina(B1) (mg)", 0.11 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 7,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Riboflavina(B2) (mg)", 0.13 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 8,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Ácido fólico(B9) (mg)", 400.0 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 9,
                columns: new[] { "Descripcion", "UnidadDeMedida" },
                values: new object[] { "Choline (mg)", 0.80000000000000004 });

            migrationBuilder.UpdateData(
                table: "Vitaminas",
                keyColumn: "VitaminaId",
                keyValue: 10,
                column: "UnidadDeMedida",
                value: 141.0);
        }
    }
}
