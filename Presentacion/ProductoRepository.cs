using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class ProductoRepository
    {
        private readonly IConfiguration configuration;

        public ProductoRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public IEnumerable<Producto> DarProducto()
        {
            var productos = new List<Producto>();
            SqlConnection connection = CrearConexion();

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @" SELECT Producto.*
                                    FROM     Producto";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var producto = new Producto();
                producto.IdProducto = (int)dataReader["IdProducto"];
                producto.NombreProducto = (string)dataReader["NombreProducto"];
                producto.DescripcionProducto = (string)dataReader["DescripcionProducto"];
                producto.PrecioUnitario = (decimal)dataReader["PrecioUnitario"];
                productos.Add(producto);
            }
            connection.Close();

            return productos;

        }

        private SqlConnection CrearConexion()
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        public void Crear(Producto producto)
        {
            SqlConnection connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO [dbo].[Producto]
                                 ([IdCategoria]
                                 ,[IdSuplidor]
                                 ,[NombreProducto]
                                 ,[DescripcionProducto]
                                 ,[PrecioUnitario])
                              VALUES
                                 (@IdCategoria
                                  ,@IdSuplidor
                                  ,@NombreProducto
                                  ,@DescripcionProducto
                                  ,@PrecioUnitario)";
            command.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
            command.Parameters.AddWithValue("@IdSuplidor", producto.IdSuplidor);
            command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
            command.Parameters.AddWithValue("@DescripcionProducto", producto.DescripcionProducto);
            command.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }

        public void Borrar(int IdProducto)
        {
            var connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Producto WHERE IdProducto= @IdProducto";
            command.Parameters.AddWithValue("@IdProducto", IdProducto);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Actualizar(Producto producto)
        {
            SqlConnection connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = @"UPDATE [dbo].[Producto]
                                 SET [IdCategoria] = @IdCategoria
                                ,[IdSuplidor] = @IdSuplidor
                                ,[NombreProducto] = @NombreProducto
                                ,[DescripcionProducto] = @DescripcionProducto
                                ,[PrecioUnitario] = @PrecioUnitario
                            WHERE IdProducto= @IdProducto";
            command.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
            command.Parameters.AddWithValue("@IdSuplidor", producto.IdSuplidor);
            command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
            command.Parameters.AddWithValue("@DescripcionProducto", producto.DescripcionProducto);
            command.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
            command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }


    }

    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdSuplidor { get; set; }
        public int IdCategoria { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioUnitario { get; set; }

    }
}
