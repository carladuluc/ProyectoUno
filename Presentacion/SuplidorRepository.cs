using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class SuplidorRepository
    {
        private readonly IConfiguration configuration;

        public SuplidorRepository(IConfiguration configuration) 
        { 
            this.configuration = configuration;
        }

        //para obtener todas los suplidores activos de la base de datos.

        public IEnumerable<Suplidor> DarSuplidor()
        {
            var suplidores = new List<Suplidor>();

            SqlConnection connection = CrearConexion();

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @" SELECT Suplidor.*
                                    FROM     Suplidor
                                    WHERE IsActivo = 1";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var suplidor = new Suplidor();
                suplidor.IdSuplidor = (int)dataReader["IdSuplidor"];
                suplidor.Cedula = (string)dataReader["Cedula"];
                suplidor.Nombre = (string)dataReader["Nombre"];
                suplidor.Apellido = (string)dataReader["Apellido"];
                suplidor.NombreEmpresa = (string)dataReader["NombreEmpresa"];
                suplidor.Correo = (string)dataReader["Correo"];
                suplidor.SitioWeb = (string)dataReader["SitioWeb"];
                suplidor.Celular = (string)dataReader["Celular"];
                suplidor.Fecha_Creacion = (DateTime)dataReader["Fecha_Creacion"];
                suplidor.Fecha_Modificacion = (DateTime)dataReader["Fecha_Modificacion"];

                suplidores.Add(suplidor);
            }
            connection.Close();

            return suplidores;

        }

        private SqlConnection CrearConexion()
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);
            return connection;
        }

        //Soft-Delete
        public bool DesactivarSuplidor(int id) //Borrado lógico
        {
            using (var connection = CrearConexion())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Suplidor 
                SET IsActivo = 0, Fecha_Modificacion = GETDATE()
                WHERE IdSuplidor = @Id";

                command.Parameters.AddWithValue("@Id", id);
                return command.ExecuteNonQuery() > 0;
            }

        }

        //Crea un Suplidor
        public void Crear(Suplidor suplidor)
        {
            SqlConnection connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO [dbo].[Suplidor]
                                ([Cedula]
                                ,[Nombre]
                                ,[Apellido]
                                ,[NombreEmpresa]
                                ,[Correo]
                                ,[SitioWeb]
                                ,[Celular])
                         VALUES
                             (@Cedula
                             ,@Nombre
                             ,@Apellido
                             ,@NombreEmpresa
                             ,@Correo
                             ,@SitioWeb
                             ,@Celular)";
            command.Parameters.AddWithValue("@Cedula", suplidor.Cedula);
            command.Parameters.AddWithValue("@Nombre", suplidor.Nombre);
            command.Parameters.AddWithValue("@Apellido", suplidor.Apellido);
            command.Parameters.AddWithValue("@NombreEmpresa", suplidor.NombreEmpresa);
            command.Parameters.AddWithValue("@Correo", suplidor.Correo);
            command.Parameters.AddWithValue("@SitioWeb", suplidor.SitioWeb);
            command.Parameters.AddWithValue("@Celular", suplidor.Celular);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }

        //EL BORRADO NO SE ESTÁ UTILIZANDO SE CAMBIO POR EL SOFT-DELETE, basicamente desactivando
        public void Borrar(int IdSuplidor)
        {
            var connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = @"DELETE FROM Suplidor WHERE IdSuplidor= @IdSuplidor";
            command.Parameters.AddWithValue("@IdSuplidor", IdSuplidor);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        //Actualiza los suplidores
        public void Actualizar(Suplidor suplidor)
        {
            SqlConnection connection = CrearConexion();
            var command = connection.CreateCommand();
            command.CommandText = @"UPDATE [dbo].[Suplidor]
                                 SET [Cedula] = @Cedula
                                ,[Nombre] = @Nombre
                                ,[Apellido] = @Apellido
                                ,[NombreEmpresa] = @NombreEmpresa
                                ,[Correo] = @Correo
                                ,[SitioWeb] = @SitioWeb
                                ,[Celular] = @Celular
                                ,[Fecha_Modificacion] = GETDATE()
                            WHERE IdSuplidor= @IdSuplidor";
            command.Parameters.AddWithValue("@Cedula", suplidor.Cedula);
            command.Parameters.AddWithValue("@Nombre", suplidor.Nombre);
            command.Parameters.AddWithValue("@Apellido", suplidor.Apellido);
            command.Parameters.AddWithValue("@NombreEmpresa", suplidor.NombreEmpresa);
            command.Parameters.AddWithValue("@Correo", suplidor.Correo);
            command.Parameters.AddWithValue("@SitioWeb", suplidor.SitioWeb);
            command.Parameters.AddWithValue("@Celular", suplidor.Celular);
            command.Parameters.AddWithValue("@IdSuplidor", suplidor.IdSuplidor);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }




    }


    public class Suplidor
    {
        public int IdSuplidor { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreEmpresa { get; set; }
        public string Correo { get; set; }
        public string SitioWeb { get; set; }
        public string Celular { get; set; }

        //Para modificaciones o creaciones (un registro)
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }

    }
}
