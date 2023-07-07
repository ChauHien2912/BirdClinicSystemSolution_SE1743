using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BusinessObjects
{
    public partial class BirdClinicDBContext : DbContext
    {
        public BirdClinicDBContext()
        {
        }

        public BirdClinicDBContext(DbContextOptions<BirdClinicDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAppointment> TblAppointments { get; set; }
        public virtual DbSet<TblBird> TblBirds { get; set; }
        public virtual DbSet<TblBlog> TblBlogs { get; set; }
        public virtual DbSet<TblFeedback> TblFeedbacks { get; set; }
        public virtual DbSet<TblMedicalRecord> TblMedicalRecords { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblService> TblServices { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnectionStringDB"];
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAppointment>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK__tblAppoi__8ECDFCA239094D4F");

                entity.ToTable("tblAppointment");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.AppointmentDate).HasColumnType("date");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Bird)
                    .WithMany(p => p.TblAppointments)
                    .HasForeignKey(d => d.BirdId)
                    .HasConstraintName("FK__tblAppoin__BirdI__3F466844");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TblAppointmentDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__tblAppoin__Docto__412EB0B6");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblAppointments)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAppointment_tblService");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblAppointmentStaffs)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__tblAppoin__Staff__403A8C7D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblAppointmentUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__tblAppoin__UserI__3E52440B");
            });

            modelBuilder.Entity<TblBird>(entity =>
            {
                entity.HasKey(e => e.BirdId)
                    .HasName("PK__tblBird__7694332E6163FFB9");

                entity.ToTable("tblBird");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Species).HasMaxLength(100);
            });

            modelBuilder.Entity<TblBlog>(entity =>
            {
                entity.HasKey(e => e.BlogId)
                    .HasName("PK__tblBlog__54379E508C700496");

                entity.ToTable("tblBlog");

                entity.Property(e => e.BlogId).HasColumnName("BlogID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.DatePublished).HasColumnType("date");

                entity.Property(e => e.Tag).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.TblBlogs)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK__tblBlog__AuthorI__49C3F6B7");
            });

            modelBuilder.Entity<TblFeedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackId)
                    .HasName("PK__tblFeedb__6A4BEDF61B4BCE84");

                entity.ToTable("tblFeedback");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.TblFeedbacks)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK__tblFeedba__Appoi__4D94879B");
            });

            modelBuilder.Entity<TblMedicalRecord>(entity =>
            {
                entity.HasKey(e => e.MedicalId)
                    .HasName("PK__tblMedic__4DD4335D596B9DE7");

                entity.ToTable("tblMedicalRecord");

                entity.Property(e => e.MedicalId).HasColumnName("MedicalID");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Diagnosis).HasColumnType("text");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.Intruction).HasColumnType("text");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Bird)
                    .WithMany(p => p.TblMedicalRecords)
                    .HasForeignKey(d => d.BirdId)
                    .HasConstraintName("FK__tblMedica__BirdI__4BAC3F29");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TblMedicalRecordDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__tblMedica__Docto__4CA06362");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblMedicalRecordUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__tblMedica__UserI__4D94879B");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__tblRole__8AFACE3A15419A83");

                entity.ToTable("tblRole");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(200);
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__tblServi__C51BB0EA789E904A");

                entity.ToTable("tblService");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ServiceName).HasMaxLength(200);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__1788CCAC6DD12537");

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(11);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__tblUser__RoleID__4E88ABD4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
