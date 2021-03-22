using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranQuangTruong_5951071114
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }
        public static SqlConnection HamKetNoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-8MK2IUGC;Initial Catalog=DemoCRUD;User ID=sa; Password=123456");
            return con;
        }
        private DataTable GetStudentsRecord()
        {
            SqlConnection con = HamKetNoi();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM StudentsTb", con);
            DataTable dt = new DataTable();            
            adapter.Fill(dt);
            con.Close();
            dgvsv.DataSource = dt;
            return dt;
        }
        private bool IsValidData()
        {
            if (txtten.Text == string.Empty || txtho.Text == string.Empty || txtdiachi.Text == string.Empty || string.IsNullOrEmpty(txtsdt.Text) || string.IsNullOrEmpty(txtsbd.Text))
            {
                MessageBox.Show("Có chỗ chưa nhập dữ liệu!!!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SqlConnection con = HamKetNoi();
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO StudentsTb VALUES " +
                    "(@name, @fathername, @rollnumber, @address, @mobile)", con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@name", txtho.Text);
                command.Parameters.AddWithValue("@fathername", txtten.Text);
                command.Parameters.AddWithValue("@rollnumber", txtsbd.Text);
                command.Parameters.AddWithValue("@address", txtdiachi.Text);
                command.Parameters.AddWithValue("@mobile", txtsdt.Text);
                command.ExecuteNonQuery();
                con.Close();
                GetStudentsRecord();
            }            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void dgvsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvsv.Rows[e.RowIndex];
                StudentID = int.Parse(row.Cells[0].Value.ToString());
                txtho.Text = row.Cells[1].Value.ToString();
                txtten.Text = row.Cells[2].Value.ToString();
                txtsbd.Text = row.Cells[3].Value.ToString();
                txtdiachi.Text = row.Cells[4].Value.ToString();
                txtsdt.Text = row.Cells[5].Value.ToString();
            }     
        }
        public int StudentID ;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = HamKetNoi();
            con.Open();
            if (StudentID > 0)
            {
                SqlCommand command = new SqlCommand("UPDATE StudentsTb SET " +
                    "name=@name, fathername=@fathername, rollnumber=@rollnumber, address=@address, mobile=@mobile WHERE StudentID = @id", con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@name", txtho.Text);
                command.Parameters.AddWithValue("@fathername", txtten.Text);
                command.Parameters.AddWithValue("@rollnumber", txtsbd.Text);
                command.Parameters.AddWithValue("@address", txtdiachi.Text);
                command.Parameters.AddWithValue("@mobile", txtsdt.Text);
                command.Parameters.AddWithValue("@id", this.StudentID);
                command.ExecuteNonQuery();
                con.Close();
                GetStudentsRecord();
            }
            else
            {
                MessageBox.Show("Cập nhật bị lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = HamKetNoi();
            con.Open();
            if (StudentID > 0)
            {
                SqlCommand command = new SqlCommand("DELETE FROM StudentsTB WHERE StudentID = @id", con);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@id", this.StudentID);
                command.ExecuteNonQuery();
                con.Close();
                GetStudentsRecord();
            }
            else
            {
                MessageBox.Show("Cập nhật bị lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
