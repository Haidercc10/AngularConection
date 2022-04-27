using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class Ep
    {
        public Ep()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int EpsCodigo { get; set; }
        public long EpsId { get; set; }
        public long TpIdId { get; set; }
        public string EpsNombre { get; set; } = null!;
        public string EpsCorre { get; set; } = null!;
        public long EpsTelefono { get; set; }
        public decimal EpsPorcentajeAporte { get; set; }
        public string EpsDireccionPrincipal { get; set; } = null!;
        public string EpsCiudadPrincipal { get; set; } = null!;
        public long EpsCuentaBancaria { get; set; }

        public virtual TipoIdentificacion TpId { get; set; } = null!;
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
