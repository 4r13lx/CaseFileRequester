namespace CaseFileRequester.Logic
{
    partial class frmAddFiles
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
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFiles
            // 
            this.txtFiles.Location = new System.Drawing.Point(13, 53);
            this.txtFiles.Multiline = true;
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(411, 402);
            this.txtFiles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los expedientes uno debajo del otro. Recuerde respetar el formato Expedie" +
    "nte/Año (Ejemplo: 36671/2011).";
            // 
            // btnOk
            // 
            this.btnOk.Image = global::CaseFileRequester.Logic.Properties.Resources.accept;
            this.btnOk.Location = new System.Drawing.Point(154, 463);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(129, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Aceptar";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmAddFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 493);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiles);
            this.Name = "frmAddFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Expedientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}