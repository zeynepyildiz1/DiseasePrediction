using Microsoft.EntityFrameworkCore.Migrations;

namespace DiseasePredictionProject.Data.Migrations
{
    public partial class updateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "QuestionText",
                value: "Geniz akıntınız var mı?");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuestionText" },
                values: new object[] { 18, "Gün içerisinde görüşünüzün bulanıklaştığı oluyor mu?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                column: "QuestionText",
                value: "Bulanık gördüğünüz oluyor mu?");
        }
    }
}
