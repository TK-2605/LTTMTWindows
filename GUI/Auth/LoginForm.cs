using ShoppingSystem.Utils;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShoppingSystem.GUI.Auth
{
    public partial class LoginForm : RoundedForm
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public LoginForm()
        {
            InitializeComponent();

            string emailPlaceholderText = "tuhelrana@gmail.com";

            this.txtEmail.Text = emailPlaceholderText;
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;

            // Sự kiện ENTER
            this.txtEmail.Enter += (sender, e) =>
            {
                if (this.txtEmail.Text == emailPlaceholderText)
                {
                    this.txtEmail.Text = "";
                    this.txtEmail.ForeColor = System.Drawing.Color.Black;
                }
            };

            // Sự kiện LEAVE
            this.txtEmail.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(this.txtEmail.Text))
                {
                    this.txtEmail.Text = emailPlaceholderText;
                    this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
                }
            };

            

        }

        // 3. Hàm xử lý kéo Form chung
        private void MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra null để tránh lỗi nếu Designer chưa gán
            string email = txtEmail != null ? txtEmail.Text : "";
            MessageBox.Show("Đang xử lý đăng nhập...\nEmail: " + email);

           
                string inputEmail = txtEmail.Text;
                string inputPass = txtPassword.Text;

                if (CheckLogin(inputEmail, inputPass))
                {
                    //Xử lý lưu mật khẩu 
                    if (chkRemember.Checked)
                    {
                        Properties.Settings.Default.UserEmail = inputEmail;
                        Properties.Settings.Default.UserPass = inputPass;
                        Properties.Settings.Default.IsRemember = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.UserEmail = "";
                        Properties.Settings.Default.UserPass = "";
                        Properties.Settings.Default.IsRemember = false;
                        Properties.Settings.Default.Save();
                    }

                    MessageBox.Show("Đăng nhập thành công! Chào mừng " + inputEmail);

                // new MainForm().Show();
                // this.Hide();
            }
            else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu. Vui lòng thử lại!");
                }
            

            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckLogin(string email, string inputPass)
        {
            // kết nối 
            string strConn = @"Data Source=TrungKien\SQLEXPRESS;Initial Catalog=ShoppingSystemDB;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    // truyền pass 
                    string query = "SELECT Password FROM Users WHERE Email = @email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        // Lấy mật khẩu 
                        object result = cmd.ExecuteScalar();

                        // không tìm thấy gmail
                        if (result == null)
                        {
                            return false;
                        }

                        string dbPasswordHash = result.ToString();

                        // tách Salt ra và so sánh với inputPass
                        if (SecurityHelper.VerifyPassword(inputPass, dbPasswordHash))
                        {
                            return true; 
                        }
                        else
                        {
                            return false; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
        }
    }
}