using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class FondoPensione
    {
        public FondoPensione()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int FonPenCodigo { get; set; }
        public long FonPenId { get; set; }
        public long TpIdId { get; set; }
        public string FonPenNombre { get; set; } = null!;
        public string FonPenCorreo { get; set; } = null!;
        public string FonPenTelefono { get; set; } = null!;
        public decimal FonPenPorcentajeAporte { get; set; }
        public string FonPenDireccionPrincipal { get; set; } = null!;
        public string FonPenCiudadPrincipal { get; set; } = null!;
        public long FonPenCuentaBancaria { get; set; }

        public virtual TipoIdentificacion TpId { get; set; } = null!;
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
