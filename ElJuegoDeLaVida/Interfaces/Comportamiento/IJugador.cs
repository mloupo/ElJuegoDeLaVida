namespace EJDLV.Entidades.Interfaces.Comportamiento
{
	public interface IJugador
	{
		string Nombre { get; }
		int Puntos { get; set; }
		void RealizarAcciones();
		bool EsControladoPorIA();
	}
}
