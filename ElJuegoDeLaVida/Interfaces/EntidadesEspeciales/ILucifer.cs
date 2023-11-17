using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.Interfaces.Entidades
{
	public interface ILucifer : IEntidadEspecial
	{
		void Tentar(IEntidad entidad);

		void Maldicion(IEntidad entidad);
	}

	// Al solicitar la colaboracion de Lucifer, éste siempre devolvera un consejo relacionado con lo peor de nuestros valores como sociedad
	// generalmente asociado a pecados capitales como la ira, la gula, la lujuria, la soberbia, la avaricia, la envidia y la pereza.
	// la idea es que el jugadorHumano se sienta tentado a realizar acciones que lo perjudiquen a el mismo y a su entorno
	// y pueda aprender del impacto que tienen sus desiciones en su vida y en la de los demas.

}
