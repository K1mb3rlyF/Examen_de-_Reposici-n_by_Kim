using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_de__Reposición_by_Kim
{
    class conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet miDs = new DataSet();

        public conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_parque_vehicular_Funes_KimberlyDataSet.tbl_vehiculos";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from Vehiculos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "Vehiculos");

          
            return miDs;
        }

        private class SqlConnection
        {
            public SqlConnection()
            {
            }

            public string ConnectionString { get; internal set; }

            internal void Open()
            {
                throw new NotImplementedException();
            }

            public static implicit operator System.Data.SqlClient.SqlConnection(SqlConnection v)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class DataSet
    {
        internal void Clear()
        {
            throw new NotImplementedException();
        }
    }

    internal class SqlDataAdapter
    {
        internal SqlCommand SelectCommand;

        internal void Fill(DataSet miDs, string v)
        {
            throw new NotImplementedException();
        }
    }

    internal class SqlCommand
    {
        internal SqlConnection Connection;
        internal string CommandText;
    }
}