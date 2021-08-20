using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CaseFileRequester.Entities;

namespace CaseFileRequester.Logic
{
    public partial class frmConfigs : Form
    {
        private List<Lawer> lstLawers = new List<Lawer>();
        private Lawer lawerToEdit = null;
        public bool Saved { get; set; }

        public frmConfigs()
        {
            InitializeComponent();
        }

        #region Events

        private void frmConfigs_Load(object sender, EventArgs e)
        {
            try
            {
                // create a new list of lawers in case that was not created before
                if (!Logic.Validators.ValidateUserSettings())
                    this.lstLawers = new List<Lawer>();
                else
                    this.lstLawers = CaseFileRequester.Logic.Properties.Settings.Default.Lawers?.LstLawers;

                // Refresh list view
                this.RefreshListView();

                // Set stored login values to the specified controls
                this.txtMain_Site.Text = CaseFileRequester.Logic.Properties.Settings.Default.Main_Site;
                this.txtMain_Login.Text = CaseFileRequester.Logic.Properties.Settings.Default.Main_Login;
                this.txtLogin_User.Text = CaseFileRequester.Logic.Properties.Settings.Default.Login_User;
                this.txtLogin_Pass.Text = CaseFileRequester.Logic.Properties.Settings.Default.Login_Pass;
                this.txtLogin_Submit.Text = CaseFileRequester.Logic.Properties.Settings.Default.Login_Submit;
                this.txtLogin_Logout.Text = CaseFileRequester.Logic.Properties.Settings.Default.Login_Logout;

                // Set stored query values to the specified controls
                this.txtQuery_Site.Text = CaseFileRequester.Logic.Properties.Settings.Default.Query_Site;
                this.txtQuery_Camera.Text = CaseFileRequester.Logic.Properties.Settings.Default.Query_Camera;
                this.txtQuery_File.Text = CaseFileRequester.Logic.Properties.Settings.Default.Query_File;
                this.txtQuery_Year.Text = CaseFileRequester.Logic.Properties.Settings.Default.Query_Year;
                this.txtQuery_RelatedFiles.Text = CaseFileRequester.Logic.Properties.Settings.Default.Query_RelatedFiles;
                this.txtQuery_Submit.Text = CaseFileRequester.Logic.Properties.Settings.Default.Query_Submit;
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input data
                this.ValidateUserInput();

                // create user object
                Lawer lawerToAdd = new Lawer() {
                    Name = this.txtName.Text,
                    Address = this.txtAddress.Text,
                    Cuit = this.txtCuit.Text,
                    Password = this.txtPassword.Text,
                    DefaultUser = this.chkDefaultUser.Checked
                };

                // Validate if any other user is setted as default
                this.SetDefaultUser(lawerToAdd.DefaultUser);

                // add user input data to the list
                lstLawers.Add(lawerToAdd);

                // Add user input data to the list view
                this.RefreshListView();

                // clean form
                this.CleanForm();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if ((this.lstViewUsers.SelectedItems.Count == 0) || this.lstViewUsers.SelectedItems[0] == null)
                    throw new WarningException("Por favor, seleccione un abogado a eliminar.");

                string sName = this.lstViewUsers.SelectedItems[0].SubItems[0].Text;
                string sAddress = this.lstViewUsers.SelectedItems[0].SubItems[1].Text;
                string sCuit = this.lstViewUsers.SelectedItems[0].SubItems[2].Text;

                Lawer lawerToDelete = this.lstLawers.Where(x => x.Name == sName && x.Address == sAddress && x.Cuit == sCuit).FirstOrDefault();

                if (lawerToDelete == null)
                    throw new ApplicationException("Hubo un error para identificar el abogado a eliminar.");

                this.lstLawers.Remove(lawerToDelete);
                this.RefreshListView();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lstViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lstViewUsers.SelectedItems.Count == 0)
                    return;

                string sName = this.lstViewUsers.SelectedItems[0].SubItems[0].Text;
                string sAddress = this.lstViewUsers.SelectedItems[0].SubItems[1].Text;
                string sCuit = this.lstViewUsers.SelectedItems[0].SubItems[2].Text;

                this.lawerToEdit = this.lstLawers.Where(x => x.Name == sName && x.Address == sAddress && x.Cuit == sCuit).FirstOrDefault();

                if (this.lawerToEdit == null)
                    MessageBox.Show("Hubo un error para identificar el abogado a editar.");

                this.txtName.Text = this.lawerToEdit.Name;
                this.txtAddress.Text = this.lawerToEdit.Address;
                this.txtCuit.Text = this.lawerToEdit.Cuit;
                this.txtPassword.Text = this.lawerToEdit.Password;
                this.chkDefaultUser.Checked = this.lawerToEdit.DefaultUser;
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCloseConfig_Click(object sender, EventArgs e)
        {
            try
            {
                this.Saved = false;
                this.Dispose();
                this.Close();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lawerToEdit == null)
                    return;

                // Validate user input data
                this.ValidateUserInput();

                // set new user data to the selected user
                this.lawerToEdit.Name = this.txtName.Text;
                this.lawerToEdit.Address = this.txtAddress.Text;
                this.lawerToEdit.Cuit = this.txtCuit.Text;
                this.lawerToEdit.Password = this.txtPassword.Text;

                // Validate if any other lawer is setted as default
                if(this.chkDefaultUser.Checked)
                    this.SetDefaultUser(this.chkDefaultUser.Checked);
                this.lawerToEdit.DefaultUser = this.chkDefaultUser.Checked;

                // restore to null lawerToEdit object
                this.lawerToEdit = null;

                // refresh list view
                this.RefreshListView();

                // clean form
                this.CleanForm();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                // Save lawers data
                Lawers lawers = new Lawers();
                lawers.LstLawers = this.lstLawers;
                Properties.Settings.Default.Lawers = lawers;

                // Save login site conf data
                Properties.Settings.Default.Main_Site = this.txtMain_Site.Text;
                Properties.Settings.Default.Login_User = this.txtLogin_User.Text;
                Properties.Settings.Default.Login_Pass = this.txtLogin_Pass.Text;
                Properties.Settings.Default.Main_Login = this.txtMain_Login.Text;
                Properties.Settings.Default.Login_Submit = this.txtLogin_Submit.Text;
                Properties.Settings.Default.Login_Logout = this.txtLogin_Logout.Text;

                // Save query site conf data
                Properties.Settings.Default.Query_Site = this.txtQuery_Site.Text.Trim();
                Properties.Settings.Default.Query_Camera = this.txtQuery_Camera.Text.Trim();
                Properties.Settings.Default.Query_File = this.txtQuery_File.Text.Trim();
                Properties.Settings.Default.Query_Year = this.txtQuery_Year.Text.Trim();
                Properties.Settings.Default.Query_RelatedFiles = this.txtQuery_RelatedFiles.Text.Trim();
                Properties.Settings.Default.Query_Submit = this.txtQuery_Submit.Text.Trim();

                // Save data
                Properties.Settings.Default.Save();

                MessageBox.Show("Los cambios fueron guardados satisfactoriamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Saved = true;
                this.Dispose();
                this.Close();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Methods

        private void ValidateUserInput()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtName.Text.Trim()) || this.txtName.Text.Trim().Length < 4)
                    throw new WarningException("Por favor, ingrese un nombre de usuario válido.");

                if (string.IsNullOrEmpty(this.txtAddress.Text.Trim()) || this.txtAddress.Text.Trim().Length < 4)
                    throw new WarningException("Por favor, ingrese un apellido válido.");

                if (string.IsNullOrEmpty(this.txtCuit.Text.Replace("-", "").Trim()) || this.txtCuit.Text.Replace("-", "").Trim().Length != 11)
                    throw new WarningException("Por favor, ingrese un CUIT válido.");

                if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()) || this.txtPassword.Text.Trim().Length < 4)
                    throw new WarningException("Por favor, ingrese una contraseña válida.");
            }
            catch (Exception ex) { throw ex; }
        }

        private void CleanForm()
        {
            try
            {
                this.txtName.Text = this.txtAddress.Text = this.txtCuit.Text = this.txtPassword.Text = string.Empty;
                this.chkDefaultUser.Checked = false;
                this.txtName.Focus();
            }
            catch (Exception ex) { throw ex; }
        }

        private void RefreshListView()
        {
            try
            {
                // clear list items
                this.lstViewUsers.Items.Clear();

                // reload items
                foreach (Lawer item in this.lstLawers)
                    this.lstViewUsers.Items.Add(new ListViewItem(new string[] { item.Name, item.Address, item.Cuit, item.DefaultUser ? "Si" : "No" }));
            }
            catch (Exception ex) { throw ex; }
        }

        private void SetDefaultUser(bool setAsDefault)
        {
            try
            {
                if(setAsDefault)
                    CaseFileRequester.Logic.Properties.Settings.Default.Lawers?.LstLawers?.All(x => { x.DefaultUser = false; return true; });
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion
    }
}
