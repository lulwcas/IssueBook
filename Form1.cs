using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IssueBook
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection = con new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-E4UJ6RE\\SQLEXPRESS; database = library;integrated security=True";
            SqlCommand = cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from NewBook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text != "") ;
            {
                String eid = txtEnrollment.Text;
                SqlConnection = con new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-E4UJ6RE\\SQLEXPRESS; database = library;integrated security=True";
                SqlCommand = cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll = '" + eid + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                // quantos livros foram emitidos no N da matricula

                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll = '" + eid + "' and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());

                // ---------------------

                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDep.Clear();
                    txtSem.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Numero de matrícula invalido", "Erro" MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBoxBooks.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = txtEnrollment.Text;
                    String sname = txtName.Text;
                    String sdep = txtDep.Text;
                    String sem = txtDep.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String bookname = ComboBoxBooks.Text;
                    String bookIssueDate = DateTimePicker.Text;

                    String eid = txtEnrollment.Text;
                    SqlConnection = con new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-E4UJ6RE\\SQLEXPRESS; database = library;integrated security=True";
                    SqlCommand = cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values('" + enroll + "', '" + sname + "', '" + sdep + "', '" + sem + "', " + contact + ", '" + email + "', '" + bookname + "', '" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Close();

                    MessageBox.Show("Livro emitido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Livro já escolhido, OU número máximo de livros emitidos já foi atingido", "Livro não Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Insira um numero de matrícula válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollment.Text == "")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}