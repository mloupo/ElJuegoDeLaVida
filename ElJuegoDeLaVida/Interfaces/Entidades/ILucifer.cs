using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.Interfaces.Entidades
{
    public interface ILucifer : IEntidadEspecial
    {
        void Tentar(IEntidad entidad);

        void Maldicion(IEntidad entidad);
    }
}
