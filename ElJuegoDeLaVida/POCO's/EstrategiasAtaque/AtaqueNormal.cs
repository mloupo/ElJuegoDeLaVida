using EJDLV.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.POCO_s.EstrategiasAtaque
{
	public class AtaqueNormal : IAtaqueEstrategia
	{
		public void RealizarAtaque(Entidad atacante, Entidad objetivo)
		{
			// Implementación del ataque normal
		}
	}
}
