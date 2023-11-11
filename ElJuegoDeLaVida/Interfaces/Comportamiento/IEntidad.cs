using EJDLV.Entidades.POCO_s;

namespace EJDLV.Entidades.Interfaces.Comportamiento
{
	public interface IEntidad
	{
		void Descansar();
		void Morir();
		public void SeleccionarAtaque(IAtaqueEstrategia estrategia);
		public void SeleccionarDefensa(IDefensaEstrategia estrategia);
		public void RealizarAtaque(Entidad objetivo);
		public void RealizarDefensa();
	}
}
