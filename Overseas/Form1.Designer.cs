namespace Overseas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gradientpanel1 = new Overseas.Gradientpanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonUpdateAccount = new System.Windows.Forms.Button();
            this.buttonRemoveAccount = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdaw = new System.Windows.Forms.Button();
            this.buttonViewAccount = new System.Windows.Forms.Button();
            this.gradientpanel1.SuspendLayout();
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
            this.gradientpanel1.Controls.Add(this.panelMenu);
            this.gradientpanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientpanel1.Name = "gradientpanel1";
            this.gradientpanel1.Size = new System.Drawing.Size(1896, 1016);
            this.gradientpanel1.TabIndex = 0;
            this.gradientpanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.gradientpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientpanel1_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenu.Controls.Add(this.buttonUpdateAccount);
            this.panelMenu.Controls.Add(this.buttonRemoveAccount);
            this.panelMenu.Controls.Add(this.buttonCreateAccount);
            this.panelMenu.Controls.Add(this.buttonHistory);
            this.panelMenu.Controls.Add(this.buttonDeposit);
            this.panelMenu.Controls.Add(this.buttonWithdaw);
            this.panelMenu.Controls.Add(this.buttonViewAccount);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(362, 1016);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonUpdateAccount
            // 
            this.buttonUpdateAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUpdateAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonUpdateAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdateAccount.Location = new System.Drawing.Point(0, 518);
            this.buttonUpdateAccount.Name = "buttonUpdateAccount";
            this.buttonUpdateAccount.Size = new System.Drawing.Size(307, 74);
            this.buttonUpdateAccount.TabIndex = 6;
            this.buttonUpdateAccount.Text = "Update Account";
            this.buttonUpdateAccount.UseVisualStyleBackColor = false;
            // 
            // buttonRemoveAccount
            // 
            this.buttonRemoveAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRemoveAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonRemoveAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRemoveAccount.Location = new System.Drawing.Point(0, 438);
            this.buttonRemoveAccount.Name = "buttonRemoveAccount";
            this.buttonRemoveAccount.Size = new System.Drawing.Size(307, 74);
            this.buttonRemoveAccount.TabIndex = 5;
            this.buttonRemoveAccount.Text = "Remove Account";
            this.buttonRemoveAccount.UseVisualStyleBackColor = false;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCreateAccount.Location = new System.Drawing.Point(0, 358);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(307, 74);
            this.buttonCreateAccount.TabIndex = 4;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHistory.BackColor = System.Drawing.Color.Transparent;
            this.buttonHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHistory.Location = new System.Drawing.Point(0, 278);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(307, 74);
            this.buttonHistory.TabIndex = 3;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDeposit.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeposit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonDeposit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDeposit.Location = new System.Drawing.Point(0, 198);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(307, 74);
            this.buttonDeposit.TabIndex = 2;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            // 
            // buttonWithdaw
            // 
            this.buttonWithdaw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonWithdaw.BackColor = System.Drawing.Color.Transparent;
            this.buttonWithdaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWithdaw.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonWithdaw.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonWithdaw.Location = new System.Drawing.Point(0, 118);
            this.buttonWithdaw.Name = "buttonWithdaw";
            this.buttonWithdaw.Size = new System.Drawing.Size(307, 74);
            this.buttonWithdaw.TabIndex = 1;
            this.buttonWithdaw.Text = "Withdraw";
            this.buttonWithdaw.UseVisualStyleBackColor = false;
            // 
            // buttonViewAccount
            // 
            this.buttonViewAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonViewAccount.BackColor = System.Drawing.Color.Transparent;
            this.buttonViewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonViewAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonViewAccount.Location = new System.Drawing.Point(0, 38);
            this.buttonViewAccount.Name = "buttonViewAccount";
            this.buttonViewAccount.Size = new System.Drawing.Size(307, 74);
            this.buttonViewAccount.TabIndex = 0;
            this.buttonViewAccount.Text = "View Account";
            this.buttonViewAccount.UseVisualStyleBackColor = false;
            this.buttonViewAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.gradientpanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientpanel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gradientpanel gradientpanel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonViewAccount;
        private System.Windows.Forms.Button buttonUpdateAccount;
        private System.Windows.Forms.Button buttonRemoveAccount;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdaw;
    }
}

