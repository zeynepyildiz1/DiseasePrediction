using Microsoft.EntityFrameworkCore.Migrations;

namespace DiseasePredictionProject.Data.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Diseases",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Info",
                value: "https://www.medicalpark.com.tr/sarilik/hg-2092");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 2,
                column: "Info",
                value: "https://www.medicalpark.com.tr/romatoid-artrit-nedir-teshisi-ve-tedavisi-nelerdir/hg-132");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 3,
                column: "Info",
                value: "https://www.medicalpark.com.tr/tuberkuloz-nedir-belirtileri-teshisi-ve-tedavi-yontemleri-nelerdir/hg-1772");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 4,
                column: "Info",
                value: "https://www.medicalpark.com.tr/grip-nedir-belirtileri-ve-tedavileri-nelerdir/hg-1902#:~:text=Grip%20influenza%20ad%C4%B1%20verilen%20vir%C3%BCs,ortaya%20%C3%A7%C4%B1kan%20bir%20mevsim%20hastal%C4%B1%C4%9F%C4%B1d%C4%B1r.");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 5,
                column: "Info",
                value: "https://www.medicalpark.com.tr/sinuzit-nedir/hg-138");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 6,
                column: "Info",
                value: "https://www.medicalpark.com.tr/kalp-krizi-nedir-belirtileri-ve-tedavi-yontemleri-nelerdir/hg-1851");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 7,
                column: "Info",
                value: "https://www.medicalpark.com.tr/glokom-hastaligi-nedir-belirti-ve-tedavi-yontemleri-nelerdir/hg-1737");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 8,
                column: "Info",
                value: "https://www.sozcu.com.tr/2018/saglik/ates-basmasi-nedir-belirtileri-nelerdir-tedavisi-nasil-olur-2326752/#:~:text=%C4%B0%C5%9Fte%20t%C3%BCm%20bilmeniz%20gerekenler...&text=Ate%C5%9F%20basmas%C4%B1%20veya%20s%C4%B1cak%20basmas%C4%B1,gibi%20belirtilerle%20karakterize%20bir%20durumdur.");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 9,
                column: "Info",
                value: "https://www.medicalpark.com.tr/seker-hastaligi-diyabet-nedir/hg-1703");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 10,
                column: "Info",
                value: "https://www.medicalpark.com.tr/gastrit-nedir-belirtileri-ve-tedavisi-nelerdir/hg-1957");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DiseaseName", "Info" },
                values: new object[] { "Kronik Yorgunluk Sendromu", "https://www.medicalpark.com.tr/kronik-yorgunluk-sendromu/hg-2112" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Diseases");

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 11,
                column: "DiseaseName",
                value: "Kronik Yorgunluk");
        }
    }
}
