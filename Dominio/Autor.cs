namespace Dominio
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}

