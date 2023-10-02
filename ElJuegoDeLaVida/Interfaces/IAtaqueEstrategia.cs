using EJDLV.Entidades.POCO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.Interfaces
{
	public interface IAtaqueEstrategia
	{
		void RealizarAtaque(Entidad atacante, Entidad objetivo);
	}
}
