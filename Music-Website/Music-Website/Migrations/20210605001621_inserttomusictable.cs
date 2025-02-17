﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Website.Migrations
{
    public partial class inserttomusictable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "Music_image", "ProfileId", "audio", "description", "title" },
                values: new object[] { 4, "https://res.cloudinary.com/duuconncq/image/upload/v1622845572/img_4_uhkpiv.jpg", 2, "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613571243/zwz1nov81nhkbnnj6e6i.mp3", "Lovely life", "Stars" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
