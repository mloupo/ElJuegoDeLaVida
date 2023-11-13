using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.POCO_s
{
	public abstract class Objeto : IObjeto
	{
		public string Nombre { get; set; }
		public Terreno? TerrenoActual { get; set; }
		public abstract void Interactuar();

	}
}