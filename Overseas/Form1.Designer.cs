namespace Overseas
{
    partial class Overseas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overseas));
            this.gradientpanel1 = new Gradientpanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.UpdateAccountButton = new customButton();
            this.RemoveAccountButton = new customButton();
            this.CreateAccountButton = new customButton();
            this.HistoryButton = new customButton();
            this.DepositButton = new customButton();
            this.WithdrawButton = new customButton();
            this.ViewAccountButton = new customButton();
            this.gradientpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientpanel1
            // 
            this.gradientpanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientpanel1.Angel = 90F;
            this.gradientpanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(193)))), ((int)(((byte)(209)))));
            this.gradientpanel1.Controls.Add(this.pictureBox1);
            this.gradientpanel1.Controls.Add(this.panelMenu);
            this.gradientpanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientpanel1.Name = "gradientpanel1";
            this.gradientpanel1.Size = new System.Drawing.Size(1896, 1016);
            this.gradientpanel1.TabIndex = 0;
            this.gradientpanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.gradientpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientpanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Overseas.Properties.Resources.Group_4;
            this.pictureBox1.Location = new System.Drawing.Point(767, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 688);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenu.Controls.Add(this.UpdateAccountButton);
            this.panelMenu.Controls.Add(this.RemoveAccountButton);
            this.panelMenu.Controls.Add(this.CreateAccountButton);
            this.panelMenu.Controls.Add(this.HistoryButton);
            this.panelMenu.Controls.Add(this.DepositButton);
            this.panelMenu.Controls.Add(this.WithdrawButton);
            this.panelMenu.Controls.Add(this.ViewAccountButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(337, 1016);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UpdateAccountButton
            // 
            this.UpdateAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateAccountButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.UpdateAccountButton.BorderColor = System.Drawing.Color.Transparent;
            this.UpdateAccountButton.BorderRadius = 0;
            this.UpdateAccountButton.BorderSize = 0;
            this.UpdateAccountButton.FlatAppearance.BorderSize = 0;
            this.UpdateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UpdateAccountButton.ForeColor = System.Drawing.Color.White;
            this.UpdateAccountButton.Location = new System.Drawing.Point(0, 668);
            this.UpdateAccountButton.Name = "UpdateAccountButton";
            this.UpdateAccountButton.Size = new System.Drawing.Size(339, 74);
            this.UpdateAccountButton.TabIndex = 13;
            this.UpdateAccountButton.Text = "Update Account";
            this.UpdateAccountButton.TextColor = System.Drawing.Color.White;
            this.UpdateAccountButton.UseVisualStyleBackColor = false;
            this.UpdateAccountButton.MouseEnter += new System.EventHandler(this.UpdateAccountButton_MouseEnter_1);
            this.UpdateAccountButton.MouseLeave += new System.EventHandler(this.UpdateAccountButton_MouseLeave_1);
            this.UpdateAccountButton.MouseHover += new System.EventHandler(this.UpdateAccountButton_MouseHover_1);
            // 
            // RemoveAccountButton
            // 
            this.RemoveAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveAccountButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.RemoveAccountButton.BorderColor = System.Drawing.Color.Transparent;
            this.RemoveAccountButton.BorderRadius = 0;
            this.RemoveAccountButton.BorderSize = 0;
            this.RemoveAccountButton.FlatAppearance.BorderSize = 0;
            this.RemoveAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RemoveAccountButton.ForeColor = System.Drawing.Color.White;
            this.RemoveAccountButton.Location = new System.Drawing.Point(0, 568);
            this.RemoveAccountButton.Name = "RemoveAccountButton";
            this.RemoveAccountButton.Size = new System.Drawing.Size(339, 74);
            this.RemoveAccountButton.TabIndex = 12;
            this.RemoveAccountButton.Text = "Remove Account";
            this.RemoveAccountButton.TextColor = System.Drawing.Color.White;
            this.RemoveAccountButton.UseVisualStyleBackColor = false;
            this.RemoveAccountButton.MouseEnter += new System.EventHandler(this.RemoveAccountButton_MouseEnter_1);
            this.RemoveAccountButton.MouseLeave += new System.EventHandler(this.RemoveAccountButton_MouseLeave_1);
            this.RemoveAccountButton.MouseHover += new System.EventHandler(this.RemoveAccountButton_MouseHover_1);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.BorderColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.BorderRadius = 0;
            this.CreateAccountButton.BorderSize = 0;
            this.CreateAccountButton.FlatAppearance.BorderSize = 0;
            this.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CreateAccountButton.ForeColor = System.Drawing.Color.White;
            this.CreateAccountButton.Location = new System.Drawing.Point(0, 468);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(339, 74);
            this.CreateAccountButton.TabIndex = 11;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.TextColor = System.Drawing.Color.White;
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.MouseEnter += new System.EventHandler(this.CreateAccountButton_MouseEnter_1);
            this.CreateAccountButton.MouseLeave += new System.EventHandler(this.CreateAccountButton_MouseLeave_1);
            this.CreateAccountButton.MouseHover += new System.EventHandler(this.CreateAccountButton_MouseHover);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.Transparent;
            this.HistoryButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.HistoryButton.BorderColor = System.Drawing.Color.Transparent;
            this.HistoryButton.BorderRadius = 0;
            this.HistoryButton.BorderSize = 0;
            this.HistoryButton.FlatAppearance.BorderSize = 0;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HistoryButton.ForeColor = System.Drawing.Color.White;
            this.HistoryButton.Location = new System.Drawing.Point(0, 368);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(339, 74);
            this.HistoryButton.TabIndex = 10;
            this.HistoryButton.Text = "History";
            this.HistoryButton.TextColor = System.Drawing.Color.White;
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.MouseEnter += new System.EventHandler(this.HistoryButton_MouseEnter_1);
            this.HistoryButton.MouseLeave += new System.EventHandler(this.HistoryButton_MouseLeave_1);
            this.HistoryButton.MouseHover += new System.EventHandler(this.HistoryButton_MouseHover_1);
            // 
            // DepositButton
            // 
            this.DepositButton.BackColor = System.Drawing.Color.Transparent;
            this.DepositButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.DepositButton.BorderColor = System.Drawing.Color.Transparent;
            this.DepositButton.BorderRadius = 0;
            this.DepositButton.BorderSize = 0;
            this.DepositButton.FlatAppearance.BorderSize = 0;
            this.DepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DepositButton.ForeColor = System.Drawing.Color.White;
            this.DepositButton.Location = new System.Drawing.Point(0, 268);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(339, 74);
            this.DepositButton.TabIndex = 9;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.TextColor = System.Drawing.Color.White;
            this.DepositButton.UseVisualStyleBackColor = false;
            this.DepositButton.MouseEnter += new System.EventHandler(this.DepositButton_MouseEnter_1);
            this.DepositButton.MouseLeave += new System.EventHandler(this.DepositButton_MouseLeave_1);
            this.DepositButton.MouseHover += new System.EventHandler(this.DepositButton_MouseHover_1);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.BackColor = System.Drawing.Color.Transparent;
            this.WithdrawButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.WithdrawButton.BorderColor = System.Drawing.Color.Transparent;
            this.WithdrawButton.BorderRadius = 0;
            this.WithdrawButton.BorderSize = 0;
            this.WithdrawButton.FlatAppearance.BorderSize = 0;
            this.WithdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithdrawButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.WithdrawButton.ForeColor = System.Drawing.Color.White;
            this.WithdrawButton.Location = new System.Drawing.Point(0, 168);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(339, 74);
            this.WithdrawButton.TabIndex = 8;
            this.WithdrawButton.Text = "WithDraw";
            this.WithdrawButton.TextColor = System.Drawing.Color.White;
            this.WithdrawButton.UseVisualStyleBackColor = false;
            this.WithdrawButton.MouseEnter += new System.EventHandler(this.WithdrawButton_MouseEnter);
            this.WithdrawButton.MouseLeave += new System.EventHandler(this.WithdrawButton_MouseLeave);
            this.WithdrawButton.MouseHover += new System.EventHandler(this.WithdrawButton_MouseHover);
            // 
            // ViewAccountButton
            // 
            this.ViewAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewAccountButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ViewAccountButton.BorderColor = System.Drawing.Color.Transparent;
            this.ViewAccountButton.BorderRadius = 0;
            this.ViewAccountButton.BorderSize = 0;
            this.ViewAccountButton.FlatAppearance.BorderSize = 0;
            this.ViewAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ViewAccountButton.ForeColor = System.Drawing.Color.White;
            this.ViewAccountButton.Location = new System.Drawing.Point(0, 68);
            this.ViewAccountButton.Name = "ViewAccountButton";
            this.ViewAccountButton.Size = new System.Drawing.Size(339, 74);
            this.ViewAccountButton.TabIndex = 7;
            this.ViewAccountButton.Text = "View Account";
            this.ViewAccountButton.TextColor = System.Drawing.Color.White;
            this.ViewAccountButton.UseVisualStyleBackColor = false;
            this.ViewAccountButton.MouseEnter += new System.EventHandler(this.customButton1_MouseEnter);
            this.ViewAccountButton.MouseLeave += new System.EventHandler(this.customButton1_MouseLeave);
            this.ViewAccountButton.MouseHover += new System.EventHandler(this.customButton1_MouseHover);
            // 
            // Overseas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.gradientpanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Overseas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Overseas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientpanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gradientpanel gradientpanel1;
        private System.Windows.Forms.Panel panelMenu;
        private customButton ViewAccountButton;
        private customButton WithdrawButton;
        private customButton DepositButton;
        private customButton UpdateAccountButton;
        private customButton RemoveAccountButton;
        private customButton CreateAccountButton;
        private customButton HistoryButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

