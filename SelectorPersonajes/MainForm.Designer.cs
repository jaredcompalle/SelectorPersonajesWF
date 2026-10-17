#nullable disable
namespace SelectorPersonajes
{
    partial class MainForm
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
            tlpRaiz = new TableLayoutPanel();
            tlpBarra = new TableLayoutPanel();
            lblLista = new Label();
            cmbLista = new ComboBox();
            btnBenchmark = new Button();
            lblElegido = new Label();
            lblPosicion = new Label();
            tlpTarjeta = new TableLayoutPanel();
            btnAnterior = new Button();
            tlpCentro = new TableLayoutPanel();
            picImagen = new PictureBox();
            lblNombre = new Label();
            lblEspecie = new Label();
            lblDano = new Label();
            lblVelocidad = new Label();
            lblNivel = new Label();
            btnSiguiente = new Button();
            tlpAcciones = new TableLayoutPanel();
            btnAnadir = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            tlpOrden = new TableLayoutPanel();
            btnOrdenNivel = new Button();
            btnOrdenDano = new Button();
            btnOrdenVelocidad = new Button();
            btnElegir = new Button();
            tlpRaiz.SuspendLayout();
            tlpBarra.SuspendLayout();
            tlpTarjeta.SuspendLayout();
            tlpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            tlpAcciones.SuspendLayout();
            tlpOrden.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRaiz
            // 
            tlpRaiz.ColumnCount = 1;
            tlpRaiz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRaiz.Controls.Add(tlpBarra, 0, 0);
            tlpRaiz.Controls.Add(lblElegido, 0, 1);
            tlpRaiz.Controls.Add(lblPosicion, 0, 2);
            tlpRaiz.Controls.Add(tlpTarjeta, 0, 3);
            tlpRaiz.Controls.Add(tlpAcciones, 0, 4);
            tlpRaiz.Controls.Add(tlpOrden, 0, 5);
            tlpRaiz.Controls.Add(btnElegir, 0, 6);
            tlpRaiz.Dock = DockStyle.Fill;
            tlpRaiz.Location = new Point(0, 0);
            tlpRaiz.Name = "tlpRaiz";
            tlpRaiz.Padding = new Padding(12);
            tlpRaiz.RowCount = 7;
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpRaiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpRaiz.Size = new Size(500, 730);
            tlpRaiz.TabIndex = 0;
            // 
            // tlpBarra
            // 
            tlpBarra.ColumnCount = 3;
            tlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBarra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tlpBarra.Controls.Add(lblLista, 0, 0);
            tlpBarra.Controls.Add(cmbLista, 1, 0);
            tlpBarra.Controls.Add(btnBenchmark, 2, 0);
            tlpBarra.Dock = DockStyle.Fill;
            tlpBarra.Location = new Point(15, 15);
            tlpBarra.Name = "tlpBarra";
            tlpBarra.RowCount = 1;
            tlpBarra.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBarra.Size = new Size(470, 38);
            tlpBarra.TabIndex = 0;
            // 
            // lblLista
            // 
            lblLista.Dock = DockStyle.Fill;
            lblLista.Location = new Point(3, 0);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(49, 38);
            lblLista.TabIndex = 0;
            lblLista.Text = "Lista:";
            lblLista.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbLista
            // 
            cmbLista.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbLista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLista.FormattingEnabled = true;
            cmbLista.Items.AddRange(new object[] { "Lista personalizada (nodos)", "LinkedList<T>", "List<T>" });
            cmbLista.Location = new Point(58, 7);
            cmbLista.Name = "cmbLista";
            cmbLista.Size = new Size(279, 25);
            cmbLista.TabIndex = 1;
            cmbLista.SelectedIndexChanged += cmbLista_SelectedIndexChanged;
            // 
            // btnBenchmark
            // 
            btnBenchmark.Dock = DockStyle.Fill;
            btnBenchmark.Location = new Point(344, 4);
            btnBenchmark.Margin = new Padding(4);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(122, 30);
            btnBenchmark.TabIndex = 2;
            btnBenchmark.Text = "Benchmark…";
            btnBenchmark.UseVisualStyleBackColor = true;
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // lblElegido
            // 
            lblElegido.Dock = DockStyle.Fill;
            lblElegido.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblElegido.Location = new Point(15, 56);
            lblElegido.Name = "lblElegido";
            lblElegido.Size = new Size(470, 50);
            lblElegido.TabIndex = 1;
            lblElegido.Text = "Ningún personaje elegido";
            lblElegido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPosicion
            // 
            lblPosicion.Dock = DockStyle.Fill;
            lblPosicion.ForeColor = Color.Gray;
            lblPosicion.Location = new Point(15, 106);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(470, 28);
            lblPosicion.TabIndex = 2;
            lblPosicion.Text = "1 / 6   ·   Lista personalizada (nodos)";
            lblPosicion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpTarjeta
            // 
            tlpTarjeta.ColumnCount = 3;
            tlpTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tlpTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tlpTarjeta.Controls.Add(btnAnterior, 0, 0);
            tlpTarjeta.Controls.Add(tlpCentro, 1, 0);
            tlpTarjeta.Controls.Add(btnSiguiente, 2, 0);
            tlpTarjeta.Dock = DockStyle.Fill;
            tlpTarjeta.Location = new Point(15, 137);
            tlpTarjeta.Name = "tlpTarjeta";
            tlpTarjeta.RowCount = 1;
            tlpTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTarjeta.Size = new Size(470, 426);
            tlpTarjeta.TabIndex = 3;
            // 
            // btnAnterior
            // 
            btnAnterior.Dock = DockStyle.Fill;
            btnAnterior.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.Location = new Point(4, 4);
            btnAnterior.Margin = new Padding(4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(48, 418);
            btnAnterior.TabIndex = 0;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // tlpCentro
            // 
            tlpCentro.ColumnCount = 1;
            tlpCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentro.Controls.Add(picImagen, 0, 0);
            tlpCentro.Controls.Add(lblNombre, 0, 1);
            tlpCentro.Controls.Add(lblEspecie, 0, 2);
            tlpCentro.Controls.Add(lblDano, 0, 3);
            tlpCentro.Controls.Add(lblVelocidad, 0, 4);
            tlpCentro.Controls.Add(lblNivel, 0, 5);
            tlpCentro.Dock = DockStyle.Fill;
            tlpCentro.Location = new Point(59, 3);
            tlpCentro.Name = "tlpCentro";
            tlpCentro.RowCount = 6;
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentro.Size = new Size(352, 420);
            tlpCentro.TabIndex = 1;
            // 
            // picImagen
            // 
            picImagen.BackColor = Color.Gainsboro;
            picImagen.BorderStyle = BorderStyle.FixedSingle;
            picImagen.Dock = DockStyle.Fill;
            picImagen.Location = new Point(6, 6);
            picImagen.Margin = new Padding(6);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(340, 258);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(3, 270);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(346, 30);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Arthur";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEspecie
            // 
            lblEspecie.Dock = DockStyle.Fill;
            lblEspecie.Location = new Point(3, 300);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(346, 30);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "Species: Caballero";
            lblEspecie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDano
            // 
            lblDano.Dock = DockStyle.Fill;
            lblDano.Location = new Point(3, 330);
            lblDano.Name = "lblDano";
            lblDano.Size = new Size(346, 30);
            lblDano.TabIndex = 3;
            lblDano.Text = "Atack: 45";
            lblDano.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVelocidad
            // 
            lblVelocidad.Dock = DockStyle.Fill;
            lblVelocidad.Location = new Point(3, 360);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(346, 30);
            lblVelocidad.TabIndex = 4;
            lblVelocidad.Text = "Velocidad de ataque: 1.2";
            lblVelocidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNivel
            // 
            lblNivel.Dock = DockStyle.Fill;
            lblNivel.Location = new Point(3, 390);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(346, 30);
            lblNivel.TabIndex = 5;
            lblNivel.Text = "Level: 12";
            lblNivel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Dock = DockStyle.Fill;
            btnSiguiente.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(418, 4);
            btnSiguiente.Margin = new Padding(4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(48, 418);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // tlpAcciones
            // 
            tlpAcciones.ColumnCount = 3;
            tlpAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpAcciones.Controls.Add(btnAnadir, 0, 0);
            tlpAcciones.Controls.Add(btnEditar, 1, 0);
            tlpAcciones.Controls.Add(btnEliminar, 2, 0);
            tlpAcciones.Dock = DockStyle.Fill;
            tlpAcciones.Location = new Point(15, 569);
            tlpAcciones.Name = "tlpAcciones";
            tlpAcciones.RowCount = 1;
            tlpAcciones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAcciones.Size = new Size(470, 42);
            tlpAcciones.TabIndex = 4;
            // 
            // btnAnadir
            // 
            btnAnadir.Dock = DockStyle.Fill;
            btnAnadir.Location = new Point(4, 4);
            btnAnadir.Margin = new Padding(4);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(148, 34);
            btnAnadir.TabIndex = 0;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Location = new Point(160, 4);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(148, 34);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEdit_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Location = new Point(316, 4);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnDelete_Click;
            // 
            // tlpOrden
            // 
            tlpOrden.ColumnCount = 3;
            tlpOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpOrden.Controls.Add(btnOrdenNivel, 0, 0);
            tlpOrden.Controls.Add(btnOrdenDano, 1, 0);
            tlpOrden.Controls.Add(btnOrdenVelocidad, 2, 0);
            tlpOrden.Dock = DockStyle.Fill;
            tlpOrden.Location = new Point(15, 617);
            tlpOrden.Name = "tlpOrden";
            tlpOrden.RowCount = 1;
            tlpOrden.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpOrden.Size = new Size(470, 42);
            tlpOrden.TabIndex = 5;
            // 
            // btnOrdenNivel
            // 
            btnOrdenNivel.Dock = DockStyle.Fill;
            btnOrdenNivel.Location = new Point(4, 4);
            btnOrdenNivel.Margin = new Padding(4);
            btnOrdenNivel.Name = "btnOrdenNivel";
            btnOrdenNivel.Size = new Size(148, 34);
            btnOrdenNivel.TabIndex = 0;
            btnOrdenNivel.Text = "Level ↓";
            btnOrdenNivel.UseVisualStyleBackColor = true;
            btnOrdenNivel.Click += btnOrdenNivel_Click;
            // 
            // btnOrdenDano
            // 
            btnOrdenDano.Dock = DockStyle.Fill;
            btnOrdenDano.Location = new Point(160, 4);
            btnOrdenDano.Margin = new Padding(4);
            btnOrdenDano.Name = "btnOrdenDano";
            btnOrdenDano.Size = new Size(148, 34);
            btnOrdenDano.TabIndex = 1;
            btnOrdenDano.Text = "Atack ↓";
            btnOrdenDano.UseVisualStyleBackColor = true;
            btnOrdenDano.Click += btnOrdenDano_Click;
            // 
            // btnOrdenVelocidad
            // 
            btnOrdenVelocidad.Dock = DockStyle.Fill;
            btnOrdenVelocidad.Location = new Point(316, 4);
            btnOrdenVelocidad.Margin = new Padding(4);
            btnOrdenVelocidad.Name = "btnOrdenVelocidad";
            btnOrdenVelocidad.Size = new Size(150, 34);
            btnOrdenVelocidad.TabIndex = 2;
            btnOrdenVelocidad.Text = "Velocidad ↑";
            btnOrdenVelocidad.UseVisualStyleBackColor = true;
            btnOrdenVelocidad.Click += btnOrdenVelocidad_Click;
            // 
            // btnElegir
            // 
            btnElegir.Dock = DockStyle.Fill;
            btnElegir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnElegir.Location = new Point(16, 666);
            btnElegir.Margin = new Padding(4);
            btnElegir.Name = "btnElegir";
            btnElegir.Size = new Size(468, 48);
            btnElegir.TabIndex = 6;
            btnElegir.Text = "Elegir personaje";
            btnElegir.UseVisualStyleBackColor = true;
            btnElegir.Click += btnElegir_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 730);
            Controls.Add(tlpRaiz);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(480, 718);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selector de personajes";
            FormClosed += MainForm_FormClosed;
            tlpRaiz.ResumeLayout(false);
            tlpBarra.ResumeLayout(false);
            tlpTarjeta.ResumeLayout(false);
            tlpCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            tlpAcciones.ResumeLayout(false);
            tlpOrden.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRaiz;
        private TableLayoutPanel tlpBarra;
        private Label lblLista;
        private ComboBox cmbLista;
        private Button btnBenchmark;
        private Label lblElegido;
        private Label lblPosicion;
        private TableLayoutPanel tlpTarjeta;
        private Button btnAnterior;
        private TableLayoutPanel tlpCentro;
        private PictureBox picImagen;
        private Label lblNombre;
        private Label lblEspecie;
        private Label lblDano;
        private Label lblVelocidad;
        private Label lblNivel;
        private Button btnSiguiente;
        private TableLayoutPanel tlpAcciones;
        private Button btnAnadir;
        private Button btnEditar;
        private Button btnEliminar;
        private TableLayoutPanel tlpOrden;
        private Button btnOrdenNivel;
        private Button btnOrdenDano;
        private Button btnOrdenVelocidad;
        private Button btnElegir;
    }
}
