﻿namespace Financiera.Presentation.Forms.Main
{
    partial class MainForm
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
            this.panelActions = new System.Windows.Forms.Panel();
            this.lbRol = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pboxCards = new System.Windows.Forms.PictureBox();
            this.lbCards = new System.Windows.Forms.Label();
            this.lbCounts = new System.Windows.Forms.Label();
            this.pboxCounts = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lbClients = new System.Windows.Forms.Label();
            this.pboxClients = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.timerOpen = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.BorderlessFormMain = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timerOpenUsCounts = new System.Windows.Forms.Timer(this.components);
            this.timerOpenCard = new System.Windows.Forms.Timer(this.components);
            this.panelActions.SuspendLayout();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.Silver;
            this.panelActions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelActions.Controls.Add(this.lbRol);
            this.panelActions.Controls.Add(this.lbUser);
            this.panelActions.Controls.Add(this.btMinimize);
            this.panelActions.Controls.Add(this.btClose);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1118, 23);
            this.panelActions.TabIndex = 1;
            this.panelActions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelActions_MouseDown);
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Location = new System.Drawing.Point(140, 4);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(27, 15);
            this.lbRol.TabIndex = 3;
            this.lbRol.Text = "Rol:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(3, 4);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(50, 15);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Usuario:";
            // 
            // btMinimize
            // 
            this.btMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btMinimize.BackgroundImage = global::Financiera.Presentation.Properties.Resources.point_green;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(214)))), ((int)(((byte)(141)))));
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.ForeColor = System.Drawing.Color.White;
            this.btMinimize.Location = new System.Drawing.Point(1021, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(50, 23);
            this.btMinimize.TabIndex = 1;
            this.btMinimize.TabStop = false;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BackgroundImage = global::Financiera.Presentation.Properties.Resources.point_red;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(1071, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(47, 23);
            this.btClose.TabIndex = 0;
            this.btClose.TabStop = false;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelOptions.Controls.Add(this.panel4);
            this.panelOptions.Controls.Add(this.panel3);
            this.panelOptions.Controls.Add(this.panel2);
            this.panelOptions.Controls.Add(this.panel1);
            this.panelOptions.Controls.Add(this.pbLogout);
            this.panelOptions.Controls.Add(this.label4);
            this.panelOptions.Controls.Add(this.pboxCards);
            this.panelOptions.Controls.Add(this.lbCards);
            this.panelOptions.Controls.Add(this.lbCounts);
            this.panelOptions.Controls.Add(this.pboxCounts);
            this.panelOptions.Controls.Add(this.lbClients);
            this.panelOptions.Controls.Add(this.pboxClients);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOptions.Location = new System.Drawing.Point(0, 23);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(82, 462);
            this.panelOptions.TabIndex = 2;
            this.panelOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOptions_Paint);
            this.panelOptions.MouseEnter += new System.EventHandler(this.panelOptions_MouseEnter);
            this.panelOptions.MouseLeave += new System.EventHandler(this.panelOptions_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(1, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 1);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(-4, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(-4, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-4, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 1);
            this.panel1.TabIndex = 13;
            // 
            // pbLogout
            // 
            this.pbLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = global::Financiera.Presentation.Properties.Resources.log_out;
            this.pbLogout.Location = new System.Drawing.Point(13, 386);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(50, 50);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 8;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            this.pbLogout.MouseEnter += new System.EventHandler(this.pbLogout_MouseEnter);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cerrar Sesión";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            // 
            // pboxCards
            // 
            this.pboxCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxCards.Image = global::Financiera.Presentation.Properties.Resources.credit_card;
            this.pboxCards.Location = new System.Drawing.Point(12, 204);
            this.pboxCards.Name = "pboxCards";
            this.pboxCards.Size = new System.Drawing.Size(50, 50);
            this.pboxCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxCards.TabIndex = 6;
            this.pboxCards.TabStop = false;
            this.pboxCards.Click += new System.EventHandler(this.pbCards_Click);
            this.pboxCards.MouseEnter += new System.EventHandler(this.pbCards_MouseEnter);
            // 
            // lbCards
            // 
            this.lbCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCards.AutoSize = true;
            this.lbCards.Location = new System.Drawing.Point(13, 257);
            this.lbCards.Name = "lbCards";
            this.lbCards.Size = new System.Drawing.Size(46, 15);
            this.lbCards.TabIndex = 5;
            this.lbCards.Text = "Tarjetas";
            this.lbCards.MouseEnter += new System.EventHandler(this.lbCards_MouseEnter);
            // 
            // lbCounts
            // 
            this.lbCounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCounts.AutoSize = true;
            this.lbCounts.Location = new System.Drawing.Point(12, 165);
            this.lbCounts.Name = "lbCounts";
            this.lbCounts.Size = new System.Drawing.Size(50, 15);
            this.lbCounts.TabIndex = 3;
            this.lbCounts.Text = "Cuentas";
            this.lbCounts.MouseEnter += new System.EventHandler(this.lbCounts_MouseEnter);
            // 
            // pboxCounts
            // 
            this.pboxCounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxCounts.BackColor = System.Drawing.Color.Transparent;
            this.pboxCounts.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pboxCounts.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pboxCounts.BorderColor2 = System.Drawing.Color.HotPink;
            this.pboxCounts.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pboxCounts.BorderSize = 0;
            this.pboxCounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxCounts.GradientAngle = 50F;
            this.pboxCounts.Image = global::Financiera.Presentation.Properties.Resources.count;
            this.pboxCounts.Location = new System.Drawing.Point(12, 110);
            this.pboxCounts.Name = "pboxCounts";
            this.pboxCounts.Size = new System.Drawing.Size(50, 50);
            this.pboxCounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxCounts.TabIndex = 2;
            this.pboxCounts.TabStop = false;
            this.pboxCounts.Click += new System.EventHandler(this.pbCounts_Click);
            this.pboxCounts.MouseEnter += new System.EventHandler(this.pbCounts_MouseEnter);
            // 
            // lbClients
            // 
            this.lbClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClients.AutoSize = true;
            this.lbClients.Location = new System.Drawing.Point(13, 73);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(49, 15);
            this.lbClients.TabIndex = 1;
            this.lbClients.Text = "Clientes";
            this.lbClients.MouseEnter += new System.EventHandler(this.lbClients_MouseEnter);
            // 
            // pboxClients
            // 
            this.pboxClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxClients.BackColor = System.Drawing.Color.Transparent;
            this.pboxClients.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pboxClients.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pboxClients.BorderColor2 = System.Drawing.Color.HotPink;
            this.pboxClients.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pboxClients.BorderSize = 0;
            this.pboxClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxClients.GradientAngle = 50F;
            this.pboxClients.Image = global::Financiera.Presentation.Properties.Resources.client;
            this.pboxClients.Location = new System.Drawing.Point(13, 18);
            this.pboxClients.Name = "pboxClients";
            this.pboxClients.Size = new System.Drawing.Size(50, 50);
            this.pboxClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxClients.TabIndex = 0;
            this.pboxClients.TabStop = false;
            this.pboxClients.Click += new System.EventHandler(this.pboxClients_Click);
            this.pboxClients.MouseEnter += new System.EventHandler(this.pboxClients_MouseEnter);
            // 
            // timerOpen
            // 
            this.timerOpen.Interval = 10;
            this.timerOpen.Tick += new System.EventHandler(this.timerOpen_Tick);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(82, 23);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1036, 462);
            this.panelMain.TabIndex = 3;
            // 
            // BorderlessFormMain
            // 
            this.BorderlessFormMain.BorderRadius = 5;
            this.BorderlessFormMain.ContainerControl = this;
            this.BorderlessFormMain.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormMain.TransparentWhileDrag = true;
            // 
            // timerOpenUsCounts
            // 
            this.timerOpenUsCounts.Interval = 10;
            this.timerOpenUsCounts.Tick += new System.EventHandler(this.timerOpenUsCounts_Tick);
            // 
            // timerOpenCard
            // 
            this.timerOpenCard.Interval = 10;
            this.timerOpenCard.Tick += new System.EventHandler(this.timerOpenCard_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1118, 485);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panelActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btClose;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panelOptions;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pboxClients;
        private System.Windows.Forms.Timer timerOpen;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lbClients;
        private System.Windows.Forms.PictureBox pboxCards;
        private System.Windows.Forms.Label lbCards;
        private System.Windows.Forms.Label lbCounts;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pboxCounts;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timerOpenUsCounts;
        private System.Windows.Forms.Timer timerOpenCard;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Label lbUser;
    }
}