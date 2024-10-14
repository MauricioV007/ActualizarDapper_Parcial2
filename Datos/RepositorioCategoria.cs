using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // Clase que actúa como repositorio para la entidad Categorías, gestionando las operaciones de acceso a datos
    public class RepositorioCategoria
    {
        // Método que obtiene todas las categorías de la base de datos
        public List<Categorias> ObtenerTodo()
        {
            // Abre una conexión a la base de datos
            using (var conexion = BaseDeDatos.GetSqlConnection())
            {
                // Consulta SQL para seleccionar todas las columnas de la tabla Categories
                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [CategoryID] " + "\n";
                SelectAll = SelectAll + "      ,[CategoryName] " + "\n";
                SelectAll = SelectAll + "      ,[Description] " + "\n";
                SelectAll = SelectAll + "      ,[Picture] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Categories]";

                // Ejecuta la consulta y convierte el resultado en una lista de objetos Categorias
                var Categoriass = conexion.Query<Categorias>(SelectAll).ToList();
                // Retorna la lista de categorías
                return Categoriass;
            }
        }

        // Método que obtiene una categoría específica por su ID
        public Categorias ObtenerPoeID(int id)
        {
            // Abre una conexión a la base de datos
            using (var conexion = BaseDeDatos.GetSqlConnection())
            {
                // Consulta SQL para seleccionar una categoría por su ID
                String SelectID = "";
                SelectID = SelectID + "SELECT [CategoryID] " + "\n";
                SelectID = SelectID + "      ,[CategoryName] " + "\n";
                SelectID = SelectID + "      ,[Description] " + "\n";
                SelectID = SelectID + "      ,[Picture] " + "\n";
                SelectID = SelectID + "  FROM [dbo].[Categories] " + "\n";
                SelectID = SelectID + "  WHERE CategoryID = @CategoryID";

                // Ejecuta la consulta y obtiene la primera categoría que coincide con el ID proporcionado
                var Categoriass = conexion.QueryFirstOrDefault<Categorias>(SelectID, new { CategoryID = id });
                // Retorna la categoría encontrada o null si no se encuentra
                return Categoriass;
            }
        }

        // Método que actualiza una categoría existente en la base de datos
        public int ActualizarCategoria(Categorias categoria)
        {
            // Abre una conexión a la base de datos
            using (var conexion = BaseDeDatos.GetSqlConnection())
            {
                // Consulta SQL para actualizar una categoría
                string UpdateaCate = "";
                UpdateaCate += "UPDATE [dbo].[Categories] ";
                UpdateaCate += "SET CategoryName = @CategoryName, ";
                UpdateaCate += "Description = @Description, ";
                UpdateaCate += "Picture = @Picture ";
                UpdateaCate += "WHERE CategoryID = @CategoryID;";

                // Ejecuta la consulta de actualización y retorna el número de filas afectadas
                var filasActualizadas = conexion.Execute(UpdateaCate, new
                {
                    CategoryID = categoria.CategoryID,  // ID de la categoría a actualizar
                    CategoryName = categoria.CategoryName, // Nuevo nombre de la categoría
                    Description = categoria.Description,   // Nueva descripción de la categoría
                    Picture = categoria.Picture             // Nueva imagen de la categoría
                });

                // Retorna el número de filas actualizadas
                return filasActualizadas;
            }
        }
    }
}
