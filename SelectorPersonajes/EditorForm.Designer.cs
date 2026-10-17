#nullable disable
namespace SelectorPersonajes
{
    partial class EditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEspecie = new Label();
            cmbEspecie = new ComboBox();
            lblDano = new Label();
            nudDano = new NumericUpDown();
            lblVelocidad = new Label();
            nudVelocidad = new NumericUpDown();
            lblNivel = new Label();
            nudNivel = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVelocidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNivel).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Name:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 30);
            txtNombre.TabIndex = 1;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(20, 68);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(68, 23);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "Species:";
            // 
            // cmbEspecie
            // 
            cmbEspecie.FormattingEnabled = true;
            cmbEspecie.Location = new Point(190, 64);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(190, 31);
            cmbEspecie.TabIndex = 3;
            // 
            // lblDano
            // 
            lblDano.AutoSize = true;
            lblDano.Location = new Point(20, 112);
            lblDano.Name = "lblDano";
            lblDano.Size = new Size(119, 23);
            lblDano.TabIndex = 4;
            lblDano.Text = "Atack de ataque:";
            // 
            // nudDano
            // 
            nudDano.Location = new Point(190, 108);
            nudDano.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudDano.Name = "nudDano";
            nudDano.Size = new Size(190, 30);
            nudDano.TabIndex = 5;
            nudDano.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(20, 156);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(155, 23);
            lblVelocidad.TabIndex = 6;
            lblVelocidad.Text = "Velocidad de ataque:";
            // 
            // nudVelocidad
            // 
            nudVelocidad.DecimalPlaces = 2;
            nudVelocidad.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudVelocidad.Location = new Point(190, 152);
            nudVelocidad.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudVelocidad.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudVelocidad.Name = "nudVelocidad";
            nudVelocidad.Size = new Size(190, 30);
            nudVelocidad.TabIndex = 7;
            nudVelocidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(20, 200);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(50, 23);
            lblNivel.TabIndex = 8;
            lblNivel.Text = "Level:";
            // 
            // nudNivel
            // 
            nudNivel.Location = new Point(190, 196);
            nudNivel.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudNivel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNivel.Name = "nudNivel";
            nudNivel.Size = new Size(190, 30);
            nudNivel.TabIndex = 9;
            nudNivel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 250);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 36);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(270, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 36);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // EditorForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(400, 306);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudNivel);
            Controls.Add(lblNivel);
            Controls.Add(nudVelocidad);
            Controls.Add(lblVelocidad);
            Controls.Add(nudDano);
            Controls.Add(lblDano);
            Controls.Add(cmbEspecie);
            Controls.Add(lblEspecie);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar personaje";
            ((System.ComponentModel.ISupportInitialize)nudDano).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVelocidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNivel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEspecie;
        private ComboBox cmbEspecie;
        private Label lblDano;
        private NumericUpDown nudDano;
        private Label lblVelocidad;
        private NumericUpDown nudVelocidad;
        private Label lblNivel;
        private NumericUpDown nudNivel;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
