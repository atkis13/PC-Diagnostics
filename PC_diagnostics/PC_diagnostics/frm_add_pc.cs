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
    public partial class frm_add_pc : Form
    {
        public frm_add_pc()
        {
            InitializeComponent();
            cmb_back.Items.Add("Yes");
            cmb_back.Items.Add("No");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Methods.AddConfigtoDB(txt_system.Text, txt_cpu.Text, txt_mobo.Text, txt_ram.Text, txt_hdd.Text, txt_video_c.Text, txt_psu.Text, txt_os.Text, cmb_back.Text, txt_back_id.Text, dateTimePicker1.Text);
                MessageBox.Show("Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form_Methods.CloseDBConnection();
            }
        }
    }
}
