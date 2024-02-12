using System.ComponentModel;

namespace Dominio
{
    public class Libro

    {
        public int LibroId{ get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string UrlFotoAutor { get; set; }
        [DisplayName("Género")]
        public string Genero { get; set; }
        [DisplayName("Año Publicado")]
        public int AnioPublicacion { get; set; }
        public int Stock { get; set; }
        public string UrlPortada { get; set; }
        
    }
}
