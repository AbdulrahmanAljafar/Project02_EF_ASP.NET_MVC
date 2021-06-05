﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Music_Website.Data;

namespace Music_Website.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210604200834_Inserratetable1")]
    partial class Inserratetable1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Music_Website.Models.MusicModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Music_image")
                        .HasColumnType("text");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("audio")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Musics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Music_image = "https://m.media-amazon.com/images/I/514gcbVy-QL._SL500_.jpg",
                            ProfileId = 1,
                            audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613571243/zwz1nov81nhkbnnj6e6i.mp3",
                            description = "The official music video for Ocean by David Davis. Connect with David online. Instagram: @justdaviddavis Facebook: facebook.com/justdaviddavis Website: justdaviddavis.com/ TikTok: tiktok.com/@justdaviddavis",
                            title = "David Davis"
                        },
                        new
                        {
                            Id = 2,
                            Music_image = "https://res.cloudinary.com/duuconncq/image/upload/v1613598303/jkkshf0yiwrp5d3mz7ec.jpg",
                            ProfileId = 1,
                            audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613598562/zjxp5qcsetep7pyog0ki.mp3",
                            description = "Don't cry to give up , cry to be successful",
                            title = "Don't give up"
                        },
                        new
                        {
                            Id = 3,
                            Music_image = "https://cdns-images.dzcdn.net/images/cover/77129041df87e78752bd3dc2cc841912/500x500.jpg",
                            ProfileId = 1,
                            audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1622012633/wbjs3c7yi4wnbuav3mjm.mp3",
                            description = "Zodiac Songs: RENAE - Rome (Capricorn)",
                            title = "RENAE - Rome"
                        });
                });

            modelBuilder.Entity("Music_Website.Models.ProfileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Background_Image")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Background_Image = "https://images.pexels.com/photos/946351/pexels-photo-946351.jpeg?w=500&h=650&auto=compress&cs=tinysrgb",
                            Image = "https://res.cloudinary.com/crunchbase-production/image/upload/c_thumb,h_256,w_256,f_auto,g_faces,z_0.7,q_auto:eco/tluillv6dybajfj7i0dq",
                            Name = "Kirsten Korosec",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Background_Image = "https://images.pexels.com/photos/3692749/pexels-photo-3692749.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            Image = "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2014_01/95471/2503781351_7feef38a1a_b-95471.jpg",
                            Name = "Devin Coldewey",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Background_Image = "https://images.pexels.com/photos/4500796/pexels-photo-4500796.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            Image = "https://www.monteirolobato.edu.br/public/assets/admin/images/avatars/avatar5_big.png",
                            Name = "Rebecca Bellan",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("Music_Website.Models.RateModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MusicId")
                        .HasColumnType("int");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("MusicId")
                        .IsUnique();

                    b.ToTable("Rate");

                    b.HasData(
                        new
                        {
                            id = 1,
                            MusicId = 1,
                            score = 3
                        },
                        new
                        {
                            id = 2,
                            MusicId = 2,
                            score = 5
                        },
                        new
                        {
                            id = 3,
                            MusicId = 3,
                            score = 4
                        });
                });

            modelBuilder.Entity("Music_Website.Models.UserModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Email = "AAJ@gmail.com",
                            username = "AAJ"
                        },
                        new
                        {
                            id = 2,
                            Email = "user2@gmail.com",
                            username = "user2"
                        },
                        new
                        {
                            id = 3,
                            Email = "user3@gmail.com",
                            username = "user3"
                        });
                });

            modelBuilder.Entity("Music_Website.Models.MusicModel", b =>
                {
                    b.HasOne("Music_Website.Models.ProfileModel", "Profile")
                        .WithMany("Musics")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Music_Website.Models.ProfileModel", b =>
                {
                    b.HasOne("Music_Website.Models.UserModel", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Music_Website.Models.ProfileModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Music_Website.Models.RateModel", b =>
                {
                    b.HasOne("Music_Website.Models.MusicModel", "Music")
                        .WithOne("Rate")
                        .HasForeignKey("Music_Website.Models.RateModel", "MusicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
