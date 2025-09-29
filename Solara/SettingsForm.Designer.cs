
namespace Solara
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.autoInjectChkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordWrapChkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scriptsUpdIntervalBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pasteUserNameChkBox = new System.Windows.Forms.CheckBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.watermarkChkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scriptsUpdIntervalBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(320, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.toolTip1.SetToolTip(this.button1, "Cancel");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(226, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.toolTip1.SetToolTip(this.button2, "OK");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // autoInjectChkBox
            // 
            this.autoInjectChkBox.AutoSize = true;
            this.autoInjectChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoInjectChkBox.Location = new System.Drawing.Point(6, 21);
            this.autoInjectChkBox.Name = "autoInjectChkBox";
            this.autoInjectChkBox.Size = new System.Drawing.Size(86, 19);
            this.autoInjectChkBox.TabIndex = 2;
            this.autoInjectChkBox.Text = "AutoInject";
            this.toolTip1.SetToolTip(this.autoInjectChkBox, "Auto Inject on ROBLOX start.");
            this.autoInjectChkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.watermarkChkBox);
            this.groupBox1.Controls.Add(this.wordWrapChkBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.scriptsUpdIntervalBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.autoInjectChkBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // wordWrapChkBox
            // 
            this.wordWrapChkBox.AutoSize = true;
            this.wordWrapChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordWrapChkBox.Location = new System.Drawing.Point(6, 121);
            this.wordWrapChkBox.Name = "wordWrapChkBox";
            this.wordWrapChkBox.Size = new System.Drawing.Size(89, 19);
            this.wordWrapChkBox.TabIndex = 8;
            this.wordWrapChkBox.Text = "WordWrap";
            this.wordWrapChkBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "MS";
            // 
            // scriptsUpdIntervalBox
            // 
            this.scriptsUpdIntervalBox.BackColor = System.Drawing.Color.Black;
            this.scriptsUpdIntervalBox.ForeColor = System.Drawing.Color.Red;
            this.scriptsUpdIntervalBox.Location = new System.Drawing.Point(177, 145);
            this.scriptsUpdIntervalBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.scriptsUpdIntervalBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scriptsUpdIntervalBox.Name = "scriptsUpdIntervalBox";
            this.scriptsUpdIntervalBox.Size = new System.Drawing.Size(51, 21);
            this.scriptsUpdIntervalBox.TabIndex = 6;
            this.scriptsUpdIntervalBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ScriptsUpdateInterval:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pasteUserNameChkBox);
            this.groupBox2.Controls.Add(this.userNameTxtBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // pasteUserNameChkBox
            // 
            this.pasteUserNameChkBox.AutoSize = true;
            this.pasteUserNameChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pasteUserNameChkBox.Location = new System.Drawing.Point(9, 44);
            this.pasteUserNameChkBox.Name = "pasteUserNameChkBox";
            this.pasteUserNameChkBox.Size = new System.Drawing.Size(232, 19);
            this.pasteUserNameChkBox.TabIndex = 5;
            this.pasteUserNameChkBox.Text = "Paste UserName on Ctrl+Shift+U";
            this.pasteUserNameChkBox.UseVisualStyleBackColor = true;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.BackColor = System.Drawing.Color.Black;
            this.userNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTxtBox.ForeColor = System.Drawing.Color.Red;
            this.userNameTxtBox.Location = new System.Drawing.Point(87, 16);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(290, 21);
            this.userNameTxtBox.TabIndex = 4;
            this.userNameTxtBox.Text = "SOLARA";
            this.toolTip1.SetToolTip(this.userNameTxtBox, "Enter User Name if you using Paste User name.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // watermarkChkBox
            // 
            this.watermarkChkBox.AutoSize = true;
            this.watermarkChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watermarkChkBox.Location = new System.Drawing.Point(6, 169);
            this.watermarkChkBox.Name = "watermarkChkBox";
            this.watermarkChkBox.Size = new System.Drawing.Size(131, 19);
            this.watermarkChkBox.TabIndex = 9;
            this.watermarkChkBox.Text = "Show Watermark";
            this.watermarkChkBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(422, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scriptsUpdIntervalBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox autoInjectChkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox pasteUserNameChkBox;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown scriptsUpdIntervalBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox wordWrapChkBox;
        private System.Windows.Forms.CheckBox watermarkChkBox;
    }
}