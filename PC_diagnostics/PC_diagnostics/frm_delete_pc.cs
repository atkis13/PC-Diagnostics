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
    public partial class frm_delete_pc : Form
    {
        public frm_delete_pc()
        {
            InitializeComponent();
            try
            {
                Form_Methods.FillCombo(cmb_select_id);
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Methods.deletePCConfig(cmb_select_id.Text);
                Form_Methods.deletePC(cmb_select_id.Text);
                MessageBox.Show("Record id " + cmb_select_id.Text+ " has been deleted");
                this.Close();
                
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
