using EJDLV.Entidades.POCO_s;
using EJDLV.Entidades.POCO_s.EJDLV.Entidades.POCO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.POCO_s
{
	public class Terreno
	{
		public string Nombre { get; set; }
		public ISuperficie Superficie { get; set; }
		public List<Terreno> TerrenosLinderos { get; set; }
		public List<Entidad> Entidades { get; set; }

		public Terreno(string nombre, ISuperficie superficie)
		{
			Nombre = nombre;
			Superficie = superficie;
			TerrenosLinderos = new List<Terreno>();
			Entidades = new List<Entidad>();
		}

		public void AsignarEntidad(Entidad entidad)
		{
			Entidades.Add(entidad);
			entidad.TerrenoActual = this;
		}
	
	internal void AgregarObjeto(Objeto objeto)
		{
			throw new NotImplementedException();
		}
		// Otras propiedades del terreno, si las hay
	}
}

