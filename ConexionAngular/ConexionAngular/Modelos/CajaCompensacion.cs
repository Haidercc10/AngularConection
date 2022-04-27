using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class CajaCompensacion
    {
        public CajaCompensacion()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int CajComCodigo { get; set; }
        public long CajComId { get; set; }
        public long TpIdId { get; set; }
        public string CajComNombre { get; set; } = null!;
        public string CajComCorreo { get; set; } = null!;
        public long CajComTelefono { get; set; }
        public decimal CajComPorcentajeAporte { get; set; }
        public string CajComDireccionPrincipal { get; set; } = null!;
        public string CajComCiudadPrincipal { get; set; } = null!;
        public long CajComCuentaBancaria { get; set; }

        public virtual TipoIdentificacion TpId { get; set; } = null!;
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
