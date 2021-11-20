﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    aboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.aboutID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    blogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blogTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blogContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blogThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blogImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blogCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blogStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.blogID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    commentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commentUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.commentID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    contactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contactUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    contactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.contactID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    writerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    writerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.writerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
