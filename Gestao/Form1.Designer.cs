namespace Gestao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPassC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.TxtPassL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUserL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvD = new System.Windows.Forms.DataGridView();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(30, 29);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(140, 47);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegista
            // 
            this.buttonRegista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegista.Location = new System.Drawing.Point(204, 29);
            this.buttonRegista.Name = "buttonRegista";
            this.buttonRegista.Size = new System.Drawing.Size(140, 47);
            this.buttonRegista.TabIndex = 1;
            this.buttonRegista.Text = "Registar";
            this.buttonRegista.UseVisualStyleBackColor = true;
            this.buttonRegista.Click += new System.EventHandler(this.buttonRegista_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtPassC);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtUser);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 234);
            this.panel1.TabIndex = 2;
            // 
            // TxtPassC
            // 
            this.TxtPassC.Location = new System.Drawing.Point(127, 133);
            this.TxtPassC.MaxLength = 25;
            this.TxtPassC.Name = "TxtPassC";
            this.TxtPassC.PasswordChar = '-';
            this.TxtPassC.Size = new System.Drawing.Size(209, 23);
            this.TxtPassC.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirm Pass:";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(127, 74);
            this.TxtUser.MaxLength = 25;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(209, 23);
            this.TxtUser.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Username :";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(127, 103);
            this.TxtPass.MaxLength = 25;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '-';
            this.TxtPass.Size = new System.Drawing.Size(209, 23);
            this.TxtPass.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(22, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(314, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Registe";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(127, 44);
            this.TxtEmail.MaxLength = 25;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(209, 23);
            this.TxtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(127, 13);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(209, 23);
            this.TxtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.TxtPassL);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtUserL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 234);
            this.panel2.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(22, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(314, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Login";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxtPassL
            // 
            this.TxtPassL.Location = new System.Drawing.Point(127, 102);
            this.TxtPassL.MaxLength = 25;
            this.TxtPassL.Name = "TxtPassL";
            this.TxtPassL.PasswordChar = '-';
            this.TxtPassL.Size = new System.Drawing.Size(209, 23);
            this.TxtPassL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // TxtUserL
            // 
            this.TxtUserL.Location = new System.Drawing.Point(127, 57);
            this.TxtUserL.Name = "TxtUserL";
            this.TxtUserL.Size = new System.Drawing.Size(209, 23);
            this.TxtUserL.TabIndex = 1;
            this.TxtUserL.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username :";
            // 
            // DgvD
            // 
            this.DgvD.AllowUserToOrderColumns = true;
            this.DgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvD.Location = new System.Drawing.Point(395, 102);
            this.DgvD.Name = "DgvD";
            this.DgvD.RowHeadersWidth = 10;
            this.DgvD.RowTemplate.Height = 20;
            this.DgvD.Size = new System.Drawing.Size(520, 232);
            this.DgvD.TabIndex = 6;
            // 
            // BtnUp
            // 
            this.BtnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUp.Location = new System.Drawing.Point(395, 38);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(133, 47);
            this.BtnUp.TabIndex = 8;
            this.BtnUp.Text = "Actualizar";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCos.Location = new System.Drawing.Point(643, 38);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(133, 47);
            this.BtnCos.TabIndex = 5;
            this.BtnCos.Text = "Consultar";
            this.BtnCos.UseVisualStyleBackColor = true;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Location = new System.Drawing.Point(782, 38);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(133, 47);
            this.BtnDel.TabIndex = 10;
            this.BtnDel.Text = "Apagar";
            this.BtnDel.UseVisualStyleBackColor = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ConfPass";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 59;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Password";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Username";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 339);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.DgvD);
            this.Controls.Add(this.buttonRegista);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonLogin;
        private Button buttonRegista;
        private Panel panel1;
        private TextBox TxtNome;
        private Label label1;
        private TextBox TxtEmail;
        private Label label2;
        private Button button3;
        private TextBox TxtPassC;
        private Label label7;
        private TextBox TxtUser;
        private Panel panel2;
        private Button button4;
        private TextBox TxtPassL;
        private Label label3;
        private TextBox TxtUserL;
        private Label label4;
        private Label label6;
        private TextBox TxtPass;
        private Label label5;
        private DataGridView DgvD;
        private Button BtnUp;
        private Button BtnCos;
        private Button BtnDel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}