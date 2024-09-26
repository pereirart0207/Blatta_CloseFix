namespace closeFixer
{
    partial class MainForm : System.Windows.Forms.Form // Asegúrate de heredar de Form
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) // Utiliza override porque estás sobrescribiendo el método
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing); // Llama al método base Dispose para liberar los recursos
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnClosingSelect = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBoxOLD = new System.Windows.Forms.CheckBox();
            this.buttonSelectClosing = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDelDuplicated = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClosingSelect
            // 
            this.btnClosingSelect.Location = new System.Drawing.Point(12, 12);
            this.btnClosingSelect.Name = "btnClosingSelect";
            this.btnClosingSelect.Size = new System.Drawing.Size(248, 52);
            this.btnClosingSelect.TabIndex = 0;
            this.btnClosingSelect.Text = "Seleccionar Carpeta completa";
            this.btnClosingSelect.UseVisualStyleBackColor = true;
            this.btnClosingSelect.Click += new System.EventHandler(this.BtnClosingSelectClick); // Asocia el evento click
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(13, 219);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(248, 23);
            this.labelStatus.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(13, 193);
            this.progressBar1.MaximumSize = new System.Drawing.Size(248, 23);
            this.progressBar1.MinimumSize = new System.Drawing.Size(248, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // checkBoxOLD
            // 
            this.checkBoxOLD.Location = new System.Drawing.Point(13, 121);
            this.checkBoxOLD.Name = "checkBoxOLD";
            this.checkBoxOLD.Size = new System.Drawing.Size(138, 24);
            this.checkBoxOLD.TabIndex = 3;
            this.checkBoxOLD.Text = "Usar Archivos .OLD";
            this.checkBoxOLD.UseVisualStyleBackColor = true;
            // 
            // buttonSelectClosing
            // 
            this.buttonSelectClosing.Location = new System.Drawing.Point(13, 80);
            this.buttonSelectClosing.Name = "buttonSelectClosing";
            this.buttonSelectClosing.Size = new System.Drawing.Size(247, 23);
            this.buttonSelectClosing.TabIndex = 4;
            this.buttonSelectClosing.Text = "Seleccionar un cierre";
            this.buttonSelectClosing.UseVisualStyleBackColor = true;
            this.buttonSelectClosing.Click += new System.EventHandler(this.ButtonSelectClosingClick); // Evento click del segundo botón
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(189, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "pereirart0207";
            // 
            // checkBoxDelDuplicated
            // 
            this.checkBoxDelDuplicated.Checked = true;
            this.checkBoxDelDuplicated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelDuplicated.Location = new System.Drawing.Point(12, 152);
            this.checkBoxDelDuplicated.Name = "checkBoxDelDuplicated";
            this.checkBoxDelDuplicated.Size = new System.Drawing.Size(248, 24);
            this.checkBoxDelDuplicated.TabIndex = 6;
            this.checkBoxDelDuplicated.Text = "Limpiar datos innecesarios";
            this.checkBoxDelDuplicated.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 246);
            this.Controls.Add(this.checkBoxDelDuplicated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectClosing);
            this.Controls.Add(this.checkBoxOLD);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnClosingSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(288, 285);
            this.MinimumSize = new System.Drawing.Size(288, 285);
            this.Name = "MainForm";
            this.Text = "DiggerTicket";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.CheckBox checkBoxDelDuplicated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSelectClosing;
        private System.Windows.Forms.CheckBox checkBoxOLD;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnClosingSelect;
    }
}
