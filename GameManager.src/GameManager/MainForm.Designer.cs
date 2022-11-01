namespace GameManager {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonLibary = new System.Windows.Forms.Button();
            this.buttonNewGames = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonTop5 = new System.Windows.Forms.Button();
            this.buttonTop4 = new System.Windows.Forms.Button();
            this.buttonTop3 = new System.Windows.Forms.Button();
            this.buttonTop2 = new System.Windows.Forms.Button();
            this.buttonTop1 = new System.Windows.Forms.Button();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.seachBarPannel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.seachBarPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.panelMenu.Controls.Add(this.seachBarPannel);
            this.panelMenu.Controls.Add(this.buttonHelp);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonLibary);
            this.panelMenu.Controls.Add(this.buttonNewGames);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(458, 1101);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Location = new System.Drawing.Point(0, 528);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonHelp.Size = new System.Drawing.Size(458, 90);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 438);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonSettings.Size = new System.Drawing.Size(458, 90);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonLibary
            // 
            this.buttonLibary.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLibary.FlatAppearance.BorderSize = 0;
            this.buttonLibary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibary.ForeColor = System.Drawing.Color.White;
            this.buttonLibary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibary.Location = new System.Drawing.Point(0, 348);
            this.buttonLibary.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLibary.Name = "buttonLibary";
            this.buttonLibary.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonLibary.Size = new System.Drawing.Size(458, 90);
            this.buttonLibary.TabIndex = 1;
            this.buttonLibary.Text = "Libary";
            this.buttonLibary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLibary.UseVisualStyleBackColor = true;
            this.buttonLibary.Click += new System.EventHandler(this.buttonLibary_Click);
            // 
            // buttonNewGames
            // 
            this.buttonNewGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.buttonNewGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewGames.FlatAppearance.BorderSize = 0;
            this.buttonNewGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGames.ForeColor = System.Drawing.Color.White;
            this.buttonNewGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewGames.Location = new System.Drawing.Point(0, 258);
            this.buttonNewGames.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewGames.Name = "buttonNewGames";
            this.buttonNewGames.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonNewGames.Size = new System.Drawing.Size(458, 90);
            this.buttonNewGames.TabIndex = 0;
            this.buttonNewGames.Text = "New Games";
            this.buttonNewGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNewGames.UseVisualStyleBackColor = false;
            this.buttonNewGames.Click += new System.EventHandler(this.buttonNewGames_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(458, 258);
            this.panelLogo.TabIndex = 5;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.InitialImage")));
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(458, 258);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.WaitOnLoad = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.panelTitleBar.Controls.Add(this.buttonTop5);
            this.panelTitleBar.Controls.Add(this.buttonTop4);
            this.panelTitleBar.Controls.Add(this.buttonTop3);
            this.panelTitleBar.Controls.Add(this.buttonTop2);
            this.panelTitleBar.Controls.Add(this.buttonTop1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(458, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1392, 104);
            this.panelTitleBar.TabIndex = 5;
            // 
            // buttonTop5
            // 
            this.buttonTop5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.buttonTop5.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTop5.FlatAppearance.BorderSize = 0;
            this.buttonTop5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop5.ForeColor = System.Drawing.Color.White;
            this.buttonTop5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop5.Location = new System.Drawing.Point(1112, 0);
            this.buttonTop5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTop5.Name = "buttonTop5";
            this.buttonTop5.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonTop5.Size = new System.Drawing.Size(278, 104);
            this.buttonTop5.TabIndex = 5;
            this.buttonTop5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTop5.UseVisualStyleBackColor = false;
            // 
            // buttonTop4
            // 
            this.buttonTop4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.buttonTop4.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTop4.FlatAppearance.BorderSize = 0;
            this.buttonTop4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop4.ForeColor = System.Drawing.Color.White;
            this.buttonTop4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop4.Location = new System.Drawing.Point(834, 0);
            this.buttonTop4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTop4.Name = "buttonTop4";
            this.buttonTop4.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonTop4.Size = new System.Drawing.Size(278, 104);
            this.buttonTop4.TabIndex = 4;
            this.buttonTop4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTop4.UseVisualStyleBackColor = false;
            // 
            // buttonTop3
            // 
            this.buttonTop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.buttonTop3.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTop3.FlatAppearance.BorderSize = 0;
            this.buttonTop3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop3.ForeColor = System.Drawing.Color.White;
            this.buttonTop3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop3.Location = new System.Drawing.Point(556, 0);
            this.buttonTop3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTop3.Name = "buttonTop3";
            this.buttonTop3.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonTop3.Size = new System.Drawing.Size(278, 104);
            this.buttonTop3.TabIndex = 3;
            this.buttonTop3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTop3.UseVisualStyleBackColor = false;
            // 
            // buttonTop2
            // 
            this.buttonTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.buttonTop2.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTop2.FlatAppearance.BorderSize = 0;
            this.buttonTop2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop2.ForeColor = System.Drawing.Color.White;
            this.buttonTop2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop2.Location = new System.Drawing.Point(278, 0);
            this.buttonTop2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTop2.Name = "buttonTop2";
            this.buttonTop2.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonTop2.Size = new System.Drawing.Size(278, 104);
            this.buttonTop2.TabIndex = 2;
            this.buttonTop2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTop2.UseVisualStyleBackColor = false;
            // 
            // buttonTop1
            // 
            this.buttonTop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(97)))), ((int)(((byte)(139)))));
            this.buttonTop1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTop1.FlatAppearance.BorderSize = 0;
            this.buttonTop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop1.ForeColor = System.Drawing.Color.White;
            this.buttonTop1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop1.Location = new System.Drawing.Point(0, 0);
            this.buttonTop1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTop1.Name = "buttonTop1";
            this.buttonTop1.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.buttonTop1.Size = new System.Drawing.Size(278, 104);
            this.buttonTop1.TabIndex = 1;
            this.buttonTop1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTop1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTop1.UseVisualStyleBackColor = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(458, 104);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1392, 9);
            this.panelShadow.TabIndex = 6;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(167)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(458, 113);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1392, 988);
            this.panelDesktop.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip.Size = new System.Drawing.Size(997, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // seachBarPannel
            // 
            this.seachBarPannel.Controls.Add(this.searchBox);
            this.seachBarPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seachBarPannel.Location = new System.Drawing.Point(0, 1045);
            this.seachBarPannel.Name = "seachBarPannel";
            this.seachBarPannel.Size = new System.Drawing.Size(458, 56);
            this.seachBarPannel.TabIndex = 6;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(61, 16);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(391, 26);
            this.searchBox.TabIndex = 0;
            this.searchBox.Visible = false;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1850, 1101);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Game Manager";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.seachBarPannel.ResumeLayout(false);
            this.seachBarPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonNewGames;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonLibary;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonTop5;
        private System.Windows.Forms.Button buttonTop4;
        private System.Windows.Forms.Button buttonTop3;
        private System.Windows.Forms.Button buttonTop2;
        private System.Windows.Forms.Button buttonTop1;
        private System.Windows.Forms.Panel seachBarPannel;
        private System.Windows.Forms.TextBox searchBox;
    }
}

