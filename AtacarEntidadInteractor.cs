using System;

namespace EJDLV.ReglasNegocioDeLaAplicacion.CasosDeUso
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
