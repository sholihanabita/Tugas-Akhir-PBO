using Npgsql;
using System.Data;

namespace terakhir
{
    public partial class Form1 : Form
    {
        private string id = "";
        private int intRow = 0;
        public Form1()
        {
            InitializeComponent();
            resetMe();
        }
        private void resetMe()
        {
            this.id = string.Empty;

            NamaKopitextBox1.Text = "";
            JenisKopitextBox1.Text = "";
            bentukkopitextBox1.Text = "";
            BerattextBox2.Text = "";
            hargatextBox3.Text = "";
            stoktextBox4.Text = "";

            updatebuttonbutton2.Text = "Update";
            deletebuttonbutton3.Text = "Delete";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData("");
        }
        private void loadData(string keyword)
        {
            CRUD.sql = "SELECT id_kopi, nama_kopi, jenis_kopi, bentuk_kopi, berat, harga, stok FROM datakopi";

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

            DataGridView dgv1 = dataGridView1;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID Kopi";
            dgv1.Columns[1].HeaderText = "Nama Kopi";
            dgv1.Columns[2].HeaderText = "Jenis Kopi";
            dgv1.Columns[3].HeaderText = "Bentuk Kopi";
            dgv1.Columns[4].HeaderText = "Berat";
            dgv1.Columns[5].HeaderText = "Harga";
            dgv1.Columns[6].HeaderText = "Stok";

            dgv1.Columns[0].Width = 80;
            dgv1.Columns[1].Width = 200;
            dgv1.Columns[2].Width = 160;
            dgv1.Columns[3].Width = 160;
            dgv1.Columns[4].Width = 110;
            dgv1.Columns[5].Width = 110;
            dgv1.Columns[6].Width = 110;

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

            CRUD.cmd.Parameters.AddWithValue("nama_kopi", NamaKopitextBox1.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("jenis_kopi", JenisKopitextBox1.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("bentuk_kopi", bentukkopitextBox1.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("berat", BerattextBox2.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("harga", hargatextBox3.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("stok", stoktextBox4.Text.Trim());

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.id);
            }
        }

        private void insertbutton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NamaKopitextBox1.Text.Trim()) || string.IsNullOrEmpty(JenisKopitextBox1.Text.Trim()))
            {
                MessageBox.Show("Lengkapi data yang kosong", "Insert Data:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CRUD.sql = "INSERT INTO datakopi (nama_kopi, jenis_kopi, bentuk_kopi, berat, harga, stok) VALUES (@nama_kopi, @jenis_kopi, @bentuk_kopi, @berat, @harga, @stok)";

            execute(CRUD.sql, "Insert");

            MessageBox.Show("Data Telah Berhasil Ditambahkan", "Insert Data:", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");

            resetMe();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView1;
                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                updatebuttonbutton2.Text = "UPDATE";
                deletebuttonbutton3.Text = "DELETE";

                NamaKopitextBox1.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                JenisKopitextBox1.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                bentukkopitextBox1.Text = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                BerattextBox2.Text = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                hargatextBox3.Text = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);
                stoktextBox4.Text = Convert.ToString(dgv1.CurrentRow.Cells[6].Value);

            }
        }
        private void updatebuttonbutton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Pilih Data yang Akan Diubah", "Update Data:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(NamaKopitextBox1.Text.Trim()) || string.IsNullOrEmpty(JenisKopitextBox1.Text.Trim()))
            {
                MessageBox.Show("Lengkapi data yang kosong", "Update Data:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CRUD.sql = "UPDATE datakopi SET nama_kopi = @nama_kopi, jenis_kopi = @jenis_kopi, bentuk_kopi = @bentuk_kopi, berat = @berat, harga = @harga, stok = @stok WHERE id_kopi = @id :: integer";

            execute(CRUD.sql, "Update");

            MessageBox.Show("Data Telah Berhasil Diubah", "Update Data:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData("");
            resetMe();
        }

        private void deletebuttonbutton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
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

                CRUD.sql = "DELETE FROM datakopi WHERE id_kopi = @id :: integer";

                execute(CRUD.sql, "Delete");

                MessageBox.Show("Data Telah Berhasil Dihapus", "Hapus Data:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData("");
                resetMe();
            }

        }

       

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Enabled = true;

            form2.ShowDialog();
        }
    }
}