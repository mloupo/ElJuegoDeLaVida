namespace EJDLV.GUI
{
	partial class ConfiguracionPartida
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			labelNombre = new Label();
			textBoxNombre = new TextBox();
			labelTipoEntidad = new Label();
			radioButtonJesus = new RadioButton();
			radioButtonLucifer = new RadioButton();
			labelTipoTerreno = new Label();
			radioButtonTerrestre = new RadioButton();
			radioButtonAcuatico = new RadioButton();
			buttonIniciar = new Button();
			SuspendLayout();
			// 
			// labelNombre
			// 
			labelNombre.AutoSize = true;
			labelNombre.Location = new Point(73, 50);
			labelNombre.Name = "labelNombre";
			labelNombre.Size = new Size(64, 20);
			labelNombre.TabIndex = 0;
			labelNombre.Text = "Nombre";
			// 
			// textBoxNombre
			// 
			textBoxNombre.Location = new Point(73, 92);
			textBoxNombre.Name = "textBoxNombre";
			textBoxNombre.Size = new Size(125, 27);
			textBoxNombre.TabIndex = 1;
			// 
			// labelTipoEntidad
			// 
			labelTipoEntidad.AutoSize = true;
			labelTipoEntidad.Location = new Point(528, 102);
			labelTipoEntidad.Name = "labelTipoEntidad";
			labelTipoEntidad.Size = new Size(94, 20);
			labelTipoEntidad.TabIndex = 2;
			labelTipoEntidad.Text = "Tipo Entidad";
			// 
			// radioButtonJesus
			// 
			radioButtonJesus.AutoSize = true;
			radioButtonJesus.Location = new Point(539, 125);
			radioButtonJesus.Name = "radioButtonJesus";
			radioButtonJesus.Size = new Size(63, 24);
			radioButtonJesus.TabIndex = 3;
			radioButtonJesus.TabStop = true;
			radioButtonJesus.Text = "Jesus";
			radioButtonJesus.UseVisualStyleBackColor = true;
			// 
			// radioButtonLucifer
			// 
			radioButtonLucifer.AutoSize = true;
			radioButtonLucifer.Location = new Point(539, 155);
			radioButtonLucifer.Name = "radioButtonLucifer";
			radioButtonLucifer.Size = new Size(74, 24);
			radioButtonLucifer.TabIndex = 4;
			radioButtonLucifer.TabStop = true;
			radioButtonLucifer.Text = "Lucifer";
			radioButtonLucifer.UseVisualStyleBackColor = true;
			// 
			// labelTipoTerreno
			// 
			labelTipoTerreno.AutoSize = true;
			labelTipoTerreno.Location = new Point(404, 102);
			labelTipoTerreno.Name = "labelTipoTerreno";
			labelTipoTerreno.Size = new Size(93, 20);
			labelTipoTerreno.TabIndex = 5;
			labelTipoTerreno.Text = "Tipo Terreno";
			// 
			// radioButtonTerrestre
			// 
			radioButtonTerrestre.AutoSize = true;
			radioButtonTerrestre.Location = new Point(410, 125);
			radioButtonTerrestre.Name = "radioButtonTerrestre";
			radioButtonTerrestre.Size = new Size(87, 24);
			radioButtonTerrestre.TabIndex = 6;
			radioButtonTerrestre.TabStop = true;
			radioButtonTerrestre.Text = "Terrestre";
			radioButtonTerrestre.UseVisualStyleBackColor = true;
			// 
			// radioButtonAcuatico
			// 
			radioButtonAcuatico.AutoSize = true;
			radioButtonAcuatico.Location = new Point(410, 155);
			radioButtonAcuatico.Name = "radioButtonAcuatico";
			radioButtonAcuatico.Size = new Size(88, 24);
			radioButtonAcuatico.TabIndex = 7;
			radioButtonAcuatico.TabStop = true;
			radioButtonAcuatico.Text = "Acuatico";
			radioButtonAcuatico.UseVisualStyleBackColor = true;
			// 
			// ConfiguracionPartida
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(radioButtonAcuatico);
			Controls.Add(radioButtonTerrestre);
			Controls.Add(labelTipoTerreno);
			Controls.Add(radioButtonLucifer);
			Controls.Add(radioButtonJesus);
			Controls.Add(labelTipoEntidad);
			Controls.Add(textBoxNombre);
			Controls.Add(labelNombre);
			Name = "ConfiguracionPartida";
			Text = "ConfiguracionPartida";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label labelNombre;
		private TextBox textBoxNombre;
		private Label labelTipoEntidad;
		private RadioButton radioButtonJesus;
		private RadioButton radioButtonLucifer;
		private Label labelTipoTerreno;
		private RadioButton radioButtonTerrestre;
		private RadioButton radioButtonAcuatico;
		private Button buttonIniciar;
	}
}