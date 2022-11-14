using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryGordilloDeporteTp
{
    internal class clsDeportista
    {
        // Connection, permite conectarnos con la base de datos
        private OleDbConnection Conexion = new OleDbConnection();

        // Command, permite enviar una orden a la base de dato
        private OleDbCommand Comando = new OleDbCommand();

        /* Adapter, convierte los datos que estan en la base de dato
        en un conjunto de valores entendidos por .net */
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        // Guardamos el nombre de la base de dato
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb";

        // Indicamos a cual tabla vamos a acceder
        private string Tabla = "DEPORTISTA";


        // Declaro de manera local las variables
        private string CodigoDeportista;
        private string NombreDeportista;
        private string ApellidoDeportista;
        private string DireccionDeportista;
        private string Deporte;
        private Int32 TelefonoDeportista;
        private Int32 EdadDeportista;

        // Declaro las propiedades de las variables
        // Get: Retorna lo de las variables
        // Set: Toma el valor y lo almacena
        public string CDeportista
        {
            get { return CodigoDeportista; }
            set { CodigoDeportista = value; }
        }

        public string Nombre
        {
            get { return NombreDeportista; }
            set { NombreDeportista = value; }
        }

        public string Apellido
        {
            get { return ApellidoDeportista; }
            set { ApellidoDeportista = value; }
        }

        public string Direccion
        {
            get { return DireccionDeportista; }
            set { DireccionDeportista = value; }
        }

        public Int32 Telefono
        {
            get { return TelefonoDeportista; }
            set { TelefonoDeportista = value; }
        }

        public Int32 Edad
        {
            get { return EdadDeportista; }
            set { EdadDeportista = value; }
        }

        public string Deportes
        {
            get { return Deporte; }
            set { Deporte = value; }
        }

        public void Listar(DataGridView DGVConsultaDeportista)
        {
            // Este procedimiento es para que en una grilla muestre todos los deportistas
            try
            {
                
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                // El comando toma la conexion
                Comando.Connection = Conexion;
                // Este comando me trae la tabla del access
                Comando.CommandType = CommandType.TableDirect;
                // Selecciona la tabla
                Comando.CommandText = Tabla;
                Adaptador = new OleDbDataAdapter(Comando);
                // Almacena todo en una "tabla"
                DataSet DataConsulta = new DataSet();
                Adaptador.Fill(DataConsulta);
                // Mostraria todo en la grilla
                // La propiedad DataSource toma todo el contenido de un DataSet
                DGVConsultaDeportista.DataSource = DataConsulta.Tables[0];

                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString()); 
            }
        }

        public void Buscar(string Codigo)
        {
            // Procedimiento para buscar un deportista
            try
            {
                // Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                // El comando toma la conexion
                Comando.Connection = Conexion;
                // Este comando me trae la tabla del access
                Comando.CommandType = CommandType.TableDirect;
                // Selecciona la tabla
                Comando.CommandText = Tabla;
                // Recibo el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                // Si hay registros ingresa
                if (Lector.HasRows)
                {
                    // Mientras tenga datos en la tabla, esto lo va a leer
                    while (Lector.Read())
                    {
                        if (Lector.GetString(0) == Codigo)
                        {
                            CodigoDeportista = Lector.GetString(0);
                            NombreDeportista = Lector.GetString(1);
                            ApellidoDeportista = Lector.GetString(2);
                            DireccionDeportista = Lector.GetString(3);
                            TelefonoDeportista = int.Parse(Lector.GetString(4));
                            EdadDeportista = Lector.GetInt32(5);
                            Deporte = Lector.GetString(6);
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
        }

        public void Agregar()
        {
            try
            {
                string Sql = "INSERT INTO DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    "VALUES ('" + CodigoDeportista + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Edad + "','" + Deporte + "')";
                // Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                // El comando toma la conexion
                Comando.Connection = Conexion;
                // Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                // Selecciona la tabla
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron registrarse");
            }
        }

        public void Modificar(string CDeportista)
        {
            try
            {
                string Sql = "UPDATE DEPORTISTA SET NOMBRE= '" + Nombre + "',APELLIDO= '" + Apellido + "',DIRECCION= '" + Direccion + "', TELEFONO=" + Telefono + ", EDAD=" + Edad + ", DEPORTE='" + Deportes + "' WHERE [CODIGO DEPORTISTA] = '" + CDeportista + "'";
                // Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                // El comando toma la conexion
                Comando.Connection = Conexion;
                // Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                // Selecciona la tabla
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Los datos se modificaron con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron modificarse");
            }
        }

        public void Eliminar(string CodigoDeportista)
        {
            try
            {
                string Sql = "DELETE FROM DEPORTISTA WHERE ('" + CodigoDeportista + "'= [CODIGO DEPORTISTA])";
                // Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                // El comando toma la conexion
                Comando.Connection = Conexion;
                // Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                // Selecciona la tabla
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Datos borrados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron borrarse");
            }
        }
    }
}
