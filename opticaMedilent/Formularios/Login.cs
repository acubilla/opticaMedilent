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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Instanciamos La Capa de Negocios
        /// </summary>
        clases.bussinesLayer capaNegocios = new clases.bussinesLayer();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            esProduccion = false;
            if (esProduccion)
            {
                //recupero los parametros recibidos desde el sistema
                clases.sesionUsuario laSesion = (clases.sesionUsuario)this.Tag;
                usuarioOracle = laSesion.usuario;
                passOracle = laSesion.userPassword;
                parametros = laSesion.parametros;
            }
            else
            {
                //aqui podemos colocar los datos para trabajar en un SandBox
                usuarioOracle = "OPTICA";
                passOracle = "12345678";
                parametros = "";

            }
            //aqui se estable la capa de negocios
            capaNegocios = new clases.bussinesLayer(usuarioOracle, passOracle, tnsORacle);
        }

        #region Seteos de Base
        /// <summary>
        /// estable si el form esta en produccion
        /// </summary>
        private bool esProduccion = false;
        /// <summary>
        /// el usuario de oracle que viene de finansys
        /// </summary>
        private string usuarioOracle = "";
        /// <summary>
        /// el password de oracle
        /// </summary>
        private string passOracle = "";
        /// <summary>
        /// los parametro recibidos desde finansys
        /// </summary>
        private string parametros = "";
        /// <summary>
        /// determina si se puede cerrar el formulario
        /// </summary>
        public bool sePuedeCerrar = false;
        /// <summary>
        /// el nombre de la aplicacion
        /// </summary>
        public string nombreAplicacion = "OPTICA MEDILENT";
        /// <summary>
        /// tns de oracle
        /// </summary>
        private string tnsORacle = "XE";


        #endregion

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Si el Campo Usuario es Distinto de Vacio
            if(txtUser.Text!=string.Empty)
            {
                //Si el Campo Password es Distinto de Vacio
                if(txtPassword.Text!=string.Empty)
                {  //DataSet que Retorna los Datos del Usuario
                    DataSet dsTest = new DataSet();
                    //Instancia de la Clase Usuario
                    clases.Usuario usuario = new clases.Usuario();
                    //Obtenemos el Valor del UserName
                    usuario.getSetUserKey = txtUser.Text.ToUpper();
                    //Obtenemo el Valor del PassWord
                    usuario.getSetUserPassword = txtPassword.Text.ToUpper();
                    //Obtemos los Datos del Usuario
                    dsTest =capaNegocios.datosUsuario(usuario.getSetUserKey, usuario.getSetUserPassword);
                    if (dsTest.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow data in dsTest.Tables[0].Rows)
                        {
                            if (data["USER_KEY"].ToString().Trim() == usuario.getSetUserKey && data["USER_PASSWORD"].ToString().Trim() == usuario.getSetUserPassword)
                            {
                                XtraMessageBox.Show(string.Format("Es Bueno volver a Verte {0} {1}", data["USER_NAME"].ToString().Trim(), data["USER_LAST_NAME"].ToString().Trim()), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                MenuPrincipal abc = new MenuPrincipal(usuarioOracle,passOracle,tnsORacle);
                                abc.ShowDialog();
                                this.Close();
                                
                            }
                            else
                            {
                                XtraMessageBox.Show("USUARIO o PASSWORD incorrectos, Favor Verifiquelos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("El USUARIO o PASSWORD ingresados son invalidos, favor verifiquelos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Text = string.Empty;
                        txtUser.Text = string.Empty;
                    }
                }
                else
                {
                    XtraMessageBox.Show("El Campo PASSWORD no puede quedar vacio, Favor Introduzcalo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Hacemos Referencia al Campo
                    txtPassword.Focus();
                }
            }
            else
            {
                XtraMessageBox.Show("El Campo USUARIO no puede quedar vacio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Hacemos Referencia al Campo
                txtUser.Focus();
            }
        }
        /// <summary>
        /// Ocurre cuando el checkBoxVer es Presionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chckVer_CheckStateChanged(object sender, EventArgs e)
        {
            //Si esta checkeado
            if(chckVer.Checked.Equals(true))
            {//Mostramos el password
                txtPassword.Properties.PasswordChar = '\0';
            }
            else
            {//sino no lo esta, lo ocultamos de nuevo
                txtPassword.Properties.PasswordChar = '*';
            }

        }
    }
}
