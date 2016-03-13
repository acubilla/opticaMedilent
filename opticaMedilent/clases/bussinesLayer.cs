using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Windows.Forms;
using System.Data;

namespace opticaMedilent.clases
 {
    #region
    public class bussinesLayer
    {
        private string cadenaCone = "User Id=AAA111;Password=BBB222;Data Source=CCC333;Connection Timeout=60; Pooling=false ";
        /// <summary>
        /// devuelve la cadena de conexion para oracle
        /// </summary>
        public string cadenaDeConeccion { get { return this.cadenaCone; } }
        /// <summary>
        /// constructor simple
        /// </summary>
        public bussinesLayer() { }
        /// <summary>
        /// contruye la clase de negocios 
        /// con datos de la BD
        /// </summary>
        /// <param name="usuario">usuario de oracle</param>
        /// <param name="passWord">password de oracle</param>
        /// <param name="dataSource">el TND a donde apuntar</param>
        public bussinesLayer(string usuario, string passWord, string dataSource)
        {
            cadenaCone = cadenaCone.Replace("AAA111", usuario).Replace("BBB222", passWord).Replace("CCC333", dataSource);
        }
#endregion
        private void MessageError(OracleException e)
        {
            MessageBox.Show("Error en el procedimiento almacenado:\n" +
                e.Procedure.Trim() + "\n" + e.Message.Trim() + "\n\n" +
                "Comunicar este error Adriano Cubilla al mail javi.eva@hotmail.com",
                "Error de compilacion SQL",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        public DataSet datosUsuario(string PI_USER_KEY,string PI_PASSWORD)
        {
            Oracle.DataAccess.Client.OracleConnection cone = new OracleConnection(this.cadenaDeConeccion);
            Oracle.DataAccess.Client.OracleDataAdapter adap = new OracleDataAdapter("OPTICA.PKG_OPTICA_MEDILENT.SP_DATOS_USUARIOS",cone);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add("PI_USER_KEY", PI_USER_KEY);
            adap.SelectCommand.Parameters.Add("PI_PASSWORD", PI_PASSWORD);
            adap.SelectCommand.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
            adap.SelectCommand.Parameters["PO_CURSOR"].Direction = ParameterDirection.InputOutput;
            DataSet datos = new DataSet();
            try
            {
                adap.SelectCommand.Connection.Open();
                adap.SelectCommand.Connection.Close();
                adap.Fill(datos);
            }
            catch (OracleException e)
            {

                MessageError(e);
            }
            return datos;
        }
        /// <summary>
        /// Metodo que Procesa la Informacion de los Datos segun El tipo de Accion
        /// </summary>
        /// <param name="PI_ID_PACIENTE"></param>
        /// <param name="PI_ACCION"></param>
        /// <param name="PI_DOCUMENTO"></param>
        /// <param name="PI_BIRTHDAY"></param>
        /// <param name="PI_NOMBRE"></param>
        /// <param name="PI_APELLIDO"></param>
        /// <param name="PI_TELEFONO"></param>
        /// <param name="PI_DIRECCION"></param>
        /// <param name="PI_TIPO_PACIENTE"></param>
        /// <returns></returns>
        public string spABMpacientes(int PI_ID_PACIENTE, int PI_ACCION, string PI_DOCUMENTO, DateTime PI_BIRTHDAY, string PI_NOMBRE, string PI_APELLIDO,
        string PI_TELEFONO, string PI_DIRECCION, int PI_TIPO_PACIENTE)
        {
            Oracle.DataAccess.Client.OracleConnection cone = new OracleConnection(this.cadenaDeConeccion);
            Oracle.DataAccess.Client.OracleDataAdapter adap = new OracleDataAdapter("OPTICA.PKG_OPTICA_MEDILENT.SP_ABM_PACIENTES", cone);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add("PI_ID_PACIENTE", PI_ID_PACIENTE);
            adap.SelectCommand.Parameters.Add("PI_ACCION", PI_ACCION);
            adap.SelectCommand.Parameters.Add("PI_DOCUMENTO", PI_DOCUMENTO);
            adap.SelectCommand.Parameters.Add("PI_BIRTHDAY", PI_BIRTHDAY);
            adap.SelectCommand.Parameters.Add("PI_NOMBRE", PI_NOMBRE);
            adap.SelectCommand.Parameters.Add("PI_APELLIDO", PI_APELLIDO);
            adap.SelectCommand.Parameters.Add("PI_TELEFONO", PI_TELEFONO);
            adap.SelectCommand.Parameters.Add("PI_DIRECCION", PI_DIRECCION);
            adap.SelectCommand.Parameters.Add("PI_TIPO_PACIENTE", PI_TIPO_PACIENTE);
            adap.SelectCommand.Parameters.Add("PO_MENSAJE", OracleDbType.Varchar2,200);
            adap.SelectCommand.Parameters["PO_MENSAJE"].Direction = ParameterDirection.InputOutput;
            string retorno = string.Empty;
            try
            {
                adap.SelectCommand.Connection.Open();
                adap.SelectCommand.ExecuteNonQuery();
                retorno = adap.SelectCommand.Parameters["PO_MENSAJE"].Value.ToString();
                adap.SelectCommand.Connection.Close();
            }
            catch (OracleException e)
            {

                MessageError(e);
            }
            return retorno;
        }
    }
}
