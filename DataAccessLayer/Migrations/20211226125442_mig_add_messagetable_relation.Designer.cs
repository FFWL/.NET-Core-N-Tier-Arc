﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211226125442_mig_add_messagetable_relation")]
    partial class mig_add_messagetable_relation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("aboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aboutDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutDetails2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutMapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("aboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("aboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("blogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("blogContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("blogCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("blogImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("blogStatus")
                        .HasColumnType("bit");

                    b.Property<string>("blogThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<int>("writerID")
                        .HasColumnType("int");

                    b.HasKey("blogID");

                    b.HasIndex("categoryID");

                    b.HasIndex("writerID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BlogRating", b =>
                {
                    b.Property<int>("blogRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("blogID")
                        .HasColumnType("int");

                    b.Property<int>("blogRatingCount")
                        .HasColumnType("int");

                    b.Property<int>("blogTotalScore")
                        .HasColumnType("int");

                    b.HasKey("blogRatingID");

                    b.ToTable("BlogRatings");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("categoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("categoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("categoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("commentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogScore")
                        .HasColumnType("int");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<int>("blogID")
                        .HasColumnType("int");

                    b.Property<string>("commentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("commentID");

                    b.HasIndex("blogID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("contactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("contactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("contactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("contactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("contactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Match", b =>
                {
                    b.Property<int>("MatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GuessTeamID")
                        .HasColumnType("int");

                    b.Property<int?>("HomeTeamID")
                        .HasColumnType("int");

                    b.Property<string>("MatchDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadium")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MatchID");

                    b.HasIndex("GuessTeamID");

                    b.HasIndex("HomeTeamID");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message", b =>
                {
                    b.Property<int>("messageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("messageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("messageDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("messageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("messageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message2", b =>
                {
                    b.Property<int>("messageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("messageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("messageDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("messageStatus")
                        .HasColumnType("bit");

                    b.Property<int?>("receiverID")
                        .HasColumnType("int");

                    b.Property<int?>("senderID")
                        .HasColumnType("int");

                    b.Property<string>("subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("messageID");

                    b.HasIndex("receiverID");

                    b.HasIndex("senderID");

                    b.ToTable("Message2s");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewsLetter", b =>
                {
                    b.Property<int>("mailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MailStatus")
                        .HasColumnType("bit");

                    b.HasKey("mailID");

                    b.ToTable("NewsLetter");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Notification", b =>
                {
                    b.Property<int>("notificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("notificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("notificationDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("notificationStatus")
                        .HasColumnType("bit");

                    b.Property<string>("notificationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notificationTypeColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notificationTypeSymbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("notificationID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Property<int>("writerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("writerAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("writerStatus")
                        .HasColumnType("bit");

                    b.HasKey("writerID");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Writer", "Writer")
                        .WithMany("Blogs")
                        .HasForeignKey("writerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("blogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Match", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Team", "GuestTeam")
                        .WithMany("AwayMatches")
                        .HasForeignKey("GuessTeamID");

                    b.HasOne("EntityLayer.Concrete.Team", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamID");

                    b.Navigation("GuestTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message2", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Writer", "ReceiverUser")
                        .WithMany("WriterReceiver")
                        .HasForeignKey("receiverID");

                    b.HasOne("EntityLayer.Concrete.Writer", "SenderUser")
                        .WithMany("WriterSender")
                        .HasForeignKey("senderID");

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Team", b =>
                {
                    b.Navigation("AwayMatches");

                    b.Navigation("HomeMatches");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("WriterReceiver");

                    b.Navigation("WriterSender");
                });
#pragma warning restore 612, 618
        }
    }
}
