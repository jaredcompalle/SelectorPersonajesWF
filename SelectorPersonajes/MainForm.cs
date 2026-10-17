namespace SelectorPersonajes;

public partial class MainForm : Form
{
    private IListaPersonajes _list = ListaFactory.Crear(TipoLista.Personalizada);
    private int _index;               
    private Personaje? _selected;      

    private readonly Bitmap _placeholder = CrearPlaceholder();

    public MainForm()
    {
        InitializeComponent();

        cmbLista.SelectedIndex = 0;

        foreach (var p in Personaje.Predeterminados()) _list.Add(p);
        Refresh();
    }

    private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        if (picImagen.Image != null && picImagen.Image != _placeholder) picImagen.Image.Dispose();
        _placeholder.Dispose();
    }

    private static Bitmap CrearPlaceholder()
    {
        var bmp = new Bitmap(300, 300);
        using var g = Graphics.FromImage(bmp);
        g.Clear(Color.Gainsboro);
        using var pen = new Pen(Color.Silver, 4);
        g.DrawRectangle(pen, 2, 2, 296, 296);
        using var fuente = new Font("Segoe UI", 20F, FontStyle.Bold);
        using var formato = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        g.DrawString("IMAGEN\n(placeholder)", fuente, Brushes.Gray, new RectangleF(0, 0, 300, 300), formato);
        return bmp;
    }

    // EVENTOS
    // Tambien se usan las flechas ← → para navegar 
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (ActiveControl is not ComboBox)
        {
            if (keyData == Keys.Left) { Mover(-1); return true; }
            if (keyData == Keys.Right) { Mover(1); return true; }
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void cmbLista_SelectedIndexChanged(object? sender, EventArgs e)
    {
        var tipo = (TipoLista)cmbLista.SelectedIndex;
        if (tipo == _list.Tipo) return;

        _list = ListaFactory.Convertir(_list, tipo);   
        ActiveControl = btnSiguiente;                   
        Refresh();
    }

    private void btnBenchmark_Click(object? sender, EventArgs e)
    {
        using var dlg = new BenchmarkForm(_list.Recorrer().ToList());
        dlg.ShowDialog(this);
    }

    private void btnAnterior_Click(object? sender, EventArgs e) => Mover(-1);

    private void btnSiguiente_Click(object? sender, EventArgs e) => Mover(1);

    private void btnElegir_Click(object? sender, EventArgs e)
    {
        if (_index == _list.Count) return;
        _selected = _list[_index];
        Refresh();
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        if (_index != _list.Count) return;

        using var dlg = new EditorForm(null);
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Resultado != null)
        {
            _list.Add(dlg.Resultado);
            _index = _list.Count - 1;
            Refresh();
        }
    }

    private void btnEdit_Click(object? sender, EventArgs e)
    {
        if (_index == _list.Count) return;

        var personaje = _list[_index];
        using var dlg = new EditorForm(personaje);
        if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Resultado != null)
        {
            personaje.CopiarDe(dlg.Resultado);   
            Refresh();
        }
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (_index == _list.Count) return;

        var personaje = _list[_index];
        var respuesta = MessageBox.Show(this,
            $"¿Seguro que quieres eliminar a '{personaje.Name}'?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (respuesta != DialogResult.Yes) return;

        _list.EliminarEn(_index);   
        if (_selected == personaje) _selected = null;
        Refresh();
    }

    private void btnOrdenNivel_Click(object? sender, EventArgs e) => Ordenar(Criterios.NivelDesc);

    private void btnOrdenDano_Click(object? sender, EventArgs e) => Ordenar(Criterios.DanoDesc);

    private void btnOrdenVelocidad_Click(object? sender, EventArgs e) => Ordenar(Criterios.VelocidadAsc);

    // ───────────────────────── Lógica ─────────────────────────

    private void Mover(int direccion)
    {
        int total = _list.Count + 1;
        _index = (_index + direccion + total) % total;   // circular
        Refresh();
    }

    private void Ordenar(Comparison<Personaje> criterio)
    {
        var seleccionado = _index < _list.Count ? _list[_index] : null;
        _list.Ordenar(criterio);

        // Mantiene la selección sobre el mismo personaje
        if (seleccionado != null) _index = _list.IndiceDe(seleccionado);

        Refresh();
    }

    // ───────────────────────── Vista ─────────────────────────

    private void Refresh() 
    {
        bool esAnadir = _index == _list.Count;
        var p = esAnadir ? null : _list[_index];

        lblElegido.Text = _selected == null
            ? "Ningún personaje elegido"
            : $"Personaje elegido: {_selected.Name}";

        lblPosicion.Text = $"{_index + 1} / {_list.Count + 1}   ·   {_list.Nombre}";

        if (p == null)
        {
            lblNombre.Text = "★ Añadir nuevo personaje";
            lblEspecie.Text = lblDano.Text = lblVelocidad.Text = lblNivel.Text = "";
        }
        else
        {
            lblNombre.Text = p.Name;
            lblEspecie.Text = $"Species: {p.Species}";
            lblDano.Text = $"Atack: {p.Atack}";
            lblVelocidad.Text = $"Velocidad de ataque: {p.AtackSpeed:0.##}";
            lblNivel.Text = $"Level: {p.Level}";
        }

        btnAnadir.Enabled = esAnadir;
        btnEditar.Enabled = !esAnadir;
        btnEliminar.Enabled = !esAnadir;
        btnElegir.Enabled = !esAnadir;

        MostrarImagen(p);
    }

    private void MostrarImagen(Personaje? p)
    {
        var anterior = picImagen.Image;
        Image nueva = _placeholder;

        if (p?.RutaImagen is { } ruta && File.Exists(ruta))
        {
            try
            {
                using var temporal = Image.FromFile(ruta);
                nueva = new Bitmap(temporal);   
            }
            catch
            {
                nueva = _placeholder;
            }
        }

        picImagen.Image = nueva;
        if (anterior != null && anterior != _placeholder && anterior != nueva)
            anterior.Dispose();
    }
}
