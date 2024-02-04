using Accesodatos;
using Dominio;
using System;
using System.Collections.Generic;

namespace Cargarelementos
{
    public class CargarElemento
    {
        public List<Libro> Listar()
        {
            List<Libro> lista = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("select LibroID, Titulo, A.Nombre , G.Nombre ,AnioPublicacion,Stock, A.UrlFoto, UrlImagen from Libros L, Autores A, Generos G where L.AutorID = A.AutorID and L.LibroID = G.GeneroID");
                datos.executeRead();

                while (datos.Lector.Read())
                {
                    Libro aux = new Libro();
                    aux.LibroID = (int)datos.Lector["LibroID"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.NombreAutor = new Autor();
                    aux.NombreAutor.Nombre = (string)datos.Lector["Nombre"];
                    //aux.GeneroID = (int)datos.Lector["GeneroID"];
                    aux.AñoPublicado = (int)datos.Lector["AnioPublicacion"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.UrlFoto = (string)datos.Lector["UrlFoto"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.closeConnection();
            }
        }
    }
}
