using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseFileRequester.Logic
{
    public partial class frmAddFiles : Form
    {
        public Dictionary<string, string> Files { get; set; }

        public frmAddFiles()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Files = new Dictionary<string, string>();

                if (!string.IsNullOrEmpty(this.txtFiles.Text.Trim()))
                {
                    StringBuilder sbErrors = new StringBuilder();

                    string[] arFiles = this.txtFiles.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string file in arFiles)
                    {
                        string[] sFile = file.Split(new char[] { '/' });

                        if (sFile.Length < 2)
                        {
                            sbErrors.AppendLine(string.Format("El expediente '{0}' no se encuentra en el formato correcto!", sFile[0]));
                        }
                        else
                        {
                            if (!this.Files.ContainsKey(sFile[0]))
                                this.Files.Add(sFile[0], sFile[1]);
                        }
                    }

                    if (sbErrors.ToString() != string.Empty)
                    {
                        MessageBox.Show(string.Format("Ha ocurrido un error: \n\n" + "{0}", sbErrors.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                this.Close();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
