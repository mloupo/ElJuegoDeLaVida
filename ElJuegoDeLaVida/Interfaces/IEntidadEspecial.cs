using EJDLV.Entidades.POCO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.Interfaces
{
	public interface IEntidadEspecial
	{
		string ExpresarMensaje(string mensaje);
		void MoverseAtravesDe(string medio);
		void Interactuar();
		void Comer();
		void Atacar(Entidad objetivo);
		void Defenderse();
		void RealizarAccionEspecial();
	}
}
