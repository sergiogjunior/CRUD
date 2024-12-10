namespace INSERT_com_C_;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using System.Data;


public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {



    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        string Sql;
        int RowAffect = 0;

        MySqlConnection conexao = new MySqlConnection("Server = localhost; database = Cadastro; User ID = root; Password= ;");

        MySqlCommand comando = new MySqlCommand();

        Sql = "INSERT INTO Clientes (nome , cpf , rg , dtNascimento , telefone , Sexo) VALUES ('" + txtNome.Text + "','" + mtbCpf.Text + "','"
            + mtbRg.Text + "','" + mtbDtNascimento.Text + "','" + mtbTelefone.Text + "','" + cbbSexo.Text + "') ";

        conexao.Open();

        comando.Connection = conexao;
        comando.CommandText = Sql;

        RowAffect = comando.ExecuteNonQuery();

        if (RowAffect == 1)
        {
            MessageBox.Show("Cadastro Realizado com Sucesso! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Text = "";
            mtbCpf.Text = "";
            mtbRg.Text = "";
            mtbDtNascimento.Text = "";
            mtbTelefone.Text = "";
            cbbSexo.Text = "";
            txtNome.Focus();
        }
        else
        {
            MessageBox.Show("Cadastro Não Realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
        string cpf = "";
        string sql;

        MySqlConnection conexao = new MySqlConnection("Server = localhost ; database = Cadastro; User ID = root; Password= ;");
        MySqlCommand comando = new MySqlCommand();

        MySqlDataReader dr;

        sql = "INSERT INTO Clientes (nome , cpf , rg , dtNascimento , telefone , Sexo) VALUES ('" + txtNome.Text + "','" + mtbCpf.Text + "','"
            + mtbRg.Text + "','" + mtbDtNascimento.Text + "','" + mtbTelefone.Text + "','" + cbbSexo.Text + "') "; conexao.Open();
        comando.Connection = conexao;
        comando.CommandText = sql;
        dr = comando.ExecuteReader();

        while (dr.Read())
        {
            cpf = dr.GetString(0);
        };

        if (cpf.ToString() == "")
        {
            MessageBox.Show("Nenhum Resultado Encontrado , Deseja Cadastrar ?", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mtbCpf.Clear();
            txtNome.Focus();
        }
        else
        {
            lstUsuario.Visible = true;
            lstUsuario.Items.Add(dr["Nome"].ToString());
            lstUsuario.Items.Add(dr["CPF"].ToString());
            lstUsuario.Items.Add(dr["RG"].ToString());
            lstUsuario.Items.Add(dr["dtNascimento"].ToString());
            lstUsuario.Items.Add(dr["Telefone"].ToString());
            lstUsuario.Items.Add(dr["Sexo"].ToString());
            
        }
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnAtualizar_Click(object sender, EventArgs e)
    {

    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        string SQL;
        int ROWAFFECT = 0;

        MySqlConnection conexao = new MySqlConnection("Server = localhost; database = Cadastro; User ID = root; Password= ;");

        MySqlCommand comando = new MySqlCommand();

        SQL = "DELETE FROM Clientes WHERE Cpf  = " + "'" + mtbCpf.Text + "'";

        conexao.Open();
        comando.Connection = conexao;
        comando.CommandText = SQL;

        ROWAFFECT = comando.ExecuteNonQuery();

        if (ROWAFFECT == 1)
        {
            MessageBox.Show("Cadastro Excluido", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mtbCpf.Text = "";
            txtNome.Focus();

        }

        else
        {
            MessageBox.Show("Erro ao excluir cadastro");
        }
    }
}
