using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConexionAngular.Modelos
{
    public partial class PlasticaribeBDContext : DbContext
    {
        public PlasticaribeBDContext()
        {
        }

        public PlasticaribeBDContext(DbContextOptions<PlasticaribeBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<CajaCompensacion> CajaCompensacions { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Ep> Eps { get; set; } = null!;
        public virtual DbSet<FondoPensione> FondoPensiones { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<TipoIdentificacion> TipoIdentificacions { get; set; } = null!;
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.0.250;Database=PlasticaribeBD; User ID= sa; pwd=123581321;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("areas");

                entity.HasIndex(e => e.AreaCodigo, "UK_area")
                    .IsUnique();

                entity.Property(e => e.AreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("area_id");

                entity.Property(e => e.AreaCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("area_codigo");

                entity.Property(e => e.AreaDescripcion)
                    .HasColumnType("text")
                    .HasColumnName("area_descripcion");

                entity.Property(e => e.AreaNombre)
                    .HasMaxLength(50)
                    .HasColumnName("area_nombre");
            });

            modelBuilder.Entity<CajaCompensacion>(entity =>
            {
                entity.HasKey(e => e.CajComId);

                entity.ToTable("caja_compensacion");

                entity.HasIndex(e => e.CajComCodigo, "UK_caja_compensacion")
                    .IsUnique();

                entity.Property(e => e.CajComId)
                    .ValueGeneratedNever()
                    .HasColumnName("cajCom_id");

                entity.Property(e => e.CajComCiudadPrincipal)
                    .HasMaxLength(50)
                    .HasColumnName("cajCom_ciudadPrincipal");

                entity.Property(e => e.CajComCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cajCom_codigo");

                entity.Property(e => e.CajComCorreo)
                    .HasMaxLength(50)
                    .HasColumnName("cajCom_correo");

                entity.Property(e => e.CajComCuentaBancaria).HasColumnName("cajCom_cuentaBancaria");

                entity.Property(e => e.CajComDireccionPrincipal)
                    .HasMaxLength(50)
                    .HasColumnName("cajCom_direccionPrincipal");

                entity.Property(e => e.CajComNombre)
                    .HasMaxLength(50)
                    .HasColumnName("cajCom_nombre");

                entity.Property(e => e.CajComPorcentajeAporte)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("cajCom_porcentajeAporte");

                entity.Property(e => e.CajComTelefono).HasColumnName("cajCom_telefono");

                entity.Property(e => e.TpIdId).HasColumnName("tpId_id");

                entity.HasOne(d => d.TpId)
                    .WithMany(p => p.CajaCompensacions)
                    .HasForeignKey(d => d.TpIdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_caja_compensacion_tipo_identificacion");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("empresa");

                entity.HasIndex(e => e.EmpCodigo, "UK_empresa")
                    .IsUnique();

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("emp_codigo");

                entity.Property(e => e.EmpCodigoPostal).HasColumnName("emp_codigoPostal");

                entity.Property(e => e.EmpDireccion)
                    .HasMaxLength(50)
                    .HasColumnName("emp_direccion");

                entity.Property(e => e.EmpEmail)
                    .HasMaxLength(50)
                    .HasColumnName("emp_email");

                entity.Property(e => e.EmpNombre)
                    .HasMaxLength(50)
                    .HasColumnName("emp_nombre");

                entity.Property(e => e.EmpTelefono).HasColumnName("emp_telefono");

                entity.Property(e => e.TpIdId).HasColumnName("tpId_id");

                entity.HasOne(d => d.TpId)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.TpIdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_empresa_tipo_identificacion");
            });

            modelBuilder.Entity<Ep>(entity =>
            {
                entity.HasKey(e => e.EpsId);

                entity.ToTable("eps");

                entity.HasIndex(e => e.EpsCodigo, "UK_eps")
                    .IsUnique();

                entity.Property(e => e.EpsId)
                    .ValueGeneratedNever()
                    .HasColumnName("eps_id");

                entity.Property(e => e.EpsCiudadPrincipal)
                    .HasMaxLength(50)
                    .HasColumnName("eps_ciudadPrincipal");

                entity.Property(e => e.EpsCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("eps_codigo");

                entity.Property(e => e.EpsCorre)
                    .HasMaxLength(50)
                    .HasColumnName("eps_corre");

                entity.Property(e => e.EpsCuentaBancaria).HasColumnName("eps_cuentaBancaria");

                entity.Property(e => e.EpsDireccionPrincipal)
                    .HasMaxLength(50)
                    .HasColumnName("eps_direccionPrincipal");

                entity.Property(e => e.EpsNombre)
                    .HasMaxLength(50)
                    .HasColumnName("eps_nombre");

                entity.Property(e => e.EpsPorcentajeAporte)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("eps_porcentajeAporte");

                entity.Property(e => e.EpsTelefono).HasColumnName("eps_telefono");

                entity.Property(e => e.TpIdId).HasColumnName("tpId_id");

                entity.HasOne(d => d.TpId)
                    .WithMany(p => p.Eps)
                    .HasForeignKey(d => d.TpIdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eps_tipo_identificacion");
            });

            modelBuilder.Entity<FondoPensione>(entity =>
            {
                entity.HasKey(e => e.FonPenId);

                entity.ToTable("fondo_pensiones");

                entity.HasIndex(e => e.FonPenCodigo, "UK_fondo_pensiones")
                    .IsUnique();

                entity.Property(e => e.FonPenId)
                    .ValueGeneratedNever()
                    .HasColumnName("fonPen_id");

                entity.Property(e => e.FonPenCiudadPrincipal)
                    .HasMaxLength(50)
                    .HasColumnName("fonPen_ciudadPrincipal");

                entity.Property(e => e.FonPenCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fonPen_codigo");

                entity.Property(e => e.FonPenCorreo)
                    .HasMaxLength(50)
                    .HasColumnName("fonPen_correo");

                entity.Property(e => e.FonPenCuentaBancaria).HasColumnName("fonPen_cuentaBancaria");

                entity.Property(e => e.FonPenDireccionPrincipal)
                    .HasMaxLength(50)
                    .HasColumnName("fonPen_direccionPrincipal");

                entity.Property(e => e.FonPenNombre)
                    .HasMaxLength(50)
                    .HasColumnName("fonPen_nombre");

                entity.Property(e => e.FonPenPorcentajeAporte)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fonPen_porcentajeAporte");

                entity.Property(e => e.FonPenTelefono)
                    .HasMaxLength(50)
                    .HasColumnName("fonPen_telefono");

                entity.Property(e => e.TpIdId).HasColumnName("tpId_id");

                entity.HasOne(d => d.TpId)
                    .WithMany(p => p.FondoPensiones)
                    .HasForeignKey(d => d.TpIdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fondo_pensiones_tipo_identificacion");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.ToTable("roles");

                entity.HasIndex(e => e.RolCodigo, "UK_roles")
                    .IsUnique();

                entity.Property(e => e.RolId)
                    .ValueGeneratedNever()
                    .HasColumnName("rol_id");

                entity.Property(e => e.RolCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rol_codigo");

                entity.Property(e => e.RolDescripcion)
                    .HasColumnType("text")
                    .HasColumnName("rol_descripcion");

                entity.Property(e => e.RolNombre)
                    .HasMaxLength(50)
                    .HasColumnName("rol_nombre");
            });

            modelBuilder.Entity<TipoIdentificacion>(entity =>
            {
                entity.HasKey(e => e.TpIdId);

                entity.ToTable("tipo_identificacion");

                entity.HasIndex(e => e.TpIdCodigo, "UK_tipo_identificacion")
                    .IsUnique();

                entity.Property(e => e.TpIdId)
                    .ValueGeneratedNever()
                    .HasColumnName("tpId_id");

                entity.Property(e => e.TpIdCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("tpId_codigo");

                entity.Property(e => e.TpIdDescripcion)
                    .HasColumnType("text")
                    .HasColumnName("tpId_descripcion");

                entity.Property(e => e.TpIdNombre)
                    .HasMaxLength(50)
                    .HasColumnName("tpId_nombre");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.TpUsuId);

                entity.ToTable("tipo_usuarios");

                entity.HasIndex(e => e.TpUsuCodigo, "UK_tipo_ususarios")
                    .IsUnique();

                entity.Property(e => e.TpUsuId)
                    .ValueGeneratedNever()
                    .HasColumnName("tpUsu_id");

                entity.Property(e => e.TpUsuCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("tpUsu_codigo");

                entity.Property(e => e.TpUsuDescripcion)
                    .HasColumnType("text")
                    .HasColumnName("tpUsu_descripcion");

                entity.Property(e => e.TpUsuNombre)
                    .HasMaxLength(50)
                    .HasColumnName("tpUsu_nombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuId);

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.UsuCodigo, "UK_usuarios")
                    .IsUnique();

                entity.Property(e => e.UsuId)
                    .ValueGeneratedNever()
                    .HasColumnName("usu_id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.CajComId).HasColumnName("cajCom_id");

                entity.Property(e => e.EpsId).HasColumnName("eps_id");

                entity.Property(e => e.FonPenId).HasColumnName("fonPen_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.TpIdId).HasColumnName("tpId_id");

                entity.Property(e => e.TpUsuId).HasColumnName("tpUsu_id");

                entity.Property(e => e.UsuCodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("usu_codigo");

                entity.Property(e => e.UsuContrasena).HasColumnName("usu_contrasena");

                entity.Property(e => e.UsuCorreo)
                    .HasMaxLength(50)
                    .HasColumnName("usu_correo");

                entity.Property(e => e.UsuEstado)
                    .HasMaxLength(50)
                    .HasColumnName("usu_estado");

                entity.Property(e => e.UsuNombre)
                    .HasMaxLength(50)
                    .HasColumnName("usu_nombre");

                entity.Property(e => e.UsuTelefono).HasColumnName("usu_telefono");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuarios_areas");

                entity.HasOne(d => d.CajCom)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.CajComId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuarios_caja_compensacion");

                entity.HasOne(d => d.Eps)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.EpsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuarios_eps");

                entity.HasOne(d => d.FonPen)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.FonPenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuarios_fondo_pensiones");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuarios_roles");

                entity.HasOne(d => d.TpId)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.TpIdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuarios_tipo_identificacion");

                entity.HasOne(d => d.TpUsu)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.TpUsuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_usuarios_tipo_usuarios");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
