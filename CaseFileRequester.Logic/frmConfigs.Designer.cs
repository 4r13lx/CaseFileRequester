namespace CaseFileRequester.Logic
{
    partial class frmConfigs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigs));
            this.tabLawers = new System.Windows.Forms.TabPage();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chkDefaultUser = new System.Windows.Forms.CheckBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstViewUsers = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCuit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDefaultUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabWebSite = new System.Windows.Forms.TabPage();
            this.tabWebSiteConf = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMain_Login = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMain_Site = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogin_Logout = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLogin_Submit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogin_Pass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogin_User = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuery_RelatedFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuery_Submit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuery_Year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuery_File = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuery_Camera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuery_Site = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnCloseConfig = new System.Windows.Forms.Button();
            this.tabLawers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabWebSite.SuspendLayout();
            this.tabWebSiteConf.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLawers
            // 
            this.tabLawers.Controls.Add(this.btnModificar);
            this.tabLawers.Controls.Add(this.chkDefaultUser);
            this.tabLawers.Controls.Add(this.btnDeleteFile);
            this.tabLawers.Controls.Add(this.btnAddUser);
            this.tabLawers.Controls.Add(this.txtCuit);
            this.tabLawers.Controls.Add(this.txtPassword);
            this.tabLawers.Controls.Add(this.lblPassword);
            this.tabLawers.Controls.Add(this.lblCuit);
            this.tabLawers.Controls.Add(this.txtAddress);
            this.tabLawers.Controls.Add(this.lblAddress);
            this.tabLawers.Controls.Add(this.groupBox1);
            this.tabLawers.Controls.Add(this.txtName);
            this.tabLawers.Controls.Add(this.lblName);
            this.tabLawers.Location = new System.Drawing.Point(4, 22);
            this.tabLawers.Name = "tabLawers";
            this.tabLawers.Padding = new System.Windows.Forms.Padding(3);
            this.tabLawers.Size = new System.Drawing.Size(608, 371);
            this.tabLawers.TabIndex = 2;
            this.tabLawers.Text = "Usuarios";
            this.tabLawers.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::CaseFileRequester.Logic.Properties.Resources.edit;
            this.btnModificar.Location = new System.Drawing.Point(94, 332);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(77, 28);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chkDefaultUser
            // 
            this.chkDefaultUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDefaultUser.AutoSize = true;
            this.chkDefaultUser.Location = new System.Drawing.Point(9, 211);
            this.chkDefaultUser.Name = "chkDefaultUser";
            this.chkDefaultUser.Size = new System.Drawing.Size(183, 17);
            this.chkDefaultUser.TabIndex = 17;
            this.chkDefaultUser.Text = "Utilizar como usuario por defecto.";
            this.chkDefaultUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Image = global::CaseFileRequester.Logic.Properties.Resources.delete;
            this.btnDeleteFile.Location = new System.Drawing.Point(177, 332);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(77, 28);
            this.btnDeleteFile.TabIndex = 6;
            this.btnDeleteFile.Text = "Eliminar";
            this.btnDeleteFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::CaseFileRequester.Logic.Properties.Resources.add_16x161;
            this.btnAddUser.Location = new System.Drawing.Point(9, 332);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(78, 28);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(9, 126);
            this.txtCuit.Mask = "00-00000000-0";
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(245, 20);
            this.txtCuit.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(245, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 158);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(6, 110);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 14;
            this.lblCuit.Text = "CUIT";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(9, 77);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 61);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(44, 13);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Apellido";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstViewUsers);
            this.groupBox1.Location = new System.Drawing.Point(260, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 350);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios existentes";
            // 
            // lstViewUsers
            // 
            this.lstViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colAddress,
            this.colCuit,
            this.colDefaultUser});
            this.lstViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewUsers.Location = new System.Drawing.Point(3, 16);
            this.lstViewUsers.Name = "lstViewUsers";
            this.lstViewUsers.Size = new System.Drawing.Size(336, 331);
            this.lstViewUsers.TabIndex = 8;
            this.lstViewUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewUsers.View = System.Windows.Forms.View.Details;
            this.lstViewUsers.SelectedIndexChanged += new System.EventHandler(this.lstViewUsers_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            this.colName.Width = 90;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Apellido";
            this.colAddress.Width = 90;
            // 
            // colCuit
            // 
            this.colCuit.Text = "CUIT";
            this.colCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCuit.Width = 90;
            // 
            // colDefaultUser
            // 
            this.colDefaultUser.Text = "Activo";
            this.colDefaultUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // tabWebSite
            // 
            this.tabWebSite.Controls.Add(this.tabWebSiteConf);
            this.tabWebSite.Location = new System.Drawing.Point(4, 22);
            this.tabWebSite.Name = "tabWebSite";
            this.tabWebSite.Padding = new System.Windows.Forms.Padding(3);
            this.tabWebSite.Size = new System.Drawing.Size(608, 371);
            this.tabWebSite.TabIndex = 0;
            this.tabWebSite.Text = "Sitio Web";
            this.tabWebSite.UseVisualStyleBackColor = true;
            // 
            // tabWebSiteConf
            // 
            this.tabWebSiteConf.Controls.Add(this.tabMain);
            this.tabWebSiteConf.Controls.Add(this.tabLogin);
            this.tabWebSiteConf.Controls.Add(this.tabQuery);
            this.tabWebSiteConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWebSiteConf.Location = new System.Drawing.Point(3, 3);
            this.tabWebSiteConf.Name = "tabWebSiteConf";
            this.tabWebSiteConf.SelectedIndex = 0;
            this.tabWebSiteConf.Size = new System.Drawing.Size(602, 365);
            this.tabWebSiteConf.TabIndex = 4;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.groupBox4);
            this.tabMain.Controls.Add(this.txtMain_Site);
            this.tabMain.Controls.Add(this.label7);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(594, 339);
            this.tabMain.TabIndex = 3;
            this.tabMain.Text = "Principal";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtMain_Login);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(8, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 282);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controles del sitio";
            // 
            // txtMain_Login
            // 
            this.txtMain_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain_Login.Location = new System.Drawing.Point(9, 44);
            this.txtMain_Login.Name = "txtMain_Login";
            this.txtMain_Login.Size = new System.Drawing.Size(564, 20);
            this.txtMain_Login.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Iniciar Sesión";
            // 
            // txtMain_Site
            // 
            this.txtMain_Site.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain_Site.Location = new System.Drawing.Point(9, 25);
            this.txtMain_Site.Name = "txtMain_Site";
            this.txtMain_Site.Size = new System.Drawing.Size(579, 20);
            this.txtMain_Site.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sitio";
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.groupBox3);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(594, 339);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtLogin_Logout);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtLogin_Submit);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtLogin_Pass);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtLogin_User);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(9, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 327);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles del sitio";
            // 
            // txtLogin_Logout
            // 
            this.txtLogin_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin_Logout.Location = new System.Drawing.Point(9, 173);
            this.txtLogin_Logout.Name = "txtLogin_Logout";
            this.txtLogin_Logout.Size = new System.Drawing.Size(564, 20);
            this.txtLogin_Logout.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cerrar sesión";
            // 
            // txtLogin_Submit
            // 
            this.txtLogin_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin_Submit.Location = new System.Drawing.Point(9, 129);
            this.txtLogin_Submit.Name = "txtLogin_Submit";
            this.txtLogin_Submit.Size = new System.Drawing.Size(564, 20);
            this.txtLogin_Submit.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ingresar";
            // 
            // txtLogin_Pass
            // 
            this.txtLogin_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin_Pass.Location = new System.Drawing.Point(9, 86);
            this.txtLogin_Pass.Name = "txtLogin_Pass";
            this.txtLogin_Pass.Size = new System.Drawing.Size(564, 20);
            this.txtLogin_Pass.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Contraseña";
            // 
            // txtLogin_User
            // 
            this.txtLogin_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin_User.Location = new System.Drawing.Point(9, 43);
            this.txtLogin_User.Name = "txtLogin_User";
            this.txtLogin_User.Size = new System.Drawing.Size(564, 20);
            this.txtLogin_User.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Usuario";
            // 
            // tabQuery
            // 
            this.tabQuery.Controls.Add(this.groupBox2);
            this.tabQuery.Controls.Add(this.txtQuery_Site);
            this.tabQuery.Controls.Add(this.label6);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(594, 339);
            this.tabQuery.TabIndex = 2;
            this.tabQuery.Text = "Consulta";
            this.tabQuery.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtQuery_RelatedFiles);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtQuery_Submit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtQuery_Year);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtQuery_File);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtQuery_Camera);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 278);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles del sitio";
            // 
            // txtQuery_RelatedFiles
            // 
            this.txtQuery_RelatedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery_RelatedFiles.Location = new System.Drawing.Point(9, 173);
            this.txtQuery_RelatedFiles.Name = "txtQuery_RelatedFiles";
            this.txtQuery_RelatedFiles.Size = new System.Drawing.Size(564, 20);
            this.txtQuery_RelatedFiles.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Expedientes relacionados";
            // 
            // txtQuery_Submit
            // 
            this.txtQuery_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery_Submit.Location = new System.Drawing.Point(9, 216);
            this.txtQuery_Submit.Name = "txtQuery_Submit";
            this.txtQuery_Submit.Size = new System.Drawing.Size(564, 20);
            this.txtQuery_Submit.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Consultar";
            // 
            // txtQuery_Year
            // 
            this.txtQuery_Year.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery_Year.Location = new System.Drawing.Point(9, 130);
            this.txtQuery_Year.Name = "txtQuery_Year";
            this.txtQuery_Year.Size = new System.Drawing.Size(564, 20);
            this.txtQuery_Year.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Año";
            // 
            // txtQuery_File
            // 
            this.txtQuery_File.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery_File.Location = new System.Drawing.Point(9, 87);
            this.txtQuery_File.Name = "txtQuery_File";
            this.txtQuery_File.Size = new System.Drawing.Size(564, 20);
            this.txtQuery_File.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Expediente";
            // 
            // txtQuery_Camera
            // 
            this.txtQuery_Camera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery_Camera.Location = new System.Drawing.Point(9, 44);
            this.txtQuery_Camera.Name = "txtQuery_Camera";
            this.txtQuery_Camera.Size = new System.Drawing.Size(564, 20);
            this.txtQuery_Camera.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Camara";
            // 
            // txtQuery_Site
            // 
            this.txtQuery_Site.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery_Site.Location = new System.Drawing.Point(9, 29);
            this.txtQuery_Site.Name = "txtQuery_Site";
            this.txtQuery_Site.Size = new System.Drawing.Size(579, 20);
            this.txtQuery_Site.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sitio";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabLawers);
            this.tabControl.Controls.Add(this.tabWebSite);
            this.tabControl.Location = new System.Drawing.Point(-1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(616, 397);
            this.tabControl.TabIndex = 3;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Image = global::CaseFileRequester.Logic.Properties.Resources.gtk_save;
            this.btnSaveConfig.Location = new System.Drawing.Point(490, 403);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(122, 28);
            this.btnSaveConfig.TabIndex = 13;
            this.btnSaveConfig.Text = "Guardar";
            this.btnSaveConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnCloseConfig
            // 
            this.btnCloseConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseConfig.Image = global::CaseFileRequester.Logic.Properties.Resources.block;
            this.btnCloseConfig.Location = new System.Drawing.Point(353, 403);
            this.btnCloseConfig.Name = "btnCloseConfig";
            this.btnCloseConfig.Size = new System.Drawing.Size(122, 28);
            this.btnCloseConfig.TabIndex = 12;
            this.btnCloseConfig.Text = "Descartar";
            this.btnCloseConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseConfig.UseVisualStyleBackColor = true;
            this.btnCloseConfig.Click += new System.EventHandler(this.btnCloseConfig_Click);
            // 
            // frmConfigs
            // 
            this.AcceptButton = this.btnSaveConfig;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseConfig;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnCloseConfig);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(643, 477);
            this.Name = "frmConfigs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmConfigs_Load);
            this.tabLawers.ResumeLayout(false);
            this.tabLawers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabWebSite.ResumeLayout(false);
            this.tabWebSiteConf.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabLogin.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabLawers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabWebSite;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabControl tabWebSiteConf;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLogin_Submit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogin_Pass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogin_User;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuery_RelatedFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuery_Submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuery_Year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuery_File;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuery_Camera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuery_Site;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListView lstViewUsers;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colCuit;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnCloseConfig;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.ColumnHeader colDefaultUser;
        private System.Windows.Forms.CheckBox chkDefaultUser;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMain_Login;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMain_Site;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLogin_Logout;
        private System.Windows.Forms.Label label8;
    }
}