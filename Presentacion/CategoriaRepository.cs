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

        public IEnumerable<Categoria> DarCategoria()
        {
            var categorias = new List<Categoria>();
            SqlConnection connection = CrearConexion();

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @" SELECT Categoria.*
                                    FROM     Categoria";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var categoria = new Categoria();
                categoria.IdCategoria = (int)dataReader["IdCategoria"];
                categoria.NombreCategoria = (string)dataReader["NombreCategoria"];
                categoria.DescripcionCategoria = (string)dataReader["DescripcionCategoria"];

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

        public void Actualizar(Categoria categoria)
        {
            SqlConnection connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = @"UPDATE [dbo].[Categoria]
                                    SET [NombreCategoria] = @NombreCategoria
                                    ,[DescripcionCategoria] = @DescripcionCategoria
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

    }
}
