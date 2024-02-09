namespace Dominio
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string NombreAutor { get; set; }
        public string UrlFotoAutor { get; set; }
        public override string ToString()
        {
            return NombreAutor;
        }
    }
}

