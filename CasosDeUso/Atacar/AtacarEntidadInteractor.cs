using EJDLV.Entidades.POCO_s;
using Servicios.Atacar;
using System;

namespace CasosDeUso.Atacar
{
    public class DefenderEntidadInteractor
    {
        private readonly IAtaqueServicio _ataqueServicio;

        public DefenderEntidadInteractor(IAtaqueServicio ataqueServicio)
        {
            _ataqueServicio = ataqueServicio;
        }

        public void AtacarEntidad(Entidad atacante, Entidad objetivo)
        {
            _ataqueServicio.Atacar(atacante, objetivo);
        }
    }
}
