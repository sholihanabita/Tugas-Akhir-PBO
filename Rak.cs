using Microsoft.VisualBasic.Devices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terakhir
{
    public partial class Rak : Form
    {
        private string id = "";
        private int intRow = 0;
        public Rak()
        {
            InitializeComponent();
            resetMe();
        }
        private void resetMe()
        {
            this.id = string.Empty;

            noraktextBox1.Text = "";
            tglmasuktextBox2.Text = "";
            tglkeluartextBox3.Text = "";

            updatebutton2.Text = "Update";
            deletebutton3.Text = "Delete";

        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            muatData("");
        }

        private void muatData(string keyword)
        {
            CRUD.sql = "SELECT id_rak, nomor_rak, tanggal_masuk, tanggal_keluar FROM datarak";

            string strKeyword = string.Format("%{0}", keyword);

            CRUD.cmd = new NpgsqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("keyword", strKeyword);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }

            DataGridView dgv2 = gvrak;

            dgv2.MultiSelect = false;
            dgv2.AutoGenerateColumns = true;
            dgv2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv2.DataSource = dt;

            dgv2.Columns[0].HeaderText = "ID Rak";
            dgv2.Columns[1].HeaderText = "Nomor Rak";
            dgv2.Columns[2].HeaderText = "Tanggal Masuk";
            dgv2.Columns[3].HeaderText = "Tanggal Keluar";
            
            dgv2.Columns[0].Width = 80;
            dgv2.Columns[1].Width = 100;
            dgv2.Columns[2].Width = 200;
            dgv2.Columns[3].Width = 200;

            
        }

        private void execute(string mySQL, string param)
        {
            CRUD.cmd = new NpgsqlCommand(mySQL, CRUD.con);
            addParameters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }
        private void addParameters(string str)
        {
            CRUD.cmd.Parameters.Clear();

            CRUD.cmd.Parameters.AddWithValue("nomor_rak", noraktextBox1.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("tanggal_masuk", tglmasuktextBox2.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("tanggal_keluar", tglkeluartextBox3.Text.Trim());
            

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }

        }

        private void insertbutton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(noraktextBox1.Text.Trim()) || string.IsNullOrEmpty(tglmasuktextBox2.Text.Trim()))
            {
                MessageBox.Show("Lengkapi data yang kosong", "Insert Data:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CRUD.sql = "INSERT INTO datarak (nomor_rak, tanggal_masuk, tanggal_keluar) VALUES (@nomor_rak, @tanggal_masuk, @tanggal_keluar)";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("Data Telah Berhasil Ditambahkan", "Insert Data:", MessageBoxButtons.OK);

            muatData("");

            resetMe();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = gvrak;
                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                updatebutton2.Text = "UPDATE";
                deletebutton3.Text = "DELETE";

                noraktextBox1.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                tglmasuktextBox2.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                tglkeluartextBox3.Text = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                
            }
        }

        private void updatebutton2_Click(object sender, EventArgs e)
        {
            if (gvrak.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Pilih data yang Akan Diubah", "Update Data:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(string.IsNullOrEmpty(noraktextBox1.Text.Trim()) || string.IsNullOrEmpty(tglmasuktextBox2.Text.Trim()))
            {
                MessageBox.Show("Lengkapi data yang kosong!", "Update Data:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CRUD.sql = "UPDATE datarak SET nomor_rak = @nomor_rak, tanggal_masuk = @tanggal_masuk, tanggal_keluar = @tanggal_keluar";

            execute(CRUD.sql, "Update");

            MessageBox.Show("Data Telah Berhasil Diubah", "Insert Data:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            muatData("");
            resetMe();

        }

        private void deletebutton3_Click(object sender, EventArgs e)
        {
            if (gvrak.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Pilih Data yang Akan Dihapus", "Hapus Data:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Jadi menghapus data nichh?", "Hapus Data:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) 
            {

                CRUD.sql = "DELETE FROM datarak WHERE id_rak = @id :: integer";

                execute(CRUD.sql, "Delete");

                MessageBox.Show("Data Telah Berhasil Dihapus", "Hapus Data:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                muatData("");
                resetMe();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Hide();
            Form2 form2 = new Form2();
            form2.Enabled = true;

            form2.ShowDialog();
        }
    }
    
}
