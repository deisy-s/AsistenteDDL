namespace ConnectExample
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.llSignUp = new System.Windows.Forms.LinkLabel();
            this.btnRoles = new System.Windows.Forms.Button();
            this.pbAnimation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(51, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(51, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuario:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumBlue;
            this.panel2.Location = new System.Drawing.Point(55, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 1);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Location = new System.Drawing.Point(55, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 1);
            this.panel1.TabIndex = 16;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(77, 478);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(227, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPassword.Location = new System.Drawing.Point(147, 433);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(193, 25);
            this.cbPassword.TabIndex = 3;
            this.cbPassword.Text = "Mostrar contraseña";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(55, 397);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(277, 24);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // tbUser
            // 
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.Black;
            this.tbUser.Location = new System.Drawing.Point(55, 311);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(277, 24);
            this.tbUser.TabIndex = 1;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            // 
            // llSignUp
            // 
            this.llSignUp.AutoSize = true;
            this.llSignUp.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSignUp.LinkColor = System.Drawing.Color.MidnightBlue;
            this.llSignUp.Location = new System.Drawing.Point(86, 590);
            this.llSignUp.Name = "llSignUp";
            this.llSignUp.Size = new System.Drawing.Size(209, 21);
            this.llSignUp.TabIndex = 6;
            this.llSignUp.TabStop = true;
            this.llSignUp.Text = "¿No cuenta con usuario?";
            this.llSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSignUp_LinkClicked);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRoles.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoles.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Location = new System.Drawing.Point(77, 533);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(227, 45);
            this.btnRoles.TabIndex = 5;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // pbAnimation
            // 
            this.pbAnimation.Image = global::ConnectExample.Properties.Resources.debut;
            this.pbAnimation.Location = new System.Drawing.Point(84, 24);
            this.pbAnimation.Name = "pbAnimation";
            this.pbAnimation.Size = new System.Drawing.Size(220, 220);
            this.pbAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimation.TabIndex = 23;
            this.pbAnimation.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 626);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.llSignUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbAnimation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbAnimation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.LinkLabel llSignUp;
        private System.Windows.Forms.Button btnRoles;
    }
}