﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TinyCMS.Infrastructure.Persistence;

#nullable disable

namespace TinyCMS.Infrastructure.Migrations
{
    [DbContext(typeof(TinyDatabaseContext))]
    partial class TinyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

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

                    b.Property<long>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("category", (string)null);
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

                    b.HasIndex("ParentId");

                    b.ToTable("post", (string)null);
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostCategory", b =>
                {
                    b.Property<long>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("post_category", (string)null);
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

                    b.HasIndex("ParentId");

                    b.HasIndex("PostId");

                    b.ToTable("post_comment", (string)null);
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

                    b.ToTable("post_meta", (string)null);
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.PostTag", b =>
                {
                    b.Property<long>("TagId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<long>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("TagId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("post_tag", (string)null);
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

                    b.ToTable("tag", (string)null);
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Intro")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .HasColumnType("TEXT");

                    b.Property<long>("ModifiedBy")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Profile")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RegisteredAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("TinyCMS.Domain.Entities.Category", b =>
                {
                    b.HasOne("TinyCMS.Domain.Entities.Category", "ParentCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
