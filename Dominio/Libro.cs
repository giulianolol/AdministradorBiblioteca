namespace Dominio
{
    public class Libro
    {
        public int LibroID { get; set; }
        public string Titulo { get; set; }
        public int GeneroID { get; set; }
        public string UrlImagen { get; set; }
        public int AñoPublicado { get; set; }
        public int Stock { get; set; }
        public int AutorID { get; set; }
        public string UrlFoto { get; set; }
        public Autor NombreAutor { get; set; }
    }
}
