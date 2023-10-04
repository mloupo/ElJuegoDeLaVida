using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.Interfaces
{
	using System;

namespace EJDLV.ReglasNegocioDeLaAplicacion.CasosDeUso
{
	public class RealizarMilagroCasoDeUso
	{
		public void RealizarMilagro(IEntidadEspecial entidad)
		{
			entidad.RealizarAccionEspecial();
		}
	}
}