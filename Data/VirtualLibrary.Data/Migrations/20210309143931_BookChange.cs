using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualLibrary.Data.Migrations
{
    public partial class BookChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Authors",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Genres",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Genres",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Genres",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Books",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Books",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "BookGenres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "BookGenres",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookGenres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BookGenres",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "BookGenres",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Authors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Authors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_IsDeleted",
                table: "Genres",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Books_IsDeleted",
                table: "Books",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_IsDeleted",
                table: "BookGenres",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_IsDeleted",
                table: "Authors",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Genres_IsDeleted",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Books_IsDeleted",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookGenres_IsDeleted",
                table: "BookGenres");

            migrationBuilder.DropIndex(
                name: "IX_Authors_IsDeleted",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "BookGenres");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "BookGenres");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookGenres");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BookGenres");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "BookGenres");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genres",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Authors",
                newName: "AuthorId");
        }
    }
}
