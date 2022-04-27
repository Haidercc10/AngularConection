using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class TipoIdentificacion
    {
        public TipoIdentificacion()
        {
            CajaCompensacions = new HashSet<CajaCompensacion>();
            Empresas = new HashSet<Empresa>();
            Eps = new HashSet<Ep>();
            FondoPensiones = new HashSet<FondoPensione>();
            Usuarios = new HashSet<Usuario>();
        }

        public int TpIdCodigo { get; set; }
        public long TpIdId { get; set; }
        public string TpIdNombre { get; set; } = null!;
        public string? TpIdDescripcion { get; set; }

        public virtual ICollection<CajaCompensacion> CajaCompensacions { get; set; }
        public virtual ICollection<Empresa> Empresas { get; set; }
        public virtual ICollection<Ep> Eps { get; set; }
        public virtual ICollection<FondoPensione> FondoPensiones { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
