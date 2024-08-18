using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHome",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(5222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(9687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.AddColumn<bool>(
                name: "InHomePage",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(5975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(2750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(2146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(2438));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InHomePage",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(7339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(6926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(1239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 860, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 51, DateTimeKind.Local).AddTicks(755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.AddColumn<bool>(
                name: "IsHome",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(6747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(2832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 27, 13, 48, 25, 50, DateTimeKind.Local).AddTicks(2438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 29, 1, 30, 7, 859, DateTimeKind.Local).AddTicks(2146));
        }
    }
}
