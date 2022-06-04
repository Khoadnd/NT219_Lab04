namespace NT219_Lab04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textPage = new System.Windows.Forms.TabPage();
            this.textUserControl = new NT219_Lab04.TextPage();
            this.hexPage = new System.Windows.Forms.TabPage();
            this.hexUserControl = new NT219_Lab04.HexPage();
            this.filePage = new System.Windows.Forms.TabPage();
            this.fileUserControl = new NT219_Lab04.FilePage();
            this.tabControl1.SuspendLayout();
            this.textPage.SuspendLayout();
            this.hexPage.SuspendLayout();
            this.filePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.textPage);
            this.tabControl1.Controls.Add(this.hexPage);
            this.tabControl1.Controls.Add(this.filePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // textPage
            // 
            this.textPage.Controls.Add(this.textUserControl);
            this.textPage.Location = new System.Drawing.Point(4, 24);
            this.textPage.Name = "textPage";
            this.textPage.Padding = new System.Windows.Forms.Padding(3);
            this.textPage.Size = new System.Drawing.Size(902, 253);
            this.textPage.TabIndex = 1;
            this.textPage.Text = "Text";
            this.textPage.UseVisualStyleBackColor = true;
            // 
            // textUserControl
            // 
            this.textUserControl.AutoSize = true;
            this.textUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textUserControl.Location = new System.Drawing.Point(3, 3);
            this.textUserControl.Name = "textUserControl";
            this.textUserControl.Size = new System.Drawing.Size(896, 247);
            this.textUserControl.TabIndex = 0;
            // 
            // hexPage
            // 
            this.hexPage.Controls.Add(this.hexUserControl);
            this.hexPage.Location = new System.Drawing.Point(4, 24);
            this.hexPage.Name = "hexPage";
            this.hexPage.Padding = new System.Windows.Forms.Padding(3);
            this.hexPage.Size = new System.Drawing.Size(922, 255);
            this.hexPage.TabIndex = 1;
            this.hexPage.Text = "Hex";
            this.hexPage.UseVisualStyleBackColor = true;
            // 
            // hexUserControl
            // 
            this.hexUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexUserControl.Location = new System.Drawing.Point(3, 3);
            this.hexUserControl.Name = "hexUserControl";
            this.hexUserControl.Size = new System.Drawing.Size(916, 249);
            this.hexUserControl.TabIndex = 0;
            // 
            // filePage
            // 
            this.filePage.Controls.Add(this.fileUserControl);
            this.filePage.Location = new System.Drawing.Point(4, 24);
            this.filePage.Name = "filePage";
            this.filePage.Padding = new System.Windows.Forms.Padding(3);
            this.filePage.Size = new System.Drawing.Size(922, 255);
            this.filePage.TabIndex = 1;
            this.filePage.Text = "File";
            this.filePage.UseVisualStyleBackColor = true;
            // 
            // fileUserControl
            // 
            this.fileUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileUserControl.Location = new System.Drawing.Point(3, 3);
            this.fileUserControl.Name = "fileUserControl";
            this.fileUserControl.Size = new System.Drawing.Size(916, 249);
            this.fileUserControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 301);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.textPage.ResumeLayout(false);
            this.textPage.PerformLayout();
            this.hexPage.ResumeLayout(false);
            this.filePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage textPage;
        private TabPage hexPage;
        private TabPage filePage;
        private TextPage textUserControl;
        private HexPage hexUserControl;
        private FilePage fileUserControl;
    }
}