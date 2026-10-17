namespace SelectorPersonajes;

/// <summary>Ejecuta el benchmark (en segundo plano) y muestra los tiempos reales en una tabla.</summary>
public partial class BenchmarkForm : Form
{
    private readonly List<Personaje> _baseDatos;

    public BenchmarkForm() : this(new List<Personaje>()) { }

    public BenchmarkForm(List<Personaje> baseDatos)
    {
        InitializeComponent();

        _baseDatos = baseDatos;
        lblEstado.Text = $"Se generarán personajes a partir de los {_baseDatos.Count} actuales. Pulsa «Ejecutar benchmark».";
        lblVerificacion.Text = "";
    }

    private async void btnEjecutar_Click(object? sender, EventArgs e)
    {
        btnEjecutar.Enabled = false;
        nudCantidad.Enabled = false;
        nudRepeticiones.Enabled = false;
        dgvResultados.Rows.Clear();
        lblVerificacion.Text = "";
        lblEstado.Text = "Preparando datos…";

        int cantidad = (int)nudCantidad.Value;
        int repeticiones = (int)nudRepeticiones.Value;

        void Progreso(string mensaje)
        {
            try
            {
                if (IsHandleCreated && !IsDisposed)
                    BeginInvoke(new Action(() => lblEstado.Text = mensaje));
            }
            catch { /* el formulario se cerró durante la ejecución */ }
        }

        try
        {
            var resultado = await Task.Run(() => Benchmark.Ejecutar(_baseDatos, cantidad, repeticiones, Progreso));
            Mostrar(resultado);
        }
        catch (Exception ex)
        {
            lblEstado.Text = "Error al ejecutar el benchmark.";
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnEjecutar.Enabled = true;
            nudCantidad.Enabled = true;
            nudRepeticiones.Enabled = true;
        }
    }

    private void Mostrar(ResultadoBenchmark r)
    {
        var tipos = Enum.GetValues<TipoLista>();

        lblEstado.Text =
            $"{r.Cantidad:N0} personajes (derivados de {r.PersonajesBase}) · promedio de {r.Repeticiones} repeticiones · verde = más rápido";

        for (int i = 0; i < r.Operaciones.Length; i++)
        {
            var valores = tipos.Select(t => r.Tiempos[t][i]).ToArray();
            int fila = dgvResultados.Rows.Add(r.Operaciones[i], Fmt(valores[0]), Fmt(valores[1]), Fmt(valores[2]), r.Detalles[i]);
            Resaltar(fila, valores);
        }

        var totales = tipos.Select(t => r.Tiempos[t].Sum()).ToArray();
        int filaTotal = dgvResultados.Rows.Add("TOTAL", Fmt(totales[0]), Fmt(totales[1]), Fmt(totales[2]), "");
        dgvResultados.Rows[filaTotal].DefaultCellStyle.Font = new Font(dgvResultados.Font, FontStyle.Bold);
        Resaltar(filaTotal, totales);

        dgvResultados.ClearSelection();

        lblVerificacion.ForeColor = r.Coinciden ? Color.DarkGreen : Color.DarkRed;
        lblVerificacion.Text = r.Coinciden
            ? "✔ Las tres listas produjeron exactamente los mismos resultados."
            : "⚠ Los resultados difieren entre listas (revisar).";
    }

    private static string Fmt(double ms) => ms.ToString("N3");

    private void Resaltar(int fila, double[] valores)
    {
        double minimo = valores.Min();
        for (int k = 0; k < valores.Length; k++)
        {
            if (valores[k] == minimo)
            {
                var celda = dgvResultados.Rows[fila].Cells[k + 1];
                celda.Style.BackColor = Color.LightGreen;
                celda.Style.ForeColor = Color.Black;
            }
        }
    }
}
