﻿namespace Gestao
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(12, 15);
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
            this.buttonRegista.Location = new System.Drawing.Point(201, 15);
            this.buttonRegista.Name = "buttonRegista";
            this.buttonRegista.Size = new System.Drawing.Size(140, 47);
            this.buttonRegista.TabIndex = 0;
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
            this.TxtPassC.Location = new System.Drawing.Point(124, 140);
            this.TxtPassC.MaxLength = 25;
            this.TxtPassC.Name = "TxtPassC";
            this.TxtPassC.PasswordChar = '-';
            this.TxtPassC.Size = new System.Drawing.Size(209, 23);
            this.TxtPassC.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirm Pass:";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(124, 75);
            this.TxtUser.MaxLength = 25;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(209, 23);
            this.TxtUser.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Username :";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(124, 107);
            this.TxtPass.MaxLength = 25;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '-';
            this.TxtPass.Size = new System.Drawing.Size(209, 23);
            this.TxtPass.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 110);
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
            this.button3.TabIndex = 5;
            this.button3.Text = "Registe";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(124, 42);
            this.TxtEmail.MaxLength = 60;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(209, 23);
            this.TxtEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(124, 8);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(209, 23);
            this.TxtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 11);
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
            this.DgvD.AllowUserToAddRows = false;
            this.DgvD.AllowUserToDeleteRows = false;
            this.DgvD.AllowUserToResizeRows = false;
            this.DgvD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvD.Location = new System.Drawing.Point(365, 79);
            this.DgvD.MultiSelect = false;
            this.DgvD.Name = "DgvD";
            this.DgvD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DgvD.RowTemplate.Height = 20;
            this.DgvD.Size = new System.Drawing.Size(610, 255);
            this.DgvD.TabIndex = 9;
            this.DgvD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvD_CellClick);
            // 
            // BtnUp
            // 
            this.BtnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUp.Location = new System.Drawing.Point(365, 15);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(133, 47);
            this.BtnUp.TabIndex = 6;
            this.BtnUp.Text = "Actualizar";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCos.Location = new System.Drawing.Point(529, 15);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(133, 47);
            this.BtnCos.TabIndex = 7;
            this.BtnCos.Text = "Consultar";
            this.BtnCos.UseVisualStyleBackColor = true;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Location = new System.Drawing.Point(686, 15);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(133, 47);
            this.BtnDel.TabIndex = 8;
            this.BtnDel.Text = "Apagar";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(842, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(987, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.DgvD);
            this.Controls.Add(this.buttonRegista);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Button button1;
    }
}