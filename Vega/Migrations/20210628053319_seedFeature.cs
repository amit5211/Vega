using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class seedFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Features (Name) Values('Feature1')");
            migrationBuilder.Sql("Insert into Features (Name) Values('Feature2')");
            migrationBuilder.Sql("Insert into Features (Name) Values('Feature3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Features where Name in ('Feature1', 'Feature2', 'Feature3')");

        }
    }
}
