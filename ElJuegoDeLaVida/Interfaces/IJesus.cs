using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.Interfaces
{
	public interface IJesus : IEntidadEspecial
	{
		void Sanar(IEntidad entidad);

		void Bendecir(IEntidad entidad);

		void Perdonar(IEntidad entidad);

		void Redimir(IEntidad entidad);
	}
}
