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
    public partial class frm_edit_pc : Form
    {
        string id;
        public frm_edit_pc()
        {
            
            InitializeComponent();
            cmb_select.Items.Add("Owner");
            cmb_select.Items.Add("Description");
            cmb_select.Items.Add("Processor");
            cmb_select.Items.Add("Motherboard");
            cmb_select.Items.Add("RAM");
            cmb_select.Items.Add("HDD");
            cmb_select.Items.Add("Video Card");
            cmb_select.Items.Add("Power Source");
            cmb_select.Items.Add("OS");
            cmb_select.Items.Add("Backup");
            cmb_select.Items.Add("Backup ID");
            cmb_select.Items.Add("Backup Date");
            dateTimePicker1.Enabled = false;
        }

        public string getID
        {
            set { id = value; }
            get { return id; }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string message = null;
            try
            {

                if (cmb_select.Text == "Owner" || cmb_select.Text == "Description")
                {


                    Form_Methods.EditPCDB(getID, cmb_select.Text, txt_update.Text);
                    message = txt_update.Text;
                }
                else if (cmb_select.Text == "Backup Date")
                {
                    Form_Methods.EditConfigDB(getID, cmb_select.Text,dateTimePicker1.Text);
                    message = dateTimePicker1.Text;
                }

                else
                {               
                    
                    Form_Methods.EditConfigDB(getID, cmb_select.Text, txt_update.Text);
                    message = txt_update.Text;

                }
                MessageBox.Show(cmb_select.Text + " has been updated to " + message);
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

        private void cmb_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_select.Text == "Backup Date")
            {
                dateTimePicker1.Enabled = true;
                txt_update.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                txt_update.Enabled = true;
            }
            

        }
    }
}
