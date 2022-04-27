using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int TpUsuCodigo { get; set; }
        public long TpUsuId { get; set; }
        public string TpUsuNombre { get; set; } = null!;
        public string TpUsuDescripcion { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
