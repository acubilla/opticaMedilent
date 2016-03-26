using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace opticaMedilent.controles
{
    public partial class altaPacienteUc : DevExpress.XtraEditors.XtraUserControl
    {
        public string _usuarioOracle = string.Empty;
        public string _passOracle = string.Empty;
        public string _tnsOracle = string.Empty;
        public DataSet dsDatosPaciente = new DataSet();
        clases.bussinesLayer capaNegocios;
        public altaPacienteUc(string usuarioOracle,string passOracle,string tnsOracle)
        {
            _usuarioOracle = usuarioOracle;
            _passOracle = passOracle;
            _tnsOracle = tnsOracle;  
            InitializeComponent();
            capaNegocios = new clases.bussinesLayer(_usuarioOracle, _passOracle, _tnsOracle);
            
        }
        /// <summary>
        /// Ocurre cuando el Control de Alta de Pacientes es cargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaPacienteUc_Load(object sender, EventArgs e)
        {
            //Inhabilitamos los controles
            inhabilitarControlesAltaPaciente(true);
            //Ocultamos el boton de Busqueda
            marquePacientes.Visible = false;
            pacientesLabel.Visible = false;
            dsDatosPaciente = capaNegocios.datosPaciente(string.Empty);   
        }
        /// <summary>
        /// Metodo que Inhabilita Controles segun el tipo de Accion
        /// </summary>
        /// <param name="accion"></param>
        private void inhabilitarControlesAltaPaciente(bool accion)
        {
            if (accion)
            {
                txtNombrePaciente.Enabled = false;
                txtApellido.Enabled = false;
                txtDocumento.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
                txtTelefono.Enabled = false;
                txtDireccion.Enabled = false;
            }
            else
            {
                txtNombrePaciente.Enabled = true;
                txtApellido.Enabled = true;
                txtDocumento.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
                txtTelefono.Enabled = true;
                txtDireccion.Enabled = true;
            }
        }
        /// <summary>
        /// Metodo que Crea Nuevo Paciente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertPacienteButton_Click(object sender, EventArgs e)
        {
            //Llamamos al Metodo que Habilita los controles
            inhabilitarControlesAltaPaciente(false);
        }

        private void updatePacienteButton_Click(object sender, EventArgs e)
        {
            PacientesBW.RunWorkerAsync();   
        }

        private void PacientesBW_DoWork(object sender, DoWorkEventArgs e)
        {
            //dsDatosPaciente = capaNegocios.datosPaciente();
            
        }

        private void PacientesBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            marquePacientes.Visible=false;
            pacientesLabel.Visible = false;
        }
    }
}
