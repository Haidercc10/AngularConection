using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class Role
    {
        public Role()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int RolCodigo { get; set; }
        public long RolId { get; set; }
        public string RolNombre { get; set; } = null!;
        public string RolDescripcion { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
