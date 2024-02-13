﻿using Accesodatos;
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
                datos.SetQuery("Select id , Titulo, autor , UrlFotoAutor,Genero, AnioPublicacion, Stock, UrlPortada From Libros");
                datos.executeRead();

                while (datos.Lector.Read())
                {
                    Libro aux = new Libro();
                    aux.LibroId = (int)datos.Lector["id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Autor = (string)datos.Lector["autor"];
                    aux.UrlFotoAutor = (string)datos.Lector["UrlFotoAutor"];
                    aux.Genero = (string)datos.Lector["Genero"];
                    aux.AnioPublicacion = (int)datos.Lector["AnioPublicacion"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.UrlPortada = (string)datos.Lector["UrlPortada"];

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

        public void Agregar(Libro nuevoLibro) 
        {
            
            AccesoDatos datos = new AccesoDatos();

            try
            { 
                datos.SetQuery("insert into Libros (Titulo, Autor ,Genero, AnioPublicacion, Stock, UrlPortada,UrlFotoAutor)values('" + nuevoLibro.Titulo + "','"+nuevoLibro.Autor +"','" + nuevoLibro.Genero + "'," + nuevoLibro.AnioPublicacion + ","+nuevoLibro.Stock+",'"+nuevoLibro.UrlPortada+ "','"+nuevoLibro.UrlFotoAutor+"')");
                datos.executeAction();
                datos.closeConnection();
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

        public void Modificar(Libro libro)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("update Libros set Titulo = @Titulo, Autor = @Autor, Genero = @Genero, AnioPublicacion = @AnioPublicacion, Stock = @Stock, UrlPortada = @UrlPortada, UrlFotoAutor = @UrlFotoAutor where id = @LibroId");
                datos.setearParametro("@Titulo", libro.Titulo);
                datos.setearParametro("@Autor",libro.Autor);
                datos.setearParametro("@Genero", libro.Genero);
                datos.setearParametro("@AnioPublicacion", libro.AnioPublicacion);
                datos.setearParametro("@Stock", libro.Stock);
                datos.setearParametro("@UrlPortada", libro.UrlPortada);
                datos.setearParametro("@UrlFotoAutor", libro.UrlFotoAutor);
                datos.setearParametro("@LibroId", libro.LibroId);

                datos.executeAction();

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

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("delete from Libros where id = @id");
                datos.setearParametro("@id", id);
                datos.executeAction();

            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.closeConnection();}
        }

        public List<Libro> filtrar(string campo, string criterio, string filtro)
        {
            List<Libro> lista = new List<Libro>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select id , Titulo, autor , UrlFotoAutor,Genero, AnioPublicacion, Stock, UrlPortada From Libros ";

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
