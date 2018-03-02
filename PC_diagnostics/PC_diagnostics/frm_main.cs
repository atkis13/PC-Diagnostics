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
    public partial class frm_main : Form
    {
        public frm_main()       
        {
            InitializeComponent();
            try
            {
                Form_Methods.FillCombo(comboBox1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form_Methods.CloseDBConnection();
            }
            cmb_backup.Items.Add("Yes");
            cmb_backup.Items.Add("No");
           
        }

        private void btn_add_pc_Click(object sender, EventArgs e)
        {
            frm_add_pc add_pc = new frm_add_pc();
            add_pc.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_edit_pc edit = new frm_edit_pc();
            edit.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            frm_delete_pc del = new frm_delete_pc();
            del.Show();
        }
    }
}
