using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class Usuario
    {
        public int UsuCodigo { get; set; }
        public long UsuId { get; set; }
        public long TpIdId { get; set; }
        public string UsuNombre { get; set; } = null!;
        public long AreaId { get; set; }
        public string UsuCorreo { get; set; } = null!;
        public long UsuTelefono { get; set; }
        public long RolId { get; set; }
        public string UsuEstado { get; set; } = null!;
        public long TpUsuId { get; set; }
        public long CajComId { get; set; }
        public long EpsId { get; set; }
        public long FonPenId { get; set; }
        public string UsuContrasena { get; set; } = null!;

        public virtual Area Area { get; set; } = null!;
        public virtual CajaCompensacion CajCom { get; set; } = null!;
        public virtual Ep Eps { get; set; } = null!;
        public virtual FondoPensione FonPen { get; set; } = null!;
        public virtual Role Rol { get; set; } = null!;
        public virtual TipoIdentificacion TpId { get; set; } = null!;
        public virtual TipoUsuario TpUsu { get; set; } = null!;
    }
}
