namespace Database
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sortButton = new System.Windows.Forms.Button();
            this.coreNameRadio = new System.Windows.Forms.RadioButton();
            this.sizeRadio = new System.Windows.Forms.RadioButton();
            this.documentCountRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sortButton
            // 
            resources.ApplyResources(this.sortButton, "sortButton");
            this.sortButton.Name = "sortButton";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // coreNameRadio
            // 
            resources.ApplyResources(this.coreNameRadio, "coreNameRadio");
            this.coreNameRadio.Name = "coreNameRadio";
            this.coreNameRadio.UseVisualStyleBackColor = true;
            // 
            // sizeRadio
            // 
            resources.ApplyResources(this.sizeRadio, "sizeRadio");
            this.sizeRadio.Name = "sizeRadio";
            this.sizeRadio.UseVisualStyleBackColor = true;
            // 
            // documentCountRadio
            // 
            resources.ApplyResources(this.documentCountRadio, "documentCountRadio");
            this.documentCountRadio.Name = "documentCountRadio";
            this.documentCountRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chooseFileButton
            // 
            resources.ApplyResources(this.chooseFileButton, "chooseFileButton");
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // filePathLabel
            // 
            resources.ApplyResources(this.filePathLabel, "filePathLabel");
            this.filePathLabel.Name = "filePathLabel";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.documentCountRadio);
            this.Controls.Add(this.sizeRadio);
            this.Controls.Add(this.coreNameRadio);
            this.Controls.Add(this.sortButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.RadioButton coreNameRadio;
        private System.Windows.Forms.RadioButton sizeRadio;
        private System.Windows.Forms.RadioButton documentCountRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label filePathLabel;
    }
}

