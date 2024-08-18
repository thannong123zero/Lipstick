using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddTopicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Topic_TopicID",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brand_BrandID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "Topics");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "Brands");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_Article_TopicID",
                table: "Articles",
                newName: "IX_Articles_TopicID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 499, DateTimeKind.Local).AddTicks(2560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 176, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 499, DateTimeKind.Local).AddTicks(2163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 176, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 498, DateTimeKind.Local).AddTicks(128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 175, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 497, DateTimeKind.Local).AddTicks(9681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 175, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 497, DateTimeKind.Local).AddTicks(4493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 497, DateTimeKind.Local).AddTicks(3972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 496, DateTimeKind.Local).AddTicks(8787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 496, DateTimeKind.Local).AddTicks(7937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 498, DateTimeKind.Local).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 176, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Topics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 498, DateTimeKind.Local).AddTicks(8238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 176, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 496, DateTimeKind.Local).AddTicks(3659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 496, DateTimeKind.Local).AddTicks(3154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 173, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topics",
                table: "Topics",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Topics_TopicID",
                table: "Articles",
                column: "TopicID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandID",
                table: "Products",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Topics_TopicID",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topics",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Topics",
                newName: "Topic");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "Brand");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_TopicID",
                table: "Article",
                newName: "IX_Article_TopicID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 176, DateTimeKind.Local).AddTicks(9290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 499, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 176, DateTimeKind.Local).AddTicks(8823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 499, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 175, DateTimeKind.Local).AddTicks(4978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 498, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 175, DateTimeKind.Local).AddTicks(4313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 497, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(8869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 497, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(8272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 497, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(4124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 496, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(3756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 496, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 176, DateTimeKind.Local).AddTicks(5357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 498, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 176, DateTimeKind.Local).AddTicks(4826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 498, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Brand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 174, DateTimeKind.Local).AddTicks(505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 496, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Brand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 21, 42, 24, 173, DateTimeKind.Local).AddTicks(9961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 23, 1, 23, 496, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                table: "Topic",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Topic_TopicID",
                table: "Article",
                column: "TopicID",
                principalTable: "Topic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brand_BrandID",
                table: "Products",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "ID");
        }
    }
}
