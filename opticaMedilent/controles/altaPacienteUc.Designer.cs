namespace opticaMedilent.controles
{
    partial class altaPacienteUc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altaPacienteUc));
            this.groupOpcionesPaciente = new DevExpress.XtraEditors.GroupControl();
            this.deletePacienteButton = new DevExpress.XtraEditors.SimpleButton();
            this.updatePacienteButton = new DevExpress.XtraEditors.SimpleButton();
            this.insertPacienteButton = new DevExpress.XtraEditors.SimpleButton();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.lbDireccion = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.lbNroTelefono = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.lbDocumento = new DevExpress.XtraEditors.LabelControl();
            this.txtDocumento = new DevExpress.XtraEditors.TextEdit();
            this.lbApellidoPaciente = new DevExpress.XtraEditors.LabelControl();
            this.txtApellido = new DevExpress.XtraEditors.TextEdit();
            this.lbNombrePaciente = new DevExpress.XtraEditors.LabelControl();
            this.txtNombrePaciente = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupOpcionesPaciente)).BeginInit();
            this.groupOpcionesPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombrePaciente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupOpcionesPaciente
            // 
            this.groupOpcionesPaciente.Controls.Add(this.deletePacienteButton);
            this.groupOpcionesPaciente.Controls.Add(this.updatePacienteButton);
            this.groupOpcionesPaciente.Controls.Add(this.insertPacienteButton);
            this.groupOpcionesPaciente.Location = new System.Drawing.Point(95, 64);
            this.groupOpcionesPaciente.LookAndFeel.SkinName = "Office 2007 Blue";
            this.groupOpcionesPaciente.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupOpcionesPaciente.Name = "groupOpcionesPaciente";
            this.groupOpcionesPaciente.Size = new System.Drawing.Size(499, 111);
            this.groupOpcionesPaciente.TabIndex = 27;
            this.groupOpcionesPaciente.Text = "Que Desea Hacer?";
            // 
            // deletePacienteButton
            // 
            this.deletePacienteButton.Image = ((System.Drawing.Image)(resources.GetObject("deletePacienteButton.Image")));
            this.deletePacienteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.deletePacienteButton.Location = new System.Drawing.Point(389, 27);
            this.deletePacienteButton.LookAndFeel.SkinName = "Office 2007 Blue";
            this.deletePacienteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.deletePacienteButton.Name = "deletePacienteButton";
            this.deletePacienteButton.Size = new System.Drawing.Size(73, 69);
            this.deletePacienteButton.TabIndex = 15;
            this.deletePacienteButton.ToolTip = "Eliminar Paciente";
            this.deletePacienteButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Error;
            // 
            // updatePacienteButton
            // 
            this.updatePacienteButton.Image = ((System.Drawing.Image)(resources.GetObject("updatePacienteButton.Image")));
            this.updatePacienteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.updatePacienteButton.Location = new System.Drawing.Point(204, 27);
            this.updatePacienteButton.LookAndFeel.SkinName = "Office 2007 Blue";
            this.updatePacienteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.updatePacienteButton.Name = "updatePacienteButton";
            this.updatePacienteButton.Size = new System.Drawing.Size(73, 69);
            this.updatePacienteButton.TabIndex = 14;
            this.updatePacienteButton.ToolTip = "Editar Datos del Paciente";
            this.updatePacienteButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // insertPacienteButton
            // 
            this.insertPacienteButton.Image = ((System.Drawing.Image)(resources.GetObject("insertPacienteButton.Image")));
            this.insertPacienteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.insertPacienteButton.Location = new System.Drawing.Point(18, 27);
            this.insertPacienteButton.Name = "insertPacienteButton";
            this.insertPacienteButton.Size = new System.Drawing.Size(73, 69);
            this.insertPacienteButton.TabIndex = 13;
            this.insertPacienteButton.ToolTip = "Crear Nuevo Paciente";
            this.insertPacienteButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(190, 364);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Properties.AutoHeight = false;
            this.txtDireccion.Properties.MaxLength = 150;
            this.txtDireccion.Size = new System.Drawing.Size(355, 20);
            this.txtDireccion.TabIndex = 26;
            // 
            // lbDireccion
            // 
            this.lbDireccion.Location = new System.Drawing.Point(79, 370);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(57, 13);
            this.lbDireccion.TabIndex = 25;
            this.lbDireccion.Text = "DIRECCION";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(190, 330);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.AutoHeight = false;
            this.txtTelefono.Properties.MaxLength = 100;
            this.txtTelefono.Size = new System.Drawing.Size(355, 20);
            this.txtTelefono.TabIndex = 24;
            // 
            // lbNroTelefono
            // 
            this.lbNroTelefono.Location = new System.Drawing.Point(79, 335);
            this.lbNroTelefono.Name = "lbNroTelefono";
            this.lbNroTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbNroTelefono.TabIndex = 23;
            this.lbNroTelefono.Text = "TELEFONO";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 302);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "FECHA NACIMIENTO";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.EditValue = null;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(190, 298);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Properties.AutoHeight = false;
            this.dtpFechaNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaNacimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(355, 20);
            this.dtpFechaNacimiento.TabIndex = 21;
            // 
            // lbDocumento
            // 
            this.lbDocumento.Location = new System.Drawing.Point(78, 267);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(64, 13);
            this.lbDocumento.TabIndex = 19;
            this.lbDocumento.Text = "DOCUMENTO";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(190, 264);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Properties.AutoHeight = false;
            this.txtDocumento.Properties.MaxLength = 30;
            this.txtDocumento.Size = new System.Drawing.Size(355, 20);
            this.txtDocumento.TabIndex = 20;
            // 
            // lbApellidoPaciente
            // 
            this.lbApellidoPaciente.Location = new System.Drawing.Point(78, 228);
            this.lbApellidoPaciente.Name = "lbApellidoPaciente";
            this.lbApellidoPaciente.Size = new System.Drawing.Size(48, 13);
            this.lbApellidoPaciente.TabIndex = 17;
            this.lbApellidoPaciente.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(190, 226);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Properties.AutoHeight = false;
            this.txtApellido.Properties.MaxLength = 100;
            this.txtApellido.Size = new System.Drawing.Size(355, 20);
            this.txtApellido.TabIndex = 18;
            // 
            // lbNombrePaciente
            // 
            this.lbNombrePaciente.Location = new System.Drawing.Point(78, 191);
            this.lbNombrePaciente.Name = "lbNombrePaciente";
            this.lbNombrePaciente.Size = new System.Drawing.Size(42, 13);
            this.lbNombrePaciente.TabIndex = 15;
            this.lbNombrePaciente.Text = "NOMBRE";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(190, 190);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Properties.AutoHeight = false;
            this.txtNombrePaciente.Properties.MaxLength = 100;
            this.txtNombrePaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombrePaciente.Size = new System.Drawing.Size(355, 20);
            this.txtNombrePaciente.TabIndex = 16;
            // 
            // altaPacienteUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupOpcionesPaciente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbNroTelefono);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lbDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lbApellidoPaciente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lbNombrePaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "altaPacienteUc";
            this.Size = new System.Drawing.Size(672, 449);
            this.Load += new System.EventHandler(this.altaPacienteUc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupOpcionesPaciente)).EndInit();
            this.groupOpcionesPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombrePaciente.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton deletePacienteButton;
        private DevExpress.XtraEditors.SimpleButton updatePacienteButton;
        private DevExpress.XtraEditors.SimpleButton insertPacienteButton;
        public DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.LabelControl lbDireccion;
        public DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.LabelControl lbNroTelefono;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit dtpFechaNacimiento;
        private DevExpress.XtraEditors.LabelControl lbDocumento;
        public DevExpress.XtraEditors.TextEdit txtDocumento;
        private DevExpress.XtraEditors.LabelControl lbApellidoPaciente;
        public DevExpress.XtraEditors.TextEdit txtApellido;
        private DevExpress.XtraEditors.LabelControl lbNombrePaciente;
        public DevExpress.XtraEditors.TextEdit txtNombrePaciente;
        public DevExpress.XtraEditors.GroupControl groupOpcionesPaciente;
    }
}
