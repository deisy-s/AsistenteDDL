namespace ConnectExample
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
            this.cbBD = new System.Windows.Forms.ComboBox();
            this.cbTablas = new System.Windows.Forms.ComboBox();
            this.dgvTablaInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnCreateField = new System.Windows.Forms.Button();
            this.btnDeleteField = new System.Windows.Forms.Button();
            this.btnResetDGV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbViews = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDBQry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBD
            // 
            this.cbBD.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBD.FormattingEnabled = true;
            this.cbBD.Location = new System.Drawing.Point(340, 27);
            this.cbBD.Name = "cbBD";
            this.cbBD.Size = new System.Drawing.Size(288, 29);
            this.cbBD.TabIndex = 1;
            this.cbBD.Text = "Bases de Datos";
            this.cbBD.SelectedIndexChanged += new System.EventHandler(this.cbBD_SelectedIndexChanged);
            // 
            // cbTablas
            // 
            this.cbTablas.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Location = new System.Drawing.Point(340, 82);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(288, 29);
            this.cbTablas.TabIndex = 2;
            this.cbTablas.Text = "Tablas";
            this.cbTablas.SelectedIndexChanged += new System.EventHandler(this.cbTablas_SelectedIndexChanged);
            // 
            // dgvTablaInfo
            // 
            this.dgvTablaInfo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTablaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dgvTablaInfo.Location = new System.Drawing.Point(9, 188);
            this.dgvTablaInfo.Name = "dgvTablaInfo";
            this.dgvTablaInfo.RowHeadersWidth = 62;
            this.dgvTablaInfo.RowTemplate.Height = 28;
            this.dgvTablaInfo.Size = new System.Drawing.Size(780, 288);
            this.dgvTablaInfo.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Campo";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TDato";
            this.Column2.Items.AddRange(new object[] {
            "bigint",
            "binary",
            "bit",
            "char",
            "date",
            "datetime",
            "datetimeoffset",
            "decimal",
            "float",
            "image",
            "int",
            "nchar",
            "ntext",
            "numeric",
            "nvarchar",
            "money",
            "real",
            "smalldatetime",
            "smallint",
            "smallmoney",
            "text",
            "time",
            "tinyint",
            "varbinary",
            "varchar"});
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Longitud";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nulos";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Constraint";
            this.Column4.Items.AddRange(new object[] {
            "PRIMARY KEY",
            "UNIQUE"});
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 150;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(24)))), ((int)(((byte)(126)))));
            this.btnCreateTable.FlatAppearance.BorderSize = 0;
            this.btnCreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTable.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTable.ForeColor = System.Drawing.Color.White;
            this.btnCreateTable.Location = new System.Drawing.Point(9, 505);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(151, 37);
            this.btnCreateTable.TabIndex = 5;
            this.btnCreateTable.Text = "Crear Tabla";
            this.btnCreateTable.UseVisualStyleBackColor = false;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnCreateField
            // 
            this.btnCreateField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(24)))), ((int)(((byte)(126)))));
            this.btnCreateField.FlatAppearance.BorderSize = 0;
            this.btnCreateField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateField.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateField.ForeColor = System.Drawing.Color.White;
            this.btnCreateField.Location = new System.Drawing.Point(218, 505);
            this.btnCreateField.Name = "btnCreateField";
            this.btnCreateField.Size = new System.Drawing.Size(151, 37);
            this.btnCreateField.TabIndex = 6;
            this.btnCreateField.Text = "Crear Campo";
            this.btnCreateField.UseVisualStyleBackColor = false;
            this.btnCreateField.Click += new System.EventHandler(this.btnCreateField_Click);
            // 
            // btnDeleteField
            // 
            this.btnDeleteField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(24)))), ((int)(((byte)(126)))));
            this.btnDeleteField.FlatAppearance.BorderSize = 0;
            this.btnDeleteField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteField.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteField.ForeColor = System.Drawing.Color.White;
            this.btnDeleteField.Location = new System.Drawing.Point(427, 493);
            this.btnDeleteField.Name = "btnDeleteField";
            this.btnDeleteField.Size = new System.Drawing.Size(151, 62);
            this.btnDeleteField.TabIndex = 7;
            this.btnDeleteField.Text = "Eliminar Campo";
            this.btnDeleteField.UseVisualStyleBackColor = false;
            this.btnDeleteField.Click += new System.EventHandler(this.btnDeleteField_Click);
            // 
            // btnResetDGV
            // 
            this.btnResetDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(24)))), ((int)(((byte)(126)))));
            this.btnResetDGV.FlatAppearance.BorderSize = 0;
            this.btnResetDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDGV.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDGV.ForeColor = System.Drawing.Color.White;
            this.btnResetDGV.Location = new System.Drawing.Point(638, 493);
            this.btnResetDGV.Name = "btnResetDGV";
            this.btnResetDGV.Size = new System.Drawing.Size(151, 62);
            this.btnResetDGV.TabIndex = 8;
            this.btnResetDGV.Text = "Reset DataGridView";
            this.btnResetDGV.UseVisualStyleBackColor = false;
            this.btnResetDGV.Click += new System.EventHandler(this.btnResetDGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(143, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Seleccionar BDs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(143, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Seleccionar Tabla:";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Location = new System.Drawing.Point(336, 568);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 44);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "<- Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(143, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Seleccionar Vista:";
            // 
            // cbViews
            // 
            this.cbViews.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViews.FormattingEnabled = true;
            this.cbViews.Location = new System.Drawing.Point(340, 138);
            this.cbViews.Name = "cbViews";
            this.cbViews.Size = new System.Drawing.Size(288, 29);
            this.cbViews.TabIndex = 3;
            this.cbViews.Text = "Vistas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(798, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 630);
            this.panel1.TabIndex = 32;
            // 
            // tbQuery
            // 
            this.tbQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuery.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuery.Location = new System.Drawing.Point(809, 105);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(513, 191);
            this.tbQuery.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(805, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ingresar Query:";
            // 
            // dgvResults
            // 
            this.dgvResults.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(809, 388);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.RowTemplate.Height = 28;
            this.dgvResults.Size = new System.Drawing.Size(513, 230);
            this.dgvResults.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(805, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Resultados:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(24)))), ((int)(((byte)(126)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(986, 302);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(151, 37);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Enviar query";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(805, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 42);
            this.label6.TabIndex = 38;
            this.label6.Text = "Seleccionar BDs\r\ndel Query:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbDBQry
            // 
            this.cbDBQry.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDBQry.FormattingEnabled = true;
            this.cbDBQry.Location = new System.Drawing.Point(1001, 28);
            this.cbDBQry.Name = "cbDBQry";
            this.cbDBQry.Size = new System.Drawing.Size(288, 29);
            this.cbDBQry.TabIndex = 9;
            this.cbDBQry.Text = "Bases de Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 626);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDBQry);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbViews);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetDGV);
            this.Controls.Add(this.btnDeleteField);
            this.Controls.Add(this.btnCreateField);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.dgvTablaInfo);
            this.Controls.Add(this.cbTablas);
            this.Controls.Add(this.cbBD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Asistente DDL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBD;
        private System.Windows.Forms.ComboBox cbTablas;
        private System.Windows.Forms.DataGridView dgvTablaInfo;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnCreateField;
        private System.Windows.Forms.Button btnDeleteField;
        private System.Windows.Forms.Button btnResetDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbViews;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDBQry;
    }
}

