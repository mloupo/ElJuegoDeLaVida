using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.Interfaces.Entidades
{
	public interface IJesus : IEntidadEspecial
	{
		void Sanar(IEntidad entidad);

		void Bendecir(IEntidad entidad);

		void Perdonar(IEntidad entidad);

		void Redimir(IEntidad entidad);
	}
	// Jesus es siempre el segundo en tener la posiblidad de jugar, el jugador no sabe que Jesús es el Jugador Com
	// En la primer rueda de turnos Si sale Jesus, cede el turno, si su contrincante decide atacarlo
	// Es inmune al ataque y vuelve a ceder el turno luego de emitir su mensaje

}
