using MySql.Data.MySqlClient;
using System.Data;

namespace Gestao
{
    public partial class Form1 : Form
    {
        private string? pos;
        private string? nome;
        private string? email;
        private string? username;
        private string? password;
        private string? confPass;

        MySqlConnection? conexao;
        MySqlCommand? cmd;
        MySqlDataAdapter? da;
        private string? strSQl;
        private string? cs = @"server=localhost;username=root;password=1234568;database=gestao";

        

        public Form1()
        {
            InitializeComponent();
        }
       

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void buttonRegista_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(cs);
                strSQl = "SELECT * FROM user where username=@username and password =@password";
                cmd = new MySqlCommand(strSQl, conexao);
                cmd.Parameters.AddWithValue("@username", TxtUserL.Text);
                cmd.Parameters.AddWithValue("@password", TxtPassL.Text);
                conexao.Open();

                cmd.ExecuteNonQuery() ;
                DataTable dataTable = new();
                MySqlDataAdapter aba = new (cmd);
                aba.FillAsync(dataTable);
                var i = Convert.ToInt16(dataTable.Rows.Count.ToString());
                if (i>0)
                {
                    
                    MessageBox.Show("Login efectuado com sucesso");
                }
                else
                {
                    MessageBox.Show("Usuario nao encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtPass.Text == TxtPassC.Text)
            {
                try
                {
                    conexao = new MySqlConnection(cs);
                    strSQl = "INSERT INTO user (nome, email, username, password, confpass)" +
                        " VALUES (@nome, @email, @username, @password, @confpass) ";
                    cmd = new MySqlCommand(strSQl, conexao);
                    cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@username", TxtUser.Text);
                    cmd.Parameters.AddWithValue("@password", TxtPass.Text);
                    cmd.Parameters.AddWithValue("@confpass", TxtPassC.Text);

                    conexao.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário Registado com suceesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNome.Clear();
                    TxtEmail.Clear();
                    TxtUser.Clear();
                    TxtPass.Clear();
                    TxtPassC.Clear();
                    BtnCos_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    conexao.Close();
                }
            } else
            {
                MessageBox.Show("Por favor verifique as informações adicionadas","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        private void BtnCos_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(cs);
                strSQl = "SELECT * FROM user";
                da = new MySqlDataAdapter(strSQl, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvD.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(cs);
                strSQl = "DELETE FROM user WHERE id = @id";
                cmd = new MySqlCommand(strSQl, conexao);
                cmd.Parameters.AddWithValue("@id", pos);

                
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                BtnCos_Click(sender, e);
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(cs);
                strSQl = "UPDATE user SET nome=@nome, email=@email, username=@username, password=@password, confpass=@confpass WHERE id=@id";
                cmd = new MySqlCommand(strSQl, conexao);
                cmd.Parameters.AddWithValue("@id", pos);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@confpass", confPass);

                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                BtnCos_Click(sender, e);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnCos_Click(sender, e);
        }

        private void DgvD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = DgvD.Rows[e.RowIndex];
                pos = row.Cells["id"].Value.ToString();
                nome = row.Cells["nome"].Value.ToString();
                email = row.Cells["email"].Value.ToString();
                username = row.Cells["username"].Value.ToString();
                password = row.Cells["password"].Value.ToString();
                confPass = row.Cells["confpass"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}