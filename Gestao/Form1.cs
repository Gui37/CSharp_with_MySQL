using MySql.Data.MySqlClient;
using System.Data;

namespace Gestao
{
    public partial class Form1 : Form
    {

        MySqlConnection conexao;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQl;
        string cs = @"server=localhost;username=root;password=1234568;database=gestao";

        

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
            MessageBox.Show("Dados invalidos, Tente novamente");
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void BtnUp_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(cs);
                strSQl = "UPDATE user SET nome=@nome, SET email=@email, SET username=@username," +
                    " SET password=@password, SET confpass=@confpass WHERE id = @id";
                cmd = new MySqlCommand(strSQl, conexao);
                cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
                cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                cmd.Parameters.AddWithValue("@username", TxtUser.Text);
                cmd.Parameters.AddWithValue("@password", TxtPass.Text);
                cmd.Parameters.AddWithValue("@confpass", TxtPassC.Text);

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

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}