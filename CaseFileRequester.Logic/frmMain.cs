using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using CaseFileRequester.Entities;

namespace CaseFileRequester.Logic
{
    public partial class frmMain : Form
    {
        private enum Operator { SUM, REST, NONE }
        private enum eAction { NONE, MAIN_PAGE, LOAD_LOGIN_PAGE, DO_LOGIN, DO_REQUEST, DO_LOGOUT, NEW_SEARCH, EXIT }
        Operator eOperator;
        private eAction Action { get; set; }
        private Lawer OcasionalUser { get; set; }

        public frmMain()
        {
            try
            {
                InitializeComponent();

                // Config Gecko browser
                // Uncomment in Test
                //string appDirectory = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"));
                //Gecko.Xpcom.Initialize(Path.Combine(appDirectory, "FireFox"));
                // Uncomment in Prod
                Gecko.Xpcom.Initialize("FireFox");
                Gecko.GeckoPreferences.Default["extensions.blocklist.enabled"] = false;
                Gecko.GeckoPreferences.Default["pdfjs.disabled"] = true;

                // Load main page
                this.LoadMainPage();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #region Events

        private void Main_Load(object sender, EventArgs e)
        {
            ToolTip oToolTip = new ToolTip();
            oToolTip.SetToolTip(this.btnAddFiles, "Agrega los expedientes para ser consultados por el sistema");
            oToolTip.SetToolTip(this.btnBack, "Consultar el expediente anterior");
            oToolTip.SetToolTip(this.btnNext, "Consultar el siguiente expediente");
            oToolTip.SetToolTip(this.btnDeleteFile, "Elimina el expediente seleccionado en la lista");
            oToolTip.SetToolTip(this.lstFiles, "Doble click sobre un expediente para consultar. Un solo click para seleccionar y poder eliminar.");

            // Show user
            this.ShowUserToLogin();

            // Load users
            this.LoadUsersIntoMenu();
        }

        #region List

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                eOperator = Operator.NONE;
                this.RequestFile();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void UpdateListView()
        {
            try
            {
                if ((this.lstFiles.SelectedItems.Count != 0) && this.lstFiles.SelectedItems[0] != null)
                    this.lstFiles.SelectedItems[0].SubItems[2].Text = "Consultado";
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Buttons

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddFiles fAddFiles = new frmAddFiles();
                fAddFiles.ShowDialog();

                if ((fAddFiles.Files == null) || fAddFiles.Files.Count == 0)
                    return;

                foreach (var files in fAddFiles.Files)
                    lstFiles.Items.Add(new ListViewItem(new string[] { files.Key, files.Value, string.Empty }));

                if (this.lstFiles.Items[0] != null)
                {
                    this.lstFiles.Items[0].Focused = true;
                    this.lstFiles.Items[0].Selected = true;
                    this.lstFiles.SelectedItems[0].Focused = true;
                }

                this.btnBack.Enabled = this.btnNext.Enabled = true;

                // Request the first file
                if (this.lstFiles.Items.Count == 1)
                    this.RequestFileData();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if ((this.lstFiles.SelectedItems.Count != 0) && this.lstFiles.SelectedItems[0] != null)
                {
                    // Get the index of the selected item
                    int newIndex = this.lstFiles.SelectedItems[0].Index - 1;
                    
                    // Remove the selected item
                    this.lstFiles.SelectedItems[0].Remove();

                    // Set as selected the previous item
                    if (newIndex > 0)
                        this.lstFiles.Items[newIndex].Selected = true;
                }
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                eOperator = Operator.SUM;
                this.RequestFile();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                eOperator = Operator.REST;
                this.RequestFile();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region ToolStrip

        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lstFiles.Items.Count != 0)
                    this.lstFiles.Items.Clear();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
                this.Close();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigs oFrmConfigs = null;
            try
            {
                oFrmConfigs = new frmConfigs();
                oFrmConfigs.ShowDialog();
                if (!oFrmConfigs.Saved)
                    return;

                // Reload users menu
                this.LoadUsersIntoMenu();

                // set default user
                this.ShowUserToLogin();

                // reload webbrowser
                this.LoadMainPage();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { oFrmConfigs.Dispose(); }
        }

        #endregion

        #region statusStrip

        private void tsddBtnUsers_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                // Uncheck previous selected user
                foreach (ToolStripMenuItem item in this.tsddbUsers.DropDown.Items)
                    item.Checked = false;

                // Get new selected user
                ToolStripItem tsi = e.ClickedItem;
                this.OcasionalUser = (Lawer)tsi.Tag;
                (tsi as ToolStripMenuItem).Checked = true;

                // Try to login again with the ocasional user
                this.ShowUserToLogin();
                this.LoadMainPage();
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region GeckoFX

        private void wbSite_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            try
            {
                switch (this.Action)
                {
                    case eAction.MAIN_PAGE:
                        this.Action = eAction.NONE;
                        this.LoadLoginPage();
                        break;
                    case eAction.LOAD_LOGIN_PAGE:
                        this.Action = eAction.NONE;
                        this.DoLogin();
                        break;
                    case eAction.DO_LOGIN:
                        this.Action = eAction.NONE;
                        //this.LoadRequestPage();
                        break;
                    case eAction.DO_REQUEST:
                        this.UpdateListView();
                        break;
                    case eAction.NEW_SEARCH:
                        this.Action = eAction.NONE;
                        this.RequestFileData();
                        break;
                    case eAction.DO_LOGOUT:
                        this.Action = eAction.NONE;
                        this.LoadMainPage();
                        break;
                    default:
                        break;
                }
            }
            catch (WarningException rs) { MessageBox.Show(rs.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show("Ha ocurrido un error: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void wbSite_ProgressChanged(object sender, Gecko.GeckoProgressEventArgs e)
        {
            try { this.toolStripProgressBar1.Value = (int)e.CurrentProgress > 100 ? 100 : 0; }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        #endregion

        #region Methods

        // FIRST STEP - Load main page
        private void LoadMainPage()
        {
            try
            {
                // Do logout in case that is logged on
                if (this.DoLogout()) return;

                // Re-Load main page
                this.wbSite.Navigate(CaseFileRequester.Logic.Properties.Settings.Default.Main_Site);
                this.Action = eAction.MAIN_PAGE;
            }
            catch (Exception ex) { throw ex; }
        }

        // SECOND STEP - Load login page
        private void LoadLoginPage()
        {
            try
            {
                // Go to login page
                Gecko.GeckoHtmlElement btnGoToLoginPage = this.FindControl(CaseFileRequester.Logic.Properties.Settings.Default.Main_Login);

                //Gecko.GeckoHtmlElement btnGoToLoginPage = wbSite.Document.GetHtmlElementById(BotTest.Properties.Settings.Default.Main_Login);

                // Validate controls
                Logic.Validators.ValidateControls(btnGoToLoginPage);

                wbSite.Navigate(CaseFileRequester.Logic.Properties.Settings.Default.Query_Site);

                // Login
                //btnGoToLoginPage.Click();
                this.Action = eAction.LOAD_LOGIN_PAGE;
            }
            catch (Exception ex) { throw ex; }
        }

        // THIRD STEP - Logon
        private void DoLogin()
        {
            try
            {
                // Get user to authenticate
                if (!Logic.Validators.ValidateUserSettings())
                    return;

                // Get html controls
                Gecko.GeckoHtmlElement userInput = wbSite.Document.GetHtmlElementById(CaseFileRequester.Logic.Properties.Settings.Default.Login_User);
                Gecko.GeckoHtmlElement passInput = wbSite.Document.GetHtmlElementById(CaseFileRequester.Logic.Properties.Settings.Default.Login_Pass);
                Gecko.GeckoHtmlElement submitInput = wbSite.Document.GetHtmlElementById(CaseFileRequester.Logic.Properties.Settings.Default.Login_Submit);

                // Validate if the controls exists
                Logic.Validators.ValidateControls(userInput, passInput, submitInput);

                // Get default or ocasional user
                CaseFileRequester.Entities.Lawer lawer = null;
                if (OcasionalUser == null || this.OcasionalUser.Name == "Ninguno")
                    lawer = CaseFileRequester.Logic.Properties.Settings.Default.Lawers.LstLawers.Where(x => x.DefaultUser == true).FirstOrDefault();
                else
                    lawer = OcasionalUser;

                if (lawer == null)
                    throw new ApplicationException("No hay ningun usuario seleccionado por default.");

                // Set values to html controls
                (userInput as Gecko.DOM.GeckoInputElement).Value = lawer.Cuit.Replace("-", "");
                (passInput as Gecko.DOM.GeckoInputElement).Value = lawer.Password;

                // Do the login
                submitInput.Click();
                this.Action = eAction.DO_LOGIN;
            }
            catch (Exception ex) { throw ex; }
        }

        // FOURTH STEP - Request file
        private void RequestFileData()
        {
            try
            {
                // Get HTML controls
                Gecko.GeckoHtmlElement numeroInput = this.FindControl(CaseFileRequester.Logic.Properties.Settings.Default.Query_File);
                Gecko.GeckoHtmlElement anioInput = this.FindControl(CaseFileRequester.Logic.Properties.Settings.Default.Query_Year);
                Gecko.GeckoHtmlElement submit = this.FindControl(CaseFileRequester.Logic.Properties.Settings.Default.Query_Submit);

                // Validate controls
                try { Logic.Validators.ValidateControls(numeroInput, anioInput, submit); }
                catch (Exception)
                {
                    this.LoadRequestPage();
                    this.Action = eAction.NEW_SEARCH;
                    return;
                }

                // Set values to html controls
                ListViewItem file = this.lstFiles.SelectedItems[0];
                (numeroInput as Gecko.DOM.GeckoInputElement).Value = file.SubItems[0]?.Text;
                (anioInput as Gecko.DOM.GeckoInputElement).Value = file.SubItems[1]?.Text;

                // Submit
                submit.Click();
                this.Action = eAction.DO_REQUEST;
            }
            catch (Exception ex) { throw ex; }
        }

        private void LoadRequestPage()
        {
            try
            {
                // Go to Query page
                this.wbSite.Navigate(CaseFileRequester.Logic.Properties.Settings.Default.Query_Site);

                Gecko.GeckoHtmlElement newRequest = this.FindControl(CaseFileRequester.Logic.Properties.Settings.Default.Query_RelatedFiles);
                if (newRequest == null) return;
                newRequest.Click();
                this.Action = eAction.NEW_SEARCH;
            }
            catch (Exception) { throw; }
        }

        private bool DoLogout()
        {
            try
            {
                // Go to login page
                Gecko.GeckoHtmlElement btnLogOut = this.FindControl(CaseFileRequester.Logic.Properties.Settings.Default.Login_Logout);
                if (btnLogOut == null) return false;

                //Gecko.GeckoHtmlElement btnLogOut = wbSite.Document.GetHtmlElementById(BotTest.Properties.Settings.Default.Login_Logout);

                // Validate controls
                Logic.Validators.ValidateControls(btnLogOut);

                // Login
                btnLogOut.Click();
                this.Action = eAction.DO_LOGOUT;

                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void RequestFile()
        {
            try
            {
                // Validations
                if (this.lstFiles.SelectedItems.Count == 0) return;

                int currentSelectedIndex = this.lstFiles.SelectedItems[0].Index;
                int newSelectedIndex = eOperator == Operator.SUM ? currentSelectedIndex + 1 :
                                       eOperator == Operator.REST ? currentSelectedIndex - 1 : currentSelectedIndex;

                if (newSelectedIndex >= this.lstFiles.Items.Count || newSelectedIndex < 0)
                    return;

                // Set item as selected
                this.lstFiles.Items[newSelectedIndex].Selected = true;
                this.lstFiles.Items[newSelectedIndex].Focused = true;

                // Request the new item
                this.RequestFileData();
            }
            catch (Exception ex) { throw ex; }
        }

        private void ShowUserToLogin()
        {
            try
            {
                // Validate user
                if (!Logic.Validators.ValidateUserSettings())
                    this.stDefaultUser.Text = "No hay ningun usuario seleccionado para realizar el login.";

                // Show user used to login
                Lawer lawer = null;
                if (this.OcasionalUser == null)
                    lawer = CaseFileRequester.Logic.Properties.Settings.Default.Lawers?.LstLawers?.Where(x => x.DefaultUser == true).FirstOrDefault();
                else
                    lawer = this.OcasionalUser;

                if (lawer == null)
                {
                    this.stDefaultUser.Text = "Usuario para ingresar: No definido";
                    return;
                }

                this.stDefaultUser.Text = string.Format("Usuario para ingresar: {0} | CUIT: {1}", lawer.Name, lawer.Cuit);
            }
            catch (Exception ex) { throw ex; }
        }

        private void LoadUsersIntoMenu()
        {
            try
            {
                if (!Logic.Validators.ValidateUserSettings())
                    return;

                // Clear users from menu
                this.tsddbUsers.DropDown.Items.Clear();

                // Add users to the menu
                foreach (Lawer item in CaseFileRequester.Logic.Properties.Settings.Default.Lawers?.LstLawers)
                {
                    ToolStripMenuItem tsmi = new ToolStripMenuItem($"{item.Name} {item.Address}");
                    tsmi.Checked = item.DefaultUser;
                    tsmi.Text = tsmi.Checked ? $"{tsmi.Text} (Usuario por defecto)" : tsmi.Text;
                    tsmi.ToolTipText = $"CUIT: {item.Cuit}";
                    tsmi.Tag = item;
                    this.tsddbUsers.DropDown.Items.Add(tsmi);
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private Gecko.GeckoHtmlElement FindControl(string controlName)
        {
            try
            {
                if (this.wbSite.Document == null) return null;

                // search links controls
                foreach (Gecko.GeckoHtmlElement item in wbSite.Document.Links)
                {
                    // Add login id to html element - Developer delete it and is required by this app
                    if (item is Gecko.DOM.GeckoAnchorElement && (item as Gecko.DOM.GeckoAnchorElement).Href == "https://portalpjn.pjn.gov.ar/")
                        item.Id = "menuLoginId";

                    if (item.Id.Contains(controlName))
                        return wbSite.Document.GetHtmlElementById(item.Id);
                }

                // search form controls
                foreach (Gecko.DOM.GeckoFormElement form in this.wbSite.Document.Forms)
                    foreach (Gecko.GeckoHtmlElement item in form.Elements)
                        if (item.Id.Contains(controlName))
                            return wbSite.Document.GetHtmlElementById(item.Id);

                return null;
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void sobretoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void wbSite_CreateWindow(object sender, Gecko.GeckoCreateWindowEventArgs e)
        {
            e.InitialWidth = 800;
            e.InitialHeight = 600;
        }
    }
}