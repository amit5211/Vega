using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Makes (Name) Values('Make1')");
            migrationBuilder.Sql("Insert into Makes (Name) Values('Make2')");
            migrationBuilder.Sql("Insert into Makes (Name) Values('Make3')");

            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make1-ModelA', (Select Id from Makes where name = 'Make1'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make1-ModelB', (Select Id from Makes where name = 'Make1'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make1-ModelC', (Select Id from Makes where name = 'Make1'))");

            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make2-ModelA', (Select Id from Makes where name = 'Make2'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make2-ModelB', (Select Id from Makes where name = 'Make2'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make2-ModelC', (Select Id from Makes where name = 'Make2'))");

            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make3-ModelA', (Select Id from Makes where name = 'Make3'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make3-ModelB', (Select Id from Makes where name = 'Make3'))");
            migrationBuilder.Sql("Insert into Models (Name, MakeId) Values('Make3-ModelC', (Select Id from Makes where name = 'Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Makes where Name in ('Make1', 'Make2', 'Make3')");
        }
    }
}
