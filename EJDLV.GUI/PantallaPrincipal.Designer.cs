namespace EJDLV.GUI
{
	partial class PantallaPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			BtnNuevoJuego = new Button();
			BtnCargarPartida = new Button();
			BtnSalir = new Button();
			SuspendLayout();
			// 
			// BtnNuevoJuego
			// 
			BtnNuevoJuego.Location = new Point(12, 22);
			BtnNuevoJuego.Name = "BtnNuevoJuego";
			BtnNuevoJuego.Size = new Size(173, 29);
			BtnNuevoJuego.TabIndex = 0;
			BtnNuevoJuego.Text = "Nuevo Juego";
			BtnNuevoJuego.UseVisualStyleBackColor = true;
			BtnNuevoJuego.Click += BtnNuevoJuego_Click;
			// 
			// BtnCargarPartida
			// 
			BtnCargarPartida.Location = new Point(12, 85);
			BtnCargarPartida.Name = "BtnCargarPartida";
			BtnCargarPartida.Size = new Size(173, 29);
			BtnCargarPartida.TabIndex = 1;
			BtnCargarPartida.Text = "Cargar Partida";
			BtnCargarPartida.UseVisualStyleBackColor = true;
			BtnCargarPartida.Click += BtnCargarPartida_Click;
			// 
			// BtnSalir
			// 
			BtnSalir.Location = new Point(12, 143);
			BtnSalir.Name = "BtnSalir";
			BtnSalir.Size = new Size(173, 29);
			BtnSalir.TabIndex = 2;
			BtnSalir.Text = "Salir";
			BtnSalir.UseVisualStyleBackColor = true;
			BtnSalir.Click += BtnSalir_Click;
			// 
			// PantallaPrincipal
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(BtnSalir);
			Controls.Add(BtnCargarPartida);
			Controls.Add(BtnNuevoJuego);
			Name = "PantallaPrincipal";
			Text = "PantallaPrincipal";
			ResumeLayout(false);
		}

		#endregion

		private Button BtnNuevoJuego;
		private Button BtnCargarPartida;
		private Button BtnSalir;
	}
}