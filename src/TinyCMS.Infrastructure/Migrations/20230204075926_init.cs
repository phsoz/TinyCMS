using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TinyCMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentId = table.Column<long>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    MetaTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Slug = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_category_category_ParentId",
                        column: x => x.ParentId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tag",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    MetaTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Slug = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Mobile = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    RegisteredAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Intro = table.Column<string>(type: "TEXT", nullable: true),
                    Profile = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "post",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorId = table.Column<long>(type: "INTEGER", nullable: false),
                    ParentId = table.Column<long>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    MetaTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Slug = table.Column<string>(type: "TEXT", nullable: true),
                    Summary = table.Column<string>(type: "TEXT", nullable: true),
                    Published = table.Column<bool>(type: "INTEGER", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_post_post_ParentId",
                        column: x => x.ParentId,
                        principalTable: "post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_post_user_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "post_category",
                columns: table => new
                {
                    PostId = table.Column<long>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<long>(type: "INTEGER", nullable: false),
                    Id = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_category", x => new { x.PostId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_post_category_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_post_category_post_PostId",
                        column: x => x.PostId,
                        principalTable: "post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "post_comment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostId = table.Column<long>(type: "INTEGER", nullable: false),
                    ParentId = table.Column<long>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Published = table.Column<bool>(type: "INTEGER", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_post_comment_post_PostId",
                        column: x => x.PostId,
                        principalTable: "post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_post_comment_post_comment_ParentId",
                        column: x => x.ParentId,
                        principalTable: "post_comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "post_meta",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostId = table.Column<long>(type: "INTEGER", nullable: false),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_meta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_post_meta_post_PostId",
                        column: x => x.PostId,
                        principalTable: "post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "post_tag",
                columns: table => new
                {
                    PostId = table.Column<long>(type: "INTEGER", nullable: false),
                    TagId = table.Column<long>(type: "INTEGER", nullable: false),
                    Id = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    ModifiedBy = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_tag", x => new { x.TagId, x.PostId });
                    table.ForeignKey(
                        name: "FK_post_tag_post_PostId",
                        column: x => x.PostId,
                        principalTable: "post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_post_tag_tag_TagId",
                        column: x => x.TagId,
                        principalTable: "tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_ParentId",
                table: "category",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_post_AuthorId",
                table: "post",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_post_ParentId",
                table: "post",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_post_category_CategoryId",
                table: "post_category",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_post_comment_ParentId",
                table: "post_comment",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_post_comment_PostId",
                table: "post_comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_post_meta_PostId",
                table: "post_meta",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_post_tag_PostId",
                table: "post_tag",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "post_category");

            migrationBuilder.DropTable(
                name: "post_comment");

            migrationBuilder.DropTable(
                name: "post_meta");

            migrationBuilder.DropTable(
                name: "post_tag");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "post");

            migrationBuilder.DropTable(
                name: "tag");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
