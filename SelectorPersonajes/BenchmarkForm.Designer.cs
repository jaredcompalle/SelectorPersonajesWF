#nullable disable
namespace SelectorPersonajes
{
    partial class BenchmarkForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelSuperior = new Panel();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            lblRepeticiones = new Label();
            nudRepeticiones = new NumericUpDown();
            btnEjecutar = new Button();
            lblEstado = new Label();
            dgvResultados = new DataGridView();
            colOperacion = new DataGridViewTextBoxColumn();
            colPersonalizada = new DataGridViewTextBoxColumn();
            colLinkedList = new DataGridViewTextBoxColumn();
            colList = new DataGridViewTextBoxColumn();
            colDetalle = new DataGridViewTextBoxColumn();
            lblVerificacion = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRepeticiones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(btnEjecutar);
            panelSuperior.Controls.Add(nudRepeticiones);
            panelSuperior.Controls.Add(lblRepeticiones);
            panelSuperior.Controls.Add(nudCantidad);
            panelSuperior.Controls.Add(lblCantidad);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(12, 12);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(976, 52);
            panelSuperior.TabIndex = 0;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(0, 14);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(172, 23);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad de personajes:";
            // 
            // nudCantidad
            // 
            nudCantidad.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCantidad.Location = new Point(180, 11);
            nudCantidad.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 30);
            nudCantidad.TabIndex = 1;
            nudCantidad.ThousandsSeparator = true;
            nudCantidad.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // lblRepeticiones
            // 
            lblRepeticiones.AutoSize = true;
            lblRepeticiones.Location = new Point(330, 14);
            lblRepeticiones.Name = "lblRepeticiones";
            lblRepeticiones.Size = new Size(107, 23);
            lblRepeticiones.TabIndex = 2;
            lblRepeticiones.Text = "Repeticiones:";
            // 
            // nudRepeticiones
            // 
            nudRepeticiones.Location = new Point(445, 11);
            nudRepeticiones.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRepeticiones.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRepeticiones.Name = "nudRepeticiones";
            nudRepeticiones.Size = new Size(70, 30);
            nudRepeticiones.TabIndex = 3;
            nudRepeticiones.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(545, 8);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(180, 36);
            btnEjecutar.TabIndex = 4;
            btnEjecutar.Text = "Ejecutar benchmark";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // lblEstado
            // 
            lblEstado.Dock = DockStyle.Top;
            lblEstado.Location = new Point(12, 64);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(976, 30);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Estado";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AllowUserToResizeRows = false;
            dgvResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResultados.BackgroundColor = SystemColors.Window;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colOperacion, colPersonalizada, colLinkedList, colList, colDetalle });
            dgvResultados.Dock = DockStyle.Fill;
            dgvResultados.Location = new Point(12, 94);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.Size = new Size(976, 418);
            dgvResultados.TabIndex = 2;
            // 
            // colOperacion
            // 
            colOperacion.HeaderText = "Operación";
            colOperacion.Name = "colOperacion";
            colOperacion.ReadOnly = true;
            colOperacion.SortMode = DataGridViewColumnSortMode.NotSortable;
            colOperacion.Width = 230;
            // 
            // colPersonalizada
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPersonalizada.DefaultCellStyle = dataGridViewCellStyle1;
            colPersonalizada.HeaderText = "Personalizada (ms)";
            colPersonalizada.Name = "colPersonalizada";
            colPersonalizada.ReadOnly = true;
            colPersonalizada.SortMode = DataGridViewColumnSortMode.NotSortable;
            colPersonalizada.Width = 150;
            // 
            // colLinkedList
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colLinkedList.DefaultCellStyle = dataGridViewCellStyle2;
            colLinkedList.HeaderText = "LinkedList<T> (ms)";
            colLinkedList.Name = "colLinkedList";
            colLinkedList.ReadOnly = true;
            colLinkedList.SortMode = DataGridViewColumnSortMode.NotSortable;
            colLinkedList.Width = 150;
            // 
            // colList
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colList.DefaultCellStyle = dataGridViewCellStyle3;
            colList.HeaderText = "List<T> (ms)";
            colList.Name = "colList";
            colList.ReadOnly = true;
            colList.SortMode = DataGridViewColumnSortMode.NotSortable;
            colList.Width = 150;
            // 
            // colDetalle
            // 
            colDetalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            colDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            colDetalle.HeaderText = "Estadística calculada";
            colDetalle.Name = "colDetalle";
            colDetalle.ReadOnly = true;
            colDetalle.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lblVerificacion
            // 
            lblVerificacion.Dock = DockStyle.Bottom;
            lblVerificacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerificacion.Location = new Point(12, 512);
            lblVerificacion.Name = "lblVerificacion";
            lblVerificacion.Size = new Size(976, 36);
            lblVerificacion.TabIndex = 3;
            lblVerificacion.Text = "Verificación";
            lblVerificacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BenchmarkForm
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 560);
            Controls.Add(dgvResultados);
            Controls.Add(lblVerificacion);
            Controls.Add(lblEstado);
            Controls.Add(panelSuperior);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(840, 500);
            Name = "BenchmarkForm";
            Padding = new Padding(12);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Benchmark de listas";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRepeticiones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Label lblRepeticiones;
        private NumericUpDown nudRepeticiones;
        private Button btnEjecutar;
        private Label lblEstado;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colOperacion;
        private DataGridViewTextBoxColumn colPersonalizada;
        private DataGridViewTextBoxColumn colLinkedList;
        private DataGridViewTextBoxColumn colList;
        private DataGridViewTextBoxColumn colDetalle;
        private Label lblVerificacion;
    }
}
