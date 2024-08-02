namespace PRL.Forms
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbt_Username = new System.Windows.Forms.TextBox();
            this.tbt_Password = new System.Windows.Forms.TextBox();
            this.cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbt_Username
            // 
            this.tbt_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Username.Location = new System.Drawing.Point(142, 28);
            this.tbt_Username.Name = "tbt_Username";
            this.tbt_Username.Size = new System.Drawing.Size(709, 34);
            this.tbt_Username.TabIndex = 2;
            // 
            // tbt_Password
            // 
            this.tbt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Password.Location = new System.Drawing.Point(143, 87);
            this.tbt_Password.Name = "tbt_Password";
            this.tbt_Password.Size = new System.Drawing.Size(708, 34);
            this.tbt_Password.TabIndex = 3;
            // 
            // cb_ShowPass
            // 
            this.cb_ShowPass.AutoSize = true;
            this.cb_ShowPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_ShowPass.Location = new System.Drawing.Point(142, 164);
            this.cb_ShowPass.Name = "cb_ShowPass";
            this.cb_ShowPass.Size = new System.Drawing.Size(205, 32);
            this.cb_ShowPass.TabIndex = 4;
            this.cb_ShowPass.Text = "Hiển thị mật khẩu";
            this.cb_ShowPass.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(142, 219);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(237, 56);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 299);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.cb_ShowPass);
            this.Controls.Add(this.tbt_Password);
            this.Controls.Add(this.tbt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbt_Username;
        private TextBox tbt_Password;
        private CheckBox cb_ShowPass;
        private Button btn_Login;
    }
}