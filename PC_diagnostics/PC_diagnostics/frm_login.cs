using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_diagnostics
{
    public partial class frm_login : Form
    {
        DBConnection conn;
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_username.Text;
            string pass = txt_password.Text;

            try
            {
                conn = new DBConnection();
                if (user == conn.Username && pass == conn.Password)
                {
                    conn.Open();
                    MessageBox.Show("Connected");
                    this.Hide();
                    frm_main main = new frm_main();
                    main.Show();

                }



            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }
    }
    
}
