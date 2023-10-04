using EJDLV.Entidades.Interfaces;
using EJDLV.Entidades.Personajes;
using EJDLV.Entidades.POCO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasosDeUso
{
	public class RealizarMilagroCasoDeUso
	{
		public void RealizarMilagro(Jesus Jesus, Entidad entidad)
		{
			Jesus.Bendecir(entidad);
		}
	}
}