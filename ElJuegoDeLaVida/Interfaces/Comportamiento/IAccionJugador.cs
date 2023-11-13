using EJDLV.Entidades.POCO_s;

namespace EJDLV.Entidades.Interfaces.Comportamiento
{
	public interface IAccionJugador
	{
		void RealizarAcciones();
		void Ejecutar(IJugador jugador);
		void MoverEntidad(Entidad entidad, Terreno destino);


		void Atacar(Entidad atacante, Entidad objetivo);

		public void Comer(Entidad entidad, IInteractuable comida);
	}
}
