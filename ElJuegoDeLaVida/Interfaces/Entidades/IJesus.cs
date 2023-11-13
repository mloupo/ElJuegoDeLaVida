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
	// Jesus es siempre el segundo en tener la posiblidad de jugar, el jugadorHumano no sabe que Jesús es el Jugador Com
	// En la primer rueda de turnos Si sale Jesus, cede el turno, si su contrincante decide atacarlo
	// el es inmune al ataque y vuelve a ceder el turno luego de emitir su mensaje
	// Esto le da la oportunidad al jugador de tomar una nueva decision
	// en estos momentos el JugadorHumano puede decidir solicitar colaboracion a otras entidades aledañas 
	// (dentro de las cuales puede estar Lucifer y expresar su mensaje como consejo para tentar al jugadorHumano)
	// u otras acciones basicas, como descansar, comer, atacar.
	// Si decide volver a atacar, esta vez el daño se volvera en su contra y perdera la vida. 

}
