using System;
using System.Collections.Generic;

namespace ConexionAngular.Modelos
{
    public partial class Empresa
    {
        public int EmpCodigo { get; set; }
        public long EmpId { get; set; }
        public long TpIdId { get; set; }
        public string EmpNombre { get; set; } = null!;
        public string EmpDireccion { get; set; } = null!;
        public long EmpTelefono { get; set; }
        public string EmpEmail { get; set; } = null!;
        public int? EmpCodigoPostal { get; set; }

        public virtual TipoIdentificacion TpId { get; set; } = null!;
    }
}
