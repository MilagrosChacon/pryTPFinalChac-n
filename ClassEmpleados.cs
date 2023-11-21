using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTPFinalChacón
{
    internal class ClassEmpleados
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;

        DataSet objDataSet = new DataSet();

        public string cadenaConexion;

        public ClassEmpleados(string empleados)
        {

            cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EMPLEADO.accdb";
            conexionBD = new OleDbConnection(cadenaConexion);
        }

        public DataTable ObtenerEmpleados()
        {
            DataTable tablaEmpleados = new DataTable();

            try
            {
                conexionBD.Open();

                string consulta = "SELECT * FROM Empleados";
                OleDbDataAdapter adaptadorBD = new OleDbDataAdapter(consulta, conexionBD);
                adaptadorBD.Fill(tablaEmpleados);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener empleados: {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }

            return tablaEmpleados;
        }

        public DataTable FiltrarPorApellido(string apellido)
        {
            DataTable tablaEmpleados = new DataTable();

            try
            {
                conexionBD.Open();

                string consulta = "SELECT * FROM Empleados WHERE Apellido LIKE @APELLIDO";
                OleDbDataAdapter adaptadorBD = new OleDbDataAdapter(consulta, conexionBD);
                adaptadorBD.SelectCommand.Parameters.AddWithValue("@APELLIDO", "%" + apellido + "%");
                adaptadorBD.Fill(tablaEmpleados);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al filtrar empleados por apellido: {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }

            return tablaEmpleados;
        }

        public DataTable FiltrarPorDireccion(string direccion)
        {
            DataTable tablaEmpleados = new DataTable();

            try
            {
                conexionBD.Open();

                string consulta = "SELECT * FROM Empleados WHERE Direccion LIKE DIRECCIÒN";
                OleDbDataAdapter adaptadorBD = new OleDbDataAdapter(consulta, conexionBD);
                adaptadorBD.SelectCommand.Parameters.AddWithValue("DIRECCIÒN", "%" + direccion + "%");
                adaptadorBD.Fill(tablaEmpleados);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al filtrar empleados por dirección: {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }

            return tablaEmpleados;
        }

        public void RegistrarEmpleado(string nombre, string apellido, string ciudad, string direccion)
        {
            try
            {
                conexionBD.Open();

                string consulta = "INSERT INTO Empleados (Nombre, Apellido, Ciudad, Dirección, Numero) VALUES (NOMBRE, APELLIDO, CIUDAD, DIRECCIÒN)";
                OleDbCommand comandoBD = new OleDbCommand(consulta, conexionBD);
                comandoBD.Parameters.AddWithValue("NOMBRE", nombre);
                comandoBD.Parameters.AddWithValue("APELLIDO", apellido);
                comandoBD.Parameters.AddWithValue("CIUDAD", ciudad);
                comandoBD.Parameters.AddWithValue("DIRECCIÒN", direccion);

                comandoBD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar empleado: {ex.Message}");
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
