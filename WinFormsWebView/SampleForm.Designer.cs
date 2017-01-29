namespace WinForms
{
    partial class SampleForm
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
            this.Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.Silent = new System.Windows.Forms.CheckBox();
            this.OtherDataDisplay = new System.Windows.Forms.TextBox();
            this.AccessTokenLabel = new System.Windows.Forms.Label();
            this.IdentityTokenLabel = new System.Windows.Forms.Label();
            this.AccessTokenDisplay = new System.Windows.Forms.TextBox();
            this.CallApiButton = new System.Windows.Forms.Button();
            this.TenantsListBox = new System.Windows.Forms.ListBox();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentityTokenDisplay = new System.Windows.Forms.TextBox();
            this.Inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inputs
            // 
            this.Inputs.ColumnCount = 5;
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Inputs.Controls.Add(this.LoginButton, 1, 0);
            this.Inputs.Controls.Add(this.LogoutButton, 2, 0);
            this.Inputs.Controls.Add(this.Silent, 4, 0);
            this.Inputs.Controls.Add(this.OtherDataDisplay, 1, 2);
            this.Inputs.Controls.Add(this.AccessTokenLabel, 0, 1);
            this.Inputs.Controls.Add(this.IdentityTokenLabel, 0, 2);
            this.Inputs.Controls.Add(this.AccessTokenDisplay, 1, 1);
            this.Inputs.Controls.Add(this.CallApiButton, 3, 0);
            this.Inputs.Controls.Add(this.AuthorizeButton, 4, 4);
            this.Inputs.Controls.Add(this.TenantsListBox, 1, 4);
            this.Inputs.Controls.Add(this.label1, 0, 3);
            this.Inputs.Controls.Add(this.IdentityTokenDisplay, 1, 3);
            this.Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inputs.Location = new System.Drawing.Point(0, 0);
            this.Inputs.Name = "Inputs";
            this.Inputs.RowCount = 5;
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Inputs.Size = new System.Drawing.Size(624, 441);
            this.Inputs.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginButton.Location = new System.Drawing.Point(88, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 29);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoutButton.Location = new System.Drawing.Point(188, 3);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(94, 29);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Silent
            // 
            this.Silent.AutoSize = true;
            this.Silent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Silent.Location = new System.Drawing.Point(546, 3);
            this.Silent.Name = "Silent";
            this.Silent.Size = new System.Drawing.Size(75, 29);
            this.Silent.TabIndex = 3;
            this.Silent.Text = "Silent";
            this.Silent.UseVisualStyleBackColor = true;
            // 
            // OtherDataDisplay
            // 
            this.Inputs.SetColumnSpan(this.OtherDataDisplay, 4);
            this.OtherDataDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OtherDataDisplay.Location = new System.Drawing.Point(88, 64);
            this.OtherDataDisplay.Multiline = true;
            this.OtherDataDisplay.Name = "OtherDataDisplay";
            this.OtherDataDisplay.ReadOnly = true;
            this.OtherDataDisplay.Size = new System.Drawing.Size(533, 75);
            this.OtherDataDisplay.TabIndex = 7;
            // 
            // AccessTokenLabel
            // 
            this.AccessTokenLabel.AutoSize = true;
            this.AccessTokenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccessTokenLabel.Location = new System.Drawing.Point(3, 35);
            this.AccessTokenLabel.Name = "AccessTokenLabel";
            this.AccessTokenLabel.Size = new System.Drawing.Size(79, 26);
            this.AccessTokenLabel.TabIndex = 0;
            this.AccessTokenLabel.Text = "Access Token:";
            this.AccessTokenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdentityTokenLabel
            // 
            this.IdentityTokenLabel.AutoSize = true;
            this.IdentityTokenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdentityTokenLabel.Location = new System.Drawing.Point(3, 61);
            this.IdentityTokenLabel.Name = "IdentityTokenLabel";
            this.IdentityTokenLabel.Size = new System.Drawing.Size(79, 81);
            this.IdentityTokenLabel.TabIndex = 0;
            this.IdentityTokenLabel.Text = "Other data:";
            this.IdentityTokenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccessTokenDisplay
            // 
            this.Inputs.SetColumnSpan(this.AccessTokenDisplay, 4);
            this.AccessTokenDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccessTokenDisplay.Location = new System.Drawing.Point(88, 38);
            this.AccessTokenDisplay.Name = "AccessTokenDisplay";
            this.AccessTokenDisplay.ReadOnly = true;
            this.AccessTokenDisplay.Size = new System.Drawing.Size(533, 20);
            this.AccessTokenDisplay.TabIndex = 6;
            // 
            // CallApiButton
            // 
            this.CallApiButton.Location = new System.Drawing.Point(287, 2);
            this.CallApiButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CallApiButton.Name = "CallApiButton";
            this.CallApiButton.Size = new System.Drawing.Size(76, 31);
            this.CallApiButton.TabIndex = 8;
            this.CallApiButton.Text = "Call API";
            this.CallApiButton.UseVisualStyleBackColor = true;
            this.CallApiButton.Click += new System.EventHandler(this.CallApiButton_Click);
            // 
            // TenantsListBox
            // 
            this.Inputs.SetColumnSpan(this.TenantsListBox, 3);
            this.TenantsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TenantsListBox.FormattingEnabled = true;
            this.TenantsListBox.IntegralHeight = false;
            this.TenantsListBox.Location = new System.Drawing.Point(88, 174);
            this.TenantsListBox.Name = "TenantsListBox";
            this.TenantsListBox.Size = new System.Drawing.Size(452, 264);
            this.TenantsListBox.TabIndex = 9;
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Location = new System.Drawing.Point(546, 174);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.Size = new System.Drawing.Size(75, 23);
            this.AuthorizeButton.TabIndex = 10;
            this.AuthorizeButton.Text = "Authorize";
            this.AuthorizeButton.UseVisualStyleBackColor = true;
            this.AuthorizeButton.Click += new System.EventHandler(this.AuthorizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Access Token:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdentityTokenDisplay
            // 
            this.Inputs.SetColumnSpan(this.IdentityTokenDisplay, 4);
            this.IdentityTokenDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdentityTokenDisplay.Location = new System.Drawing.Point(88, 145);
            this.IdentityTokenDisplay.Name = "IdentityTokenDisplay";
            this.IdentityTokenDisplay.ReadOnly = true;
            this.IdentityTokenDisplay.Size = new System.Drawing.Size(533, 20);
            this.IdentityTokenDisplay.TabIndex = 12;
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Inputs);
            this.Name = "SampleForm";
            this.Text = "SampleForm";
            this.Inputs.ResumeLayout(false);
            this.Inputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel Inputs;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.CheckBox Silent;
        private System.Windows.Forms.TextBox OtherDataDisplay;
        private System.Windows.Forms.Label AccessTokenLabel;
        private System.Windows.Forms.Label IdentityTokenLabel;
        private System.Windows.Forms.TextBox AccessTokenDisplay;
        private System.Windows.Forms.Button CallApiButton;
        private System.Windows.Forms.ListBox TenantsListBox;
        private System.Windows.Forms.Button AuthorizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdentityTokenDisplay;
    }
}