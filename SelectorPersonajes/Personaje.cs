namespace SelectorPersonajes;

public class Personaje
{
    public static readonly string[] EspeciesBase =
        ["Humano", "Mago", "Caballero", "Arquero", "Elfo", "Enano", "Orco"];

    public string Name { get; set; } = "";
    public string Species { get; set; } = "";
    public int Atack { get; set; }
    public double AtackSpeed { get; set; }
    public int Level { get; set; }

    /// <summary>
    /// Ruta de la imagen del personaje (placeholder: si es null o no existe
    /// se muestra una imagen gris genérica). Solo la usa la versión Windows Forms.
    /// </summary>
    public string? RutaImagen { get; set; }

    /// <summary>Atack por segundo = daño × velocidad de ataque.</summary>
    public double Dps => Atack * AtackSpeed;

    public Personaje() { }

    public Personaje(string nombre, string especie, int dano, double velocidadAtaque, int nivel)
    {
        Name = nombre;
        Species = especie;
        Atack = dano;
        AtackSpeed = velocidadAtaque;
        Level = nivel;
    }

    public void CopiarDe(Personaje otro)
    {
        Name = otro.Name;
        Species = otro.Species;
        Atack = otro.Atack;
        AtackSpeed = otro.AtackSpeed;
        Level = otro.Level;
        RutaImagen = otro.RutaImagen;
    }

    public static List<Personaje> Predeterminados() =>
    [
        new("Arthur", "Caballero", 45, 1.2, 12) { RutaImagen = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\knight_wbg.jpg" },
        new("Merlín", "Mago", 70, 0.8, 20) { RutaImagen = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\Wizars.png" },
        new ("Azriel", "Arquera", 38, 2.5, 15) { RutaImagen = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\Archer.png" },
        new("Thorin", "Enano", 55, 1.0, 18) { RutaImagen = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\Duende.png" },
        new("Arlene", "Humana", 25, 1.5, 5) { RutaImagen = "C:\\Users\\usuario\\OneDrive - Instituto Tecnológico Superior de Monclova\\Imágenes\\human_wbg.jpg" },
    ];
}
