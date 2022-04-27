using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class Area
    {
        public Area()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int AreaCodigo { get; set; }
        public long AreaId { get; set; }
        public string AreaNombre { get; set; } = null!;
        public string? AreaDescripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
