using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class FotoRepository
    {
        private readonly IConfiguration configuration; //Dependencia De conexión al JSON

        public FotoRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        private SqlConnection CrearConexion()
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);
            return connection;
        }


        //Este método guarda una nueva foto en la base de datos. como es booleana me devuelve true si se insertó en la BD y sino False
        public bool GuardarFoto(Foto foto)
        {
            using (var connection = CrearConexion())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            INSERT INTO Foto (IdCategoria, Imagen, NombreArchivo, Fecha_Creacion, Fecha_Modificacion, IsActivo)
            VALUES (@IdCategoria, @Imagen, @NombreArchivo, GETDATE(), GETDATE(), 1)";

                command.Parameters.AddWithValue("@IdCategoria", foto.IdCategoria);
                command.Parameters.AddWithValue("@Imagen", foto.Imagen);
                command.Parameters.AddWithValue("@NombreArchivo", foto.NombreArchivo);

                return command.ExecuteNonQuery() > 0;
            }
        }

        //Devuelve la lista completa de fotos, muestra toda la información de cada foto. esta es la de 
        public List<Foto> ObtenerFotosPorCategoria(int idCategoria)
        {
            var lista = new List<Foto>();

            using (var connection = CrearConexion())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Foto WHERE IdCategoria = @IdCategoria AND IsActivo = 1";
                command.Parameters.AddWithValue("@IdCategoria", idCategoria);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Foto
                        {
                            IdFoto = Convert.ToInt32(reader["IdFoto"]),
                            IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                            Imagen = (byte[])reader["Imagen"],
                            NombreArchivo = reader["NombreArchivo"].ToString(),
                            Fecha_Creacion = Convert.ToDateTime(reader["Fecha_Creacion"]),
                            Fecha_Modificacion = Convert.ToDateTime(reader["Fecha_Modificacion"]),
                            IsActivo = Convert.ToBoolean(reader["IsActivo"])
                        });
                    }
                }
            }

            return lista;
        }

        //Este es similar al anterior pero solo selecciona columnas clave para mostrar la miniatura o los datos mínimos de la foto. esta es fuera del datagrid

        public List<Foto> ObtenerTodasPorCategoria(int idCategoria)
        {
            var lista = new List<Foto>();

            using (var connection = CrearConexion())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            SELECT IdFoto, Imagen, NombreArchivo
            FROM Foto
            WHERE IdCategoria = @IdCategoria AND IsActivo = 1";

                command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Foto
                        {
                            IdFoto = Convert.ToInt32(reader["IdFoto"]),
                            Imagen = (byte[])reader["Imagen"],
                            NombreArchivo = reader["NombreArchivo"].ToString()
                        });
                    }
                }
            }

            return lista;
        }

    }


    //Esta es mi clase, es un repositorio encargado de interactuar con la base de datos para gestionar las fotos asociadas a una categoría.
    public class Foto
    {
        public int IdFoto { get; set; }
        public int IdCategoria { get; set; }
        public byte[] Imagen { get; set; }
        public string NombreArchivo { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public bool IsActivo { get; set; }
    }
}
