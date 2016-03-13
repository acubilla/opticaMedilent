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
        clases.bussinesLayer capaNegocios;
        public altaPacienteUc(string usuarioOracle,string passOracle,string tnsOracle)
        {
            _usuarioOracle = usuarioOracle;
            _passOracle = passOracle;
            _tnsOracle = tnsOracle;  
            InitializeComponent();
            capaNegocios = new clases.bussinesLayer(_usuarioOracle, _passOracle, _tnsOracle);
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string _mensaje =
            capaNegocios.spABMpacientes(1, 1, txtDocumento.Text.Trim(), dtpFechaNacimiento.DateTime, txtNombrePaciente.Text.Trim(), txtApellido.Text.Trim(), txtTelefono.Text.Trim(), txtDireccion.Text.Trim(), 1);
        }
    }
}
