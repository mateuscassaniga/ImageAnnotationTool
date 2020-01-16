namespace ImageAnnotationTool
{
    partial class FormProjectAdd
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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txbProjectName = new System.Windows.Forms.TextBox();
            this.txbImagesPath = new System.Windows.Forms.TextBox();
            this.lblImagesPath = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblImagesFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(12, 9);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(95, 14);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project name:";
            // 
            // txbProjectName
            // 
            this.txbProjectName.Location = new System.Drawing.Point(15, 26);
            this.txbProjectName.Name = "txbProjectName";
            this.txbProjectName.Size = new System.Drawing.Size(499, 22);
            this.txbProjectName.TabIndex = 1;
            // 
            // txbImagesPath
            // 
            this.txbImagesPath.Location = new System.Drawing.Point(15, 78);
            this.txbImagesPath.Name = "txbImagesPath";
            this.txbImagesPath.Size = new System.Drawing.Size(460, 22);
            this.txbImagesPath.TabIndex = 3;
            this.txbImagesPath.TextChanged += new System.EventHandler(this.txbImagesPath_TextChanged);
            // 
            // lblImagesPath
            // 
            this.lblImagesPath.AutoSize = true;
            this.lblImagesPath.Location = new System.Drawing.Point(12, 61);
            this.lblImagesPath.Name = "lblImagesPath";
            this.lblImagesPath.Size = new System.Drawing.Size(92, 14);
            this.lblImagesPath.TabIndex = 2;
            this.lblImagesPath.Text = "Images path:";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(481, 77);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(33, 24);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(308, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(414, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblImagesFound
            // 
            this.lblImagesFound.AutoSize = true;
            this.lblImagesFound.Location = new System.Drawing.Point(15, 113);
            this.lblImagesFound.Name = "lblImagesFound";
            this.lblImagesFound.Size = new System.Drawing.Size(204, 14);
            this.lblImagesFound.TabIndex = 7;
            this.lblImagesFound.Text = "000 images found in this folder.";
            this.lblImagesFound.Visible = false;
            // 
            // FormProjectAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(529, 222);
            this.Controls.Add(this.lblImagesFound);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txbImagesPath);
            this.Controls.Add(this.lblImagesPath);
            this.Controls.Add(this.txbProjectName);
            this.Controls.Add(this.lblProjectName);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProjectAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects > Add New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txbProjectName;
        private System.Windows.Forms.TextBox txbImagesPath;
        private System.Windows.Forms.Label lblImagesPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblImagesFound;
    }
}