// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TinyCMS.Infrastructure.Persistence;

#nullable disable

namespace TinyCMS.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230209145831_initdb")]
    partial class initdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MetaTitle")
                        .HasColumnType("TEXT");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<long?>("ParentCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MetaTitle")
                        .HasColumnType("TEXT");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ParentPostId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Published")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("PublishedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ParentPostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("PostId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostId");

                    b.ToTable("PostCategories");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<long?>("ParentCommentId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Published")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("PublishedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentCommentId");

                    b.HasIndex("PostId");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostMeta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("PostId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostMetas");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostTag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MetaTitle")
                        .HasColumnType("TEXT");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Intro")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Profile")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RegisteredAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TinyCMS.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Category", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.Category", "ParentCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Post", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TinyCMS.Domain.Entities.Post", "ParentPost")
                        .WithMany("ChildPosts")
                        .HasForeignKey("ParentPostId");

                    b.Navigation("Author");

                    b.Navigation("ParentPost");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostCategory", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.Category", "Category")
                        .WithMany("PostCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TinyCMS.Domain.Entities.Post", "Post")
                        .WithMany("PostCategories")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostComment", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.PostComment", "ParentComment")
                        .WithMany("ChildComments")
                        .HasForeignKey("ParentCommentId");

                    b.HasOne("TinyCMS.Domain.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentComment");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostMeta", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.Post", "Post")
                        .WithMany("Metas")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostTag", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TinyCMS.Domain.Entities.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Category", b =>
                {
                    b.Navigation("ChildCategories");

                    b.Navigation("PostCategories");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Post", b =>
                {
                    b.Navigation("ChildPosts");

                    b.Navigation("Comments");

                    b.Navigation("Metas");

                    b.Navigation("PostCategories");

                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostComment", b =>
                {
                    b.Navigation("ChildComments");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Tag", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
