using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Presentacion.CategoriaRepository;
using static Presentacion.ProductoRepository;

namespace Presentacion
{
    public class CategoriaRepository
    {
        private readonly IConfiguration configuration;

        public CategoriaRepository(IConfiguration configuration) 
        {
            this.configuration = configuration;
        }

        //para obtener todas las categorías activas de la base de datos.

        public IEnumerable<Categoria> DarCategoria()
        {
            var categorias = new List<Categoria>();
            SqlConnection connection = CrearConexion();

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @" SELECT Categoria.*
                                    FROM     Categoria
                                    WHERE IsActivo = 1"; // booleano (pa cuando este activo 1) especialmente sirve para el borrado lógico

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var categoria = new Categoria();
                categoria.IdCategoria = (int)dataReader["IdCategoria"];
                categoria.NombreCategoria = (string)dataReader["NombreCategoria"];
                categoria.DescripcionCategoria = (string)dataReader["DescripcionCategoria"];
                categoria.Fecha_Creacion = (DateTime)dataReader["Fecha_Creacion"];
                categoria.Fecha_Modificacion = (DateTime)dataReader["Fecha_Modificacion"];

                categorias.Add(categoria);
            }
            connection.Close();

            return categorias;

        }



        private SqlConnection CrearConexion()
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);
            return connection;
        }


        //Hace un borrado lógico en vez de eliminar  actualiza a cero para que no se muestre
        public bool DesactivarCategoria(int id) //Borrado lógico
        {
            using (var connection = CrearConexion())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Categoria 
                SET IsActivo = 0, Fecha_Modificacion = GETDATE()
                WHERE IdCategoria = @Id";

                command.Parameters.AddWithValue("@Id", id);
                return command.ExecuteNonQuery() > 0; // 0 a desactivado
            }

        }

        //Crea una categoria
        public void Crear(Categoria categoria)
        {
            SqlConnection connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO [dbo].[Categoria]
                                  ([NombreCategoria]
                                  ,[DescripcionCategoria])
                               VALUES
                                   (@NombreCategoria
                                   ,@DescripcionCategoria)";
            command.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
            command.Parameters.AddWithValue("@DescripcionCategoria", categoria.DescripcionCategoria);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }


        //Esto es para borrar completamente, NO SE ESTÁ UTILIZANDO PORQUE SE CAMBIÓ POR EL SOFT-DELETE Como si fuera desactivandolo
        public void Borrar(int IdCategoria)
        {
            var connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Categoria WHERE IdCategoria= @IdCategoria";
            command.Parameters.AddWithValue("@IdCategoria", IdCategoria);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        //Actualiza la categoria
        public void Actualizar(Categoria categoria)
        {
            SqlConnection connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = @"UPDATE [dbo].[Categoria]
                                    SET [NombreCategoria] = @NombreCategoria
                                    ,[DescripcionCategoria] = @DescripcionCategoria
                                    ,[Fecha_Modificacion] = GETDATE()
                                    WHERE IdCategoria= @IdCategoria";
            command.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
            command.Parameters.AddWithValue("@DescripcionCategoria", categoria.DescripcionCategoria);
            command.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }



    }

    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }

        //Para modificaciones o creaciones (un registro)
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

    }
}
