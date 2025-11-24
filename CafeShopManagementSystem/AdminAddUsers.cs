using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace CafeShopManagementSystem
{
    public partial class AdminAddUsers : UserControl
    {
        static string conn = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        SqlConnection connect = new SqlConnection(conn);

        private int id = 0;

        public AdminAddUsers()
        {
            InitializeComponent();
            displayAddUsersData();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: tambahkan logika jika diperlukan
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Kosongkan atau tambahkan aksi klik label di sini
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kosongkan dulu
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsersData();
        }

        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();
            dataGridView1.DataSource = listData;
        }

        public bool emptyFields()
        {
            return adminAddUsers_username.Text == "" ||
                   adminAddUsers_password.Text == "" ||
                   adminAddUsers_role.Text == "" ||
                   adminAddUsers_status.Text == "" ||
                   adminAddUsers_imageView.Image == null;
        }

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    // check username
                    string selectUsern = "SELECT * FROM users WHERE username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string usern = adminAddUsers_username.Text.Substring(0, 1).ToUpper() + adminAddUsers_username.Text.Substring(1);
                            MessageBox.Show(usern + " sudah diambil!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativePath = Path.Combine("User_Directory", adminAddUsers_username.Text.Trim() + ".jpg");
                    string path = Path.Combine(baseDirectory, relativePath);

                    string directoryPath = Path.GetDirectoryName(path);
                    if (!Directory.Exists(directoryPath))
                        Directory.CreateDirectory(directoryPath);

                    File.Copy(adminAddUsers_imageView.ImageLocation, path, true);

                    string insertData = "INSERT INTO users (username, password, profile_image, role, status, date_reg) " +
                        "VALUES(@usern, @pass, @image, @role, @status, @date)";
                    DateTime today = DateTime.Today;

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@image", path);
                        cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Berhasil ditambahkan!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayAddUsersData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void adminAddUsers_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;

                    // Load gambar tanpa mengunci file
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        adminAddUsers_imageView.Image = Image.FromStream(stream);
                    }

                    adminAddUsers_imageView.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row.Cells.Count < 6)
            {
                MessageBox.Show("DataGrid tidak memiliki kolom yang cukup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                id = Convert.ToInt32(row.Cells[0].Value);
                adminAddUsers_username.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                adminAddUsers_password.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                adminAddUsers_role.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                adminAddUsers_status.Text = row.Cells[4].Value?.ToString() ?? string.Empty;

                string imagePath = row.Cells[5].Value?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        adminAddUsers_imageView.Image = Image.FromStream(stream);
                    }
                    adminAddUsers_imageView.ImageLocation = imagePath;
                }
                else
                {
                    adminAddUsers_imageView.Image = null;
                    adminAddUsers_imageView.ImageLocation = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"Apakah anda yakin untuk memperbarui Username: {adminAddUsers_username.Text.Trim()}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativePath = Path.Combine("User_Directory", adminAddUsers_username.Text.Trim() + ".jpg");
                    string path = Path.Combine(baseDirectory, relativePath);

                    string directoryPath = Path.GetDirectoryName(path);
                    if (!Directory.Exists(directoryPath))
                        Directory.CreateDirectory(directoryPath);

                    // copy tanpa error file lock
                    if (File.Exists(adminAddUsers_imageView.ImageLocation))
                    {
                        File.Copy(adminAddUsers_imageView.ImageLocation, path, true);
                    }

                    string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status, profile_image = @imagePath WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@imagePath", path);

                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Perbarui sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayAddUsersData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void clearFields()
        {
            adminAddUsers_username.Text = "";
            adminAddUsers_password.Text = "";
            adminAddUsers_role.SelectedIndex = -1;
            adminAddUsers_status.SelectedIndex = -1;
            adminAddUsers_imageView.Image = null;
            adminAddUsers_imageView.ImageLocation = null;
        }

        private void adminAddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void adminAddUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah anda yakin untuk menghapus Username: " + adminAddUsers_username.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string deleteData = "DELETE FROM users WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Sukses Hapus!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayAddUsersData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminAddUsers_imageView_Click(object sender, EventArgs e)
        {

        }

        private void adminAddUsers_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void adminAddUsers_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adminAddUsers_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
