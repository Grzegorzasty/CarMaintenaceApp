// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220118161934_AddedVehicleRepairPhotoWorkshop")]
    partial class AddedVehicleRepairPhotoWorkshop
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RepairId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RepairId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("API.Entities.Repair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AirFilterChange")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CabinFilterChange")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfReceipt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FuelFilterChange")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LaborPrize")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("OilChange")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("OilFilterChange")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Parts")
                        .HasColumnType("TEXT");

                    b.Property<int>("PartsPrize")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Repair");
                });

            modelBuilder.Entity("API.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.Property<int>("PurchasePrize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("VinNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearOfProduction")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("API.Entities.Workshop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RepairId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RepairId");

                    b.ToTable("Workshop");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.HasOne("API.Entities.Repair", null)
                        .WithMany("Photos")
                        .HasForeignKey("RepairId");
                });

            modelBuilder.Entity("API.Entities.Repair", b =>
                {
                    b.HasOne("API.Entities.Vehicle", null)
                        .WithMany("Repairs")
                        .HasForeignKey("VehicleId");
                });

            modelBuilder.Entity("API.Entities.Vehicle", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany("Vehicles")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("API.Entities.Workshop", b =>
                {
                    b.HasOne("API.Entities.Repair", null)
                        .WithMany("Workshops")
                        .HasForeignKey("RepairId");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("API.Entities.Repair", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Workshops");
                });

            modelBuilder.Entity("API.Entities.Vehicle", b =>
                {
                    b.Navigation("Repairs");
                });
#pragma warning restore 612, 618
        }
    }
}
