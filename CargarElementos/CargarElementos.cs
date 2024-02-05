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

        public void Agregar(Libro nuevoLibro, Autor nuevoAutor, Genero nuevoGenero ) 
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetQuery("insert into Libros (Titulo, AnioPublicacion,Stock,UrlImagen)values('" + nuevoLibro.Titulo + "',"+nuevoLibro.AñoPublicado +" ," + nuevoLibro.Stock + ",'" + nuevoLibro.UrlImagen + "')");
                accesoDatos.SetQuery("insert into Autores(Nombre, UrlFoto)values('" + nuevoAutor.Nombre+"','"+nuevoAutor.UrlFoto+"')");
                accesoDatos.SetQuery("insert into Generos (Nombre)values('" + nuevoGenero.Nombre + "')");
                
                
                accesoDatos.executeAction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                accesoDatos.closeConnection();
            }
        }

    }
}
