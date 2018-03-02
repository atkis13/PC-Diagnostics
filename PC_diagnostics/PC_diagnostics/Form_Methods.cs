using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PC_diagnostics
{
    class Form_Methods
    {
        string message;
        static DBConnection conn;

        public static void AddConfigtoDB(string id, string processor, string mobo, string ram, string hdd, string video_card, string psu, string os, string backup, string backup_id, string backup_date)
        {
            string query = "INSERT INTO pc_config(pc_id, processor, Motherboard, RAM, HDD, Video_card, Power_Source, OS, Backup, Backup_id, Backup_date) VALUES(@id, @processor, @mobo, @ram, @hdd, @video_card, @psu, @os, @backup, @backup_id, @backup_date);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@processor", processor);
            cmd.Parameters.AddWithValue("@mobo", mobo);
            cmd.Parameters.AddWithValue("@ram", ram);
            cmd.Parameters.AddWithValue("@hdd", hdd);
            cmd.Parameters.AddWithValue("@video_card", video_card);
            cmd.Parameters.AddWithValue("@psu", psu);
            cmd.Parameters.AddWithValue("@os", os);
            cmd.Parameters.AddWithValue("@backup", backup);
            cmd.Parameters.AddWithValue("@backup_id", backup_id);
            cmd.Parameters.AddWithValue("@backup_date", backup_date);
            cmd.ExecuteNonQuery();

        } 

        public static void AddPCtoDB(string id, string owner, string description)
        {
            string query = "INSERT INTO pc_ids(pc_id, owner_name, description) VALUES(@id, @owner, @description);";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@owner", owner);
            cmd.Parameters.AddWithValue("@description", description);            
            cmd.ExecuteNonQuery();
        }

        public static void GetConfigFromDB(string id, Label processor, Label mobo, Label ram, Label hdd, Label video_card, Label psu, Label os, Label backup, Label backup_id, Label backup_date)
        {
            string query = "Select * from  pc_config where pc_id = @id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {

                string proc_ = red.GetString("processor");
                string mobo_ = red.GetString("Motherboard");
                string ram_ = red.GetString("RAM");
                string hdd_ = red.GetString("HDD");
                string video_card_ = red.GetString("Video_card");
                string psu_ = red.GetString("Power_Source");
                string os_ = red.GetString("OS");
                string backup_ = red.GetString("Backup");
                string backup_id_ = red.GetString("Backup_id");
                string backup_date_ = red.GetString("Backup_date");

                processor.Text = proc_;
                mobo.Text = mobo_;
                ram.Text = ram_;
                hdd.Text = hdd_;
                video_card.Text = video_card_;
                psu.Text = psu_;
                os.Text = os_;
                backup.Text = backup_;
                backup_id.Text = backup_id_;
                backup_date.Text = backup_date_;
            }
        }

        public static void GetPCDetailsFromDB(string id, Label owner, Label description)
        {
            string query = "Select * from pc_ids where pc_id = @id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                string owner_ = red.GetString("owner_name");
                string desc_ = red.GetString("description");
                owner.Text = owner_;
                description.Text = desc_;
            }

        }

        public static void EditConfigDB(string id, string part, string value)
        {
            string query= null;
            if (part == "Processor")
            {
                query = "update pc_config set procesor=@value, Where pc_id = @id;";
            }
            else if(part == "Motherboard")
            {
                query = "update pc_config set Motherboard=@value, Where pc_id = @id;";
            }
            else if(part == "RAM")
            {
                query = "update pc_config set RAM=@value, Where pc_id = @id;";
            }
            else if (part == "HDD")
            {
                query = "update pc_config set HDD=@value, Where pc_id = @id;";
            }
            else if (part == "Video Card")
            {
                query = "update pc_config set Video_card=@value, Where pc_id = @id;";
            }
            else if (part == "Power Source")
            {
                query = "update pc_config set Power_Source=@value, Where pc_id = @id;";
            }
            else if (part == "OS")
            {
                query = "update pc_config set OS=@value, Where pc_id = @id;";
            }
            else if (part == "Bakup")
            {
                query = "update pc_config set Backup=@value, Where pc_id = @id;";
            }
            else if (part == "Backup ID")
            {
                query = "update pc_config set Backup_id=@value, Where pc_id = @id;";
            }
            else if (part == "Backup Date")
            {
                query = "update pc_config set Backup_date=@value, Where pc_id = @id;";
            }         
            

            conn = new DBConnection();            
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@value", value);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            

        }

        public static void EditPCDB(string id, string part, string value)
        {
            string query = null;
            if (part == "Owner")
            {
                query = "update pc_ids set owner_name=@value, Where pc_id = @id;";
            }
            else if (part == "Description")
            {
                query = "update pc_ids set description=@value, Where pc_id = @id;";
            }
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@value", value);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }

        public static void deletePCConfig(string id)
        {
            string query = "delete from pc_config where pc_id = @id;";
            conn = new DBConnection();           
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }

        public static void deletePC(string id)
        {
            string query = "delete from pc_ids where pc_id = @id;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }

        public static void CloseDBConnection()
        {
            conn.Close();
        }

        public static void CreateNewPDFLog()
        {

        }

        public static void ReadPDFLog()
        {

        }

        public static void FIllCombo(ComboBox cb)
        {
            string query = "Select * from pc_ids;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                string name = red.GetString("pc_id");
                cb.Items.Add(name);
            }

        }
    }
}
