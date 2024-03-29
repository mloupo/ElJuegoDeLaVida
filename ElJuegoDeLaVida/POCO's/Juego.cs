﻿using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.POCO_s
{
	public class Juego
	{
		private Mapa mapa;
		private List<Jugador> jugadores;
		private Turno turnoActual;

		public Juego(int tamanoTablero)
		{
			mapa = new Mapa(tamanoTablero);
			jugadores = new List<Jugador>();
			turnoActual = new Turno(jugadores.Cast<IJugador>().ToList());
		}

		public void Iniciar()
		{
			CrearEntidades();
			CrearTerrenos();
			CrearObjetos();
			RepartirEntidades();
			RepartirTerrenos();
			RepartirObjetos();
			IniciarRonda();
		}

		public void GestionarTurno(Jugador jugador)
		{
			turnoActual.RealizarAcciones();
			ActualizarPuntuaciones();
			AvanzarTurno();
		}

		private void CrearEntidades() { /* Lógica para crear entidades */ }

		private void CrearTerrenos() { /* Lógica para crear terrenos */ }

		private void CrearObjetos() { /* Lógica para crear objetos */ }

		private void RepartirEntidades() { /* Lógica para repartir entidades */ }

		private void RepartirTerrenos() { /* Lógica para repartir terrenos */ }

		private void RepartirObjetos() { /* Lógica para repartir objetos */ }



		public void RealizarInteraccion(Jugador jugador1, Jugador jugador2)
		{
			// Lógica para gestionar la interacción entre jugadores (ataques, alianzas, etc.).
		}

		public void ActualizarPuntuaciones()
		{
			// Lógica para actualizar las puntuaciones de los jugadores.
		}

		public void CrearEntidadAleatoria()
		{
			// Lógica para crear una entidad aleatoria y colocarla en el mapa.
		}

		public void CrearObjetoAleatorio()
		{
			// Lógica para crear un objeto aleatorio y colocarlo en el mapa.
		}

		public void MoverEntidad(Jugador jugador, Entidad entidad, Terreno destino)
		{
			// Lógica para mover una entidad a un terreno limítrofe.
		}

		public void IniciarRonda()
		{
			// Lógica para iniciar una nueva ronda.
			// Podemos establecer el orden aleatorio de los jugadores.
			AvanzarTurno(); // Iniciar el primer turno.
		}

		public void AvanzarTurno()
		{
			turnoActual.AvanzarTurno();
			// Realizar otras acciones necesarias al avanzar el turno, si las hay.

		}
	}
}

