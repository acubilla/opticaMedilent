using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace opticaMedilent
{
    public partial class MenuPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public string _usuarioOracle = string.Empty;
        public string _tnsOracle = string.Empty;
        public string _passOracle = string.Empty;
        public MenuPrincipal(string usuarioOracle, string passOracle, string tnsOracle)
        {
           InitializeComponent();
          clases.bussinesLayer capaNegocios = new clases.bussinesLayer(usuarioOracle, passOracle, tnsOracle);
            //Asignamos Los Valores que utilizaremos para conectarnos
            _usuarioOracle = usuarioOracle;
            _passOracle = passOracle;
            _tnsOracle = tnsOracle;
        }
        /// <summary>
        /// Evento que llama al control de Alta de Pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            controles.altaPacienteUc altaPaciente = new controles.altaPacienteUc(_usuarioOracle,_passOracle,_tnsOracle);
            panel1.Controls.Add(altaPaciente);
            altaPaciente.Dock = DockStyle.Fill;
        }

    }
 }
