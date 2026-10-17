namespace SelectorPersonajes;

/// <summary>Segundo formulario: cada campo del personaje se edita por separado.</summary>
public partial class EditorForm : Form
{
    private readonly bool _esNuevo;
    private readonly string? _rutaImagen;

    /// <summary>Personaje resultante (solo válido si el diálogo devolvió OK).</summary>
    public Personaje? Resultado { get; private set; }

    public EditorForm() : this(null) { }

    public EditorForm(Personaje? original)
    {
        InitializeComponent();

        _esNuevo = original == null;
        _rutaImagen = original?.RutaImagen;
        Text = _esNuevo ? "Nuevo personaje" : "Editar personaje";

        cmbEspecie.Items.Clear();
        cmbEspecie.Items.AddRange(Personaje.EspeciesBase);

        // Valores iniciales
        if (original != null)
        {
            txtNombre.Text = original.Name;
            cmbEspecie.Text = original.Species;
            nudDano.Value = Math.Clamp(original.Atack, (int)nudDano.Minimum, (int)nudDano.Maximum);
            nudVelocidad.Value = Math.Clamp((decimal)original.AtackSpeed, nudVelocidad.Minimum, nudVelocidad.Maximum);
            nudNivel.Value = Math.Clamp(original.Level, (int)nudNivel.Minimum, (int)nudNivel.Maximum);
        }
        else
        {
            cmbEspecie.SelectedIndex = 0;
            nudDano.Value = 10;
            nudVelocidad.Value = 1M;
            nudNivel.Value = 1;
        }
    }

    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        string nombre = txtNombre.Text.Trim();
        string especie = cmbEspecie.Text.Trim();

        if (nombre == "")
        {
            MessageBox.Show(this, "El nombre no puede estar vacío.", "Dato requerido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNombre.Focus();
            return;
        }

        if (especie == "")
        {
            MessageBox.Show(this, "La especie no puede estar vacía.", "Dato requerido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbEspecie.Focus();
            return;
        }

        var respuesta = MessageBox.Show(this,
            _esNuevo ? "¿Guardar el nuevo personaje?" : "¿Guardar los cambios de este personaje?",
            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (respuesta != DialogResult.Yes) return;

        Resultado = new Personaje(nombre, especie, (int)nudDano.Value, (double)nudVelocidad.Value, (int)nudNivel.Value)
        {
            RutaImagen = _rutaImagen
        };

        DialogResult = DialogResult.OK;   // cierra el formulario
    }
}
