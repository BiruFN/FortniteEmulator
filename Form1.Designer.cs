namespace FortniteEmulator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GamePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.PathChoose = new Guna.UI2.WinForms.Guna2Button();
            this.Login = new Guna.UI2.WinForms.Guna2Button();
            this.ClientVersion = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClientVersionText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BattlEyeCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.EasyAntiCheatCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GamePath
            // 
            this.GamePath.BorderColor = System.Drawing.Color.Black;
            this.GamePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GamePath.DefaultText = "";
            this.GamePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GamePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GamePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GamePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GamePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GamePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePath.ForeColor = System.Drawing.Color.Black;
            this.GamePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GamePath.Location = new System.Drawing.Point(99, 341);
            this.GamePath.Name = "GamePath";
            this.GamePath.PasswordChar = '\0';
            this.GamePath.PlaceholderText = "";
            this.GamePath.ReadOnly = true;
            this.GamePath.SelectedText = "";
            this.GamePath.Size = new System.Drawing.Size(563, 31);
            this.GamePath.TabIndex = 0;
            // 
            // PathChoose
            // 
            this.PathChoose.BackColor = System.Drawing.SystemColors.Control;
            this.PathChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PathChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PathChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PathChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PathChoose.FillColor = System.Drawing.Color.Gray;
            this.PathChoose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PathChoose.ForeColor = System.Drawing.Color.White;
            this.PathChoose.Location = new System.Drawing.Point(668, 341);
            this.PathChoose.Name = "PathChoose";
            this.PathChoose.Size = new System.Drawing.Size(41, 31);
            this.PathChoose.TabIndex = 1;
            this.PathChoose.Text = "...";
            this.PathChoose.Click += new System.EventHandler(this.PathChoose_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.Control;
            this.Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login.FillColor = System.Drawing.Color.Gray;
            this.Login.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(12, 341);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(81, 31);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // ClientVersion
            // 
            this.ClientVersion.BorderColor = System.Drawing.Color.Black;
            this.ClientVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientVersion.DefaultText = "";
            this.ClientVersion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientVersion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientVersion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientVersion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientVersion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientVersion.ForeColor = System.Drawing.Color.Black;
            this.ClientVersion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientVersion.Location = new System.Drawing.Point(426, 304);
            this.ClientVersion.Name = "ClientVersion";
            this.ClientVersion.PasswordChar = '\0';
            this.ClientVersion.PlaceholderText = "";
            this.ClientVersion.SelectedText = "";
            this.ClientVersion.Size = new System.Drawing.Size(151, 31);
            this.ClientVersion.TabIndex = 3;
            // 
            // ClientVersionText
            // 
            this.ClientVersionText.AutoSize = true;
            this.ClientVersionText.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClientVersionText.Location = new System.Drawing.Point(360, 310);
            this.ClientVersionText.Name = "ClientVersionText";
            this.ClientVersionText.Size = new System.Drawing.Size(60, 17);
            this.ClientVersionText.TabIndex = 4;
            this.ClientVersionText.Text = "Version:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BattlEyeCheck
            // 
            this.BattlEyeCheck.AutoSize = true;
            this.BattlEyeCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BattlEyeCheck.CheckedState.BorderRadius = 0;
            this.BattlEyeCheck.CheckedState.BorderThickness = 0;
            this.BattlEyeCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BattlEyeCheck.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.BattlEyeCheck.Location = new System.Drawing.Point(600, 302);
            this.BattlEyeCheck.Name = "BattlEyeCheck";
            this.BattlEyeCheck.Size = new System.Drawing.Size(75, 19);
            this.BattlEyeCheck.TabIndex = 7;
            this.BattlEyeCheck.Text = "BattlEye";
            this.BattlEyeCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BattlEyeCheck.UncheckedState.BorderRadius = 0;
            this.BattlEyeCheck.UncheckedState.BorderThickness = 0;
            this.BattlEyeCheck.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.BattlEyeCheck.CheckedChanged += new System.EventHandler(this.BattlEyeCheck_CheckedChanged);
            // 
            // EasyAntiCheatCheck
            // 
            this.EasyAntiCheatCheck.AutoSize = true;
            this.EasyAntiCheatCheck.Checked = true;
            this.EasyAntiCheatCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EasyAntiCheatCheck.CheckedState.BorderRadius = 0;
            this.EasyAntiCheatCheck.CheckedState.BorderThickness = 0;
            this.EasyAntiCheatCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EasyAntiCheatCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EasyAntiCheatCheck.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.EasyAntiCheatCheck.Location = new System.Drawing.Point(600, 320);
            this.EasyAntiCheatCheck.Name = "EasyAntiCheatCheck";
            this.EasyAntiCheatCheck.Size = new System.Drawing.Size(110, 19);
            this.EasyAntiCheatCheck.TabIndex = 8;
            this.EasyAntiCheatCheck.Text = "EasyAntiCheat";
            this.EasyAntiCheatCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EasyAntiCheatCheck.UncheckedState.BorderRadius = 0;
            this.EasyAntiCheatCheck.UncheckedState.BorderThickness = 0;
            this.EasyAntiCheatCheck.UncheckedState.FillColor = System.Drawing.Color.Gray;
            this.EasyAntiCheatCheck.CheckedChanged += new System.EventHandler(this.EasyAntiCheatCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(15, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Logged In:";
            // 
            // displayName
            // 
            this.displayName.BorderColor = System.Drawing.Color.Black;
            this.displayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.displayName.DefaultText = "";
            this.displayName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.displayName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.displayName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.displayName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.displayName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.displayName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayName.ForeColor = System.Drawing.Color.Black;
            this.displayName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.displayName.Location = new System.Drawing.Point(99, 305);
            this.displayName.Name = "displayName";
            this.displayName.PasswordChar = '\0';
            this.displayName.PlaceholderText = "";
            this.displayName.ReadOnly = true;
            this.displayName.SelectedText = "";
            this.displayName.Size = new System.Drawing.Size(241, 31);
            this.displayName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.EasyAntiCheatCheck);
            this.Controls.Add(this.BattlEyeCheck);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClientVersionText);
            this.Controls.Add(this.ClientVersion);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PathChoose);
            this.Controls.Add(this.GamePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FortniteEmulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox GamePath;
        private Guna.UI2.WinForms.Guna2Button PathChoose;
        private Guna.UI2.WinForms.Guna2Button Login;
        private Guna.UI2.WinForms.Guna2TextBox ClientVersion;
        private System.Windows.Forms.Label ClientVersionText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox BattlEyeCheck;
        private Guna.UI2.WinForms.Guna2CheckBox EasyAntiCheatCheck;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox displayName;
    }
}

