
namespace Solara
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.injectBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.executeBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.killBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.scriptsBtn = new System.Windows.Forms.Button();
            this.sAVESCRIPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new ZBobb.AlphaBlendTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sHOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // injectBtn
            // 
            this.injectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.injectBtn.BackColor = System.Drawing.Color.Silver;
            this.injectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.injectBtn.Image = global::Solara.Properties.Resources.inject;
            this.injectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.injectBtn.Location = new System.Drawing.Point(617, 472);
            this.injectBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(109, 32);
            this.injectBtn.TabIndex = 2;
            this.injectBtn.Text = "INJECT";
            this.injectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.injectBtn.UseVisualStyleBackColor = false;
            this.injectBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.clearBtn.Image = global::Solara.Properties.Resources.clear;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(383, 472);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(109, 32);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // executeBtn
            // 
            this.executeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.executeBtn.BackColor = System.Drawing.Color.Silver;
            this.executeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.executeBtn.Image = global::Solara.Properties.Resources.execute;
            this.executeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.executeBtn.Location = new System.Drawing.Point(734, 472);
            this.executeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(109, 32);
            this.executeBtn.TabIndex = 4;
            this.executeBtn.Text = "EXECUTE";
            this.executeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.executeBtn.UseVisualStyleBackColor = false;
            this.executeBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLbl.BackColor = System.Drawing.Color.Transparent;
            this.statusLbl.Location = new System.Drawing.Point(12, 473);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(247, 32);
            this.statusLbl.TabIndex = 5;
            this.statusLbl.Text = "Status: NOT INJECTED";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // killBtn
            // 
            this.killBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.killBtn.BackColor = System.Drawing.Color.Silver;
            this.killBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.killBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.killBtn.Image = global::Solara.Properties.Resources.kill;
            this.killBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.killBtn.Location = new System.Drawing.Point(500, 472);
            this.killBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.killBtn.Name = "killBtn";
            this.killBtn.Size = new System.Drawing.Size(109, 32);
            this.killBtn.TabIndex = 6;
            this.killBtn.Text = "KILL";
            this.killBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.killBtn.UseVisualStyleBackColor = false;
            this.killBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SOLARA by VladOS63K";
            this.notifyIcon1.Visible = true;
            // 
            // scriptsBtn
            // 
            this.scriptsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptsBtn.BackColor = System.Drawing.Color.Silver;
            this.scriptsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scriptsBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.scriptsBtn.Image = global::Solara.Properties.Resources.scripts;
            this.scriptsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scriptsBtn.Location = new System.Drawing.Point(266, 472);
            this.scriptsBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scriptsBtn.Name = "scriptsBtn";
            this.scriptsBtn.Size = new System.Drawing.Size(109, 32);
            this.scriptsBtn.TabIndex = 7;
            this.scriptsBtn.Text = "SCRIPTS";
            this.scriptsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scriptsBtn.UseVisualStyleBackColor = false;
            this.scriptsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sAVESCRIPTToolStripMenuItem
            // 
            this.sAVESCRIPTToolStripMenuItem.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAVESCRIPTToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sAVESCRIPTToolStripMenuItem.Name = "sAVESCRIPTToolStripMenuItem";
            this.sAVESCRIPTToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sAVESCRIPTToolStripMenuItem.Text = "SAVE SCRIPT";
            this.sAVESCRIPTToolStripMenuItem.Click += new System.EventHandler(this.sAVESCRIPTToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Black;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAVESCRIPTToolStripMenuItem,
            this.oPENToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.oPENToolStripMenuItem.Text = "LOAD SCRIPT";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackAlpha = 0;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(15, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(828, 454);
            this.textBox1.TabIndex = 9;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.Black;
            this.contextMenuStrip2.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sHOWToolStripMenuItem,
            this.toolStripSeparator1,
            this.aBOUTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 98);
            // 
            // sHOWToolStripMenuItem
            // 
            this.sHOWToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sHOWToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sHOWToolStripMenuItem.Name = "sHOWToolStripMenuItem";
            this.sHOWToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sHOWToolStripMenuItem.Text = "SHOW/HIDE";
            this.sHOWToolStripMenuItem.Click += new System.EventHandler(this.sHOWToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Red;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.aBOUTToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.aBOUTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.eXITToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Solara.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(855, 519);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.scriptsBtn);
            this.Controls.Add(this.killBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.injectBtn);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOLARA by VladOS63K";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button injectBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button killBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button scriptsBtn;
        private System.Windows.Forms.ToolStripMenuItem sAVESCRIPTToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private ZBobb.AlphaBlendTextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sHOWToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}

