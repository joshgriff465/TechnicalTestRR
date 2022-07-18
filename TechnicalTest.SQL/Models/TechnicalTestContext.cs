using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedNumerics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


#nullable disable



namespace TechnicalTest.SQL.Models

{

    public partial class TechnicalTestContext : DbContext

    {
        public TechnicalTestContext()
        {
        }

        public TechnicalTestContext(DbContextOptions<TechnicalTestContext> options)

            : base(options)

        {

        }

        //this is the entity framework model. It syncs up with the database and allows for information to be stored and accessed through the other models. 


        //Initialise all of the models
        public virtual DbSet<Drinks> Drinks { get; set; }
        public virtual DbSet<Instructions> Instructions { get; set; }







        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            if (!optionsBuilder.IsConfigured)

            {

                optionsBuilder.UseSqlServer(SQLConfiguration.ConnectionString, builder =>
                {
                    builder.EnableRetryOnFailure(3, TimeSpan.FromSeconds(15), null);
                });
                base.OnConfiguring(optionsBuilder);

            }

        }


        //Create the models for entity framework.
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {




            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            //using model builder for the table x - in this case customer - and then set the properties. This is repeated for each table in the database.
            modelBuilder.Entity<Drinks>(entity =>

            {

                entity.ToTable("Drinks");



                entity.Property(e => e.DrinkId).HasDefaultValueSql("(newid())");



                entity.Property(e => e.Name)

                    .IsRequired()

                    .HasMaxLength(50)

                    .IsUnicode(false);



                entity.Property(e => e.ImageLink)


                    .HasMaxLength(200)

                    .IsUnicode(false);

                entity.Property(e => e.Availability)

                .IsUnicode(false);



            });

            modelBuilder.Entity<Instructions>(entity =>

            {

                entity.ToTable("Instructions");

                entity.Property(e => e.InstructionId).HasDefaultValueSql("(newid())");



                entity.Property(e => e.DrinkId)

                    .IsRequired()

                    .IsUnicode(false);



                entity.Property(e => e.InstructionDetails)


                    .IsRequired()

                    .IsUnicode(false);


                entity.Property(e => e.InstructionOrder)

                    .IsRequired();

                entity.Property(e => e.InstructionImage)

                    .IsRequired();



            });


            OnModelCreatingPartial(modelBuilder);

        }



        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }

}