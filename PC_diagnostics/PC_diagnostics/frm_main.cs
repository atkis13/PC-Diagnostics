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
            lbl_owner.Visible = false;
            lbl_desc.Visible = false;
            lbl_cpu.Visible = false;
            lbl_mobo.Visible = false;
            lbl_ram.Visible = false;
            lbl_video.Visible = false;
            lbl_psu.Visible = false;
            lbl_hdd.Visible = false;
            lbl_os.Visible = false;
            lbl_backup.Visible = false;
            lbl_bak_id.Visible = false;
            lbl_bak_date.Visible = false;
            try
            {
                Form_Methods.FillCombo(comboBox1);
                Form_Methods.NRSystems(lbl_sys_count);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form_Methods.CloseDBConnection();
            }
            
           
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
            edit.getID = comboBox1.Text;
            edit.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            frm_delete_pc del = new frm_delete_pc();
            del.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Methods.GetConfigFromDB(comboBox1.Text, lbl_cpu, lbl_mobo, lbl_ram, lbl_hdd, lbl_video, lbl_psu, lbl_os, lbl_backup, lbl_bak_id, lbl_bak_date);
                Form_Methods.GetPCDetailsFromDB(comboBox1.Text, lbl_owner, lbl_desc);
                lbl_owner.Visible = true;
                lbl_desc.Visible = true;
                lbl_cpu.Visible = true;
                lbl_mobo.Visible = true;
                lbl_ram.Visible = true;
                lbl_video.Visible = true;
                lbl_psu.Visible = true;
                lbl_backup.Visible = true;
                lbl_bak_id.Visible = true;
                lbl_bak_date.Visible = true;
                lbl_hdd.Visible = true;
                lbl_os.Visible = true;
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

        private void btn_reload_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            try
            {
                lbl_owner.Visible = false;
                lbl_desc.Visible = false;
                lbl_cpu.Visible = false;
                lbl_mobo.Visible = false;
                lbl_ram.Visible = false;
                lbl_video.Visible = false;
                lbl_psu.Visible = false;
                lbl_backup.Visible = false;
                lbl_bak_id.Visible = false;
                lbl_bak_date.Visible = false;
                lbl_hdd.Visible = false;
                lbl_os.Visible = false;
                Form_Methods.FillCombo(comboBox1);
                Form_Methods.NRSystems(lbl_sys_count);
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
