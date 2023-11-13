using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.POCO_s
{
	public class Terreno
	{
		public string Nombre { get; set; }
		public ISuperficie Superficie { get; set; }
		public List<Terreno>? TerrenosLinderos { get; set; }
		public List<Entidad>? Entidades { get; set; }
		public List<Objeto>? Objetos { get; set; }
		public Entidad Entidad { get; set; }

		public Terreno(string nombre, ISuperficie superficie)
		{
			Nombre = nombre;
			Superficie = superficie;
			TerrenosLinderos = new List<Terreno>();
			Entidades = new List<Entidad>();
			Objetos = new List<Objeto>();
		}

		public void AsignarEntidad(Entidad entidad)
		{
			Entidades.Add(entidad);
			entidad.TerrenoActual = this;//verificar si la entidad pude ser posicionada en ese terreno.
		}


		public void AsignarObjeto(Objeto objeto)
		{
			Objetos.Add(objeto);
			objeto.TerrenoActual = this;
		}
		// Otras propiedades del terreno, si las hay
	}
}

