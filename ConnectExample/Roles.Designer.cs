namespace ConnectExample
{
    partial class Roles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbRolCrear = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRoleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.btnAsignRol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbRolCrear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateRole);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbRoleName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // clbRolCrear
            // 
            this.clbRolCrear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbRolCrear.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRolCrear.FormattingEnabled = true;
            this.clbRolCrear.Location = new System.Drawing.Point(14, 132);
            this.clbRolCrear.Name = "clbRolCrear";
            this.clbRolCrear.Size = new System.Drawing.Size(300, 142);
            this.clbRolCrear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Rol:";
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateRole.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRole.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRole.ForeColor = System.Drawing.Color.White;
            this.btnCreateRole.Location = new System.Drawing.Point(79, 288);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(169, 52);
            this.btnCreateRole.TabIndex = 2;
            this.btnCreateRole.Text = "Crear rol";
            this.btnCreateRole.UseVisualStyleBackColor = false;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Location = new System.Drawing.Point(14, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 31;
            // 
            // tbRoleName
            // 
            this.tbRoleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRoleName.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoleName.ForeColor = System.Drawing.Color.Black;
            this.tbRoleName.Location = new System.Drawing.Point(14, 54);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(300, 24);
            this.tbRoleName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(10, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre de rol:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbRoles);
            this.groupBox2.Controls.Add(this.btnAsignRol);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbUsers);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(370, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // clbRoles
            // 
            this.clbRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbRoles.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(16, 132);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(300, 142);
            this.clbRoles.TabIndex = 4;
            // 
            // btnAsignRol
            // 
            this.btnAsignRol.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAsignRol.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAsignRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignRol.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignRol.ForeColor = System.Drawing.Color.White;
            this.btnAsignRol.Location = new System.Drawing.Point(85, 288);
            this.btnAsignRol.Name = "btnAsignRol";
            this.btnAsignRol.Size = new System.Drawing.Size(169, 52);
            this.btnAsignRol.TabIndex = 5;
            this.btnAsignRol.Text = "Asignar rol";
            this.btnAsignRol.UseVisualStyleBackColor = false;
            this.btnAsignRol.Click += new System.EventHandler(this.btnAsignRol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Usuario:";
            // 
            // cbUsers
            // 
            this.cbUsers.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(16, 54);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(300, 29);
            this.cbUsers.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Location = new System.Drawing.Point(300, 424);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 44);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "<- Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(81, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 43);
            this.label2.TabIndex = 33;
            this.label2.Text = "Crear Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(426, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 43);
            this.label6.TabIndex = 34;
            this.label6.Text = "Asignar Rol";
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Roles";
            this.Text = "Roles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAsignRol;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbRoleName;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.CheckedListBox clbRolCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}