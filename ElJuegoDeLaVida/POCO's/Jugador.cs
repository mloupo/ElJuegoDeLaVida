namespace EJDLV.Entidades.POCO_s
{
	public class Jugador
	{

		public bool EsControladoPorIA()
		{
			return this is JugadorCOM; // Suponiendo que JugadorCOM es una clase para representar a la computadora.
		}

	}
}
