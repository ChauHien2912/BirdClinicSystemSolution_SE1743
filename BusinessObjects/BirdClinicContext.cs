using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObjects
{
    public partial class BirdClinicContext : DbContext
    {
        public BirdClinicContext()
        {
        }

        public BirdClinicContext(DbContextOptions<BirdClinicContext> options)
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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-B86QL67;Database=BirdClinic;Uid=sa;Pwd=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAppointment>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK__tblAppoi__8ECDFCA275D75DBD");

                entity.ToTable("tblAppointment");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.AppointmentDate).HasColumnType("date");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Bird)
                    .WithMany(p => p.TblAppointments)
                    .HasForeignKey(d => d.BirdId)
                    .HasConstraintName("FK__tblAppoin__BirdI__7D439ABD");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TblAppointmentDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__tblAppoin__Docto__7F2BE32F");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblAppointments)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK__tblAppoin__Servi__00200768");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TblAppointmentStaffs)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__tblAppoin__Staff__7E37BEF6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblAppointmentUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__tblAppoin__UserI__7C4F7684");
            });

            modelBuilder.Entity<TblBird>(entity =>
            {
                entity.HasKey(e => e.BirdId)
                    .HasName("PK__tblBird__7694332E74792797");

                entity.ToTable("tblBird");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Species).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblBirds)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__tblBird__UserID__778AC167");
            });

            modelBuilder.Entity<TblBlog>(entity =>
            {
                entity.HasKey(e => e.BlogId)
                    .HasName("PK__tblBlog__54379E50C29FD3C1");

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
                    .HasConstraintName("FK__tblBlog__AuthorI__07C12930");
            });

            modelBuilder.Entity<TblFeedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackId)
                    .HasName("PK__tblFeedb__6A4BEDF656E7B276");

                entity.ToTable("tblFeedback");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.TblFeedbacks)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK__tblFeedba__Appoi__0A9D95DB");
            });

            modelBuilder.Entity<TblMedicalRecord>(entity =>
            {
                entity.HasKey(e => e.MedicalId)
                    .HasName("PK__tblMedic__4DD4335D565A18C3");

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
                    .HasConstraintName("FK__tblMedica__BirdI__03F0984C");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TblMedicalRecordDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__tblMedica__Docto__04E4BC85");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblMedicalRecordUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__tblMedica__UserI__02FC7413");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__tblRole__8AFACE3ACA725245");

                entity.ToTable("tblRole");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(200);
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__tblServi__C51BB0EA06F23D22");

                entity.ToTable("tblService");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ServiceName).HasMaxLength(200);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__1788CCACC65C7747");

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
                    .HasConstraintName("FK__tblUser__RoleID__74AE54BC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
