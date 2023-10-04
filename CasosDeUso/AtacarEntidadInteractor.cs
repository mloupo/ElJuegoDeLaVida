using EJDLV.Entidades.POCO_s;
using Servicios;
using System;

namespace CasosDeUso
{
	public class AtacarEntidadInteractor
	{
		private readonly IAtaqueServicio _ataqueServicio;

		public AtacarEntidadInteractor(IAtaqueServicio ataqueServicio)
		{
			_ataqueServicio = ataqueServicio;
		}

		public void AtacarEntidad(Entidad atacante, Entidad objetivo)
		{
			_ataqueServicio.Atacar(atacante, objetivo);
		}
	}
}
