using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddAttributeForMenuGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 748, DateTimeKind.Local).AddTicks(2968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 358, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 748, DateTimeKind.Local).AddTicks(2627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 358, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(7777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 357, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 357, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(3806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 357, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(3424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 357, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 746, DateTimeKind.Local).AddTicks(9868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 356, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 746, DateTimeKind.Local).AddTicks(9504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 356, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.AddColumn<bool>(
                name: "InHomePage",
                table: "MenuGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "MenuGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InHomePage",
                table: "MenuGroups");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "MenuGroups");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 358, DateTimeKind.Local).AddTicks(627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 748, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 358, DateTimeKind.Local).AddTicks(337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 748, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 357, DateTimeKind.Local).AddTicks(5134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 357, DateTimeKind.Local).AddTicks(4732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 357, DateTimeKind.Local).AddTicks(1265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 357, DateTimeKind.Local).AddTicks(923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 747, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 356, DateTimeKind.Local).AddTicks(8360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 746, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MenuGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 24, 12, 10, 30, 356, DateTimeKind.Local).AddTicks(8035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 26, 12, 52, 42, 746, DateTimeKind.Local).AddTicks(9504));
        }
    }
}
