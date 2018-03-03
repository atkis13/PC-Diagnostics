using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

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
            if(backup == "No")
            {
                backup_id = "N/A";
                backup_date = "N/A";
            }
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
                query = "update pc_config set processor=@value where pc_id = @id;";
            }
            else if(part == "Motherboard")
            {
                query = "update pc_config set Motherboard=@value where pc_id = @id;";
            }
            else if(part == "RAM")
            {
                query = "update pc_config set RAM=@value where pc_id = @id;";
            }
            else if (part == "HDD")
            {
                query = "update pc_config set HDD=@value where pc_id = @id;";
            }
            else if (part == "Video Card")
            {
                query = "update pc_config set Video_card=@value where pc_id = @id;";
            }
            else if (part == "Power Source")
            {
                query = "update pc_config set Power_Source=@value where pc_id = @id;";
            }
            else if (part == "OS")
            {
                query = "update pc_config set OS=@value where pc_id = @id;";
            }
            else if (part == "Bakup")
            {
                query = "update pc_config set Backup=@value where pc_id = @id;";
            }
            else if (part == "Backup ID")
            {
                query = "update pc_config set Backup_id=@value where pc_id = @id;";
            }
            else if (part == "Backup Date")
            {
                query = "update pc_config set Backup_date=@value where pc_id = @id;";
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
                query = "update pc_ids set owner_name=@value where pc_id = @id;";
            }
            else if (part == "Description")
            {
                query = "update pc_ids set description=@value where pc_id = @id;";
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

        public static void FillCombo(ComboBox cb)
        {
            string query = "Select * from pc_ids;";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            MySqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                string id = red.GetString("pc_id");
                cb.Items.Add(id);
            }

        }

        public static void NRSystems(Label lb)
        {
            string query = "SELECT COUNT(*) FROM pc_ids";
            conn = new DBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
            long count = (long)cmd.ExecuteScalar();
            lb.Text = count.ToString();

        }

        public static void CloseDBConnection()
        {
            conn.Close();
        }

        public static void CreateNewPDFLog(string id,string owner, string description, string cpu, string mobo, string ram, string hdd, string video_c, string psu, string os, string bak, string back_id, string back_date)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(id+".pdf", FileMode.Create));
            doc.Open();
            DateTime d = DateTime.Now;
            Paragraph p0 = new Paragraph(d.ToString()+": Log Created");
            Paragraph p_ = new Paragraph(" ");
            Paragraph p_00 = new Paragraph("NEW SYSTEM");
            Paragraph p_1 = new Paragraph("System ID: "+ id);
            Paragraph p_2 = new Paragraph("System Owner: "+owner);
            Paragraph p_3 = new Paragraph("System Descryption: "+ description);
            Paragraph p_4 = new Paragraph(" ");

            Paragraph p1 = new Paragraph("SYSTEM DETAILS");
            Paragraph p2 = new Paragraph("CPU: "+cpu);
            Paragraph p3 = new Paragraph("Motherboard: "+ mobo);
            Paragraph p4 = new Paragraph("RAM: "+ ram);
            Paragraph p5 = new Paragraph("HDD: "+ hdd);
            Paragraph p6 = new Paragraph("Video Card: "+ video_c);
            Paragraph p7 = new Paragraph("PSU: "+ psu);
            Paragraph p8 = new Paragraph("OS: "+ os);
            Paragraph p9 = new Paragraph("Backup: " + bak);
            Paragraph p10 = new Paragraph("Backup ID: "+ back_id);
            Paragraph p11 = new Paragraph("Backup Date: "+back_date);
            Paragraph p12 = new Paragraph(" ");
            Paragraph p13 = new Paragraph("=================================================");
            Paragraph p14 = new Paragraph(" ");
            Paragraph p15 = new Paragraph(" ");
            doc.Add(p0);
            doc.Add(p_);
            doc.Add(p_00);
            doc.Add(p_1);
            doc.Add(p_2);
            doc.Add(p_3);
            doc.Add(p_4);

            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Add(p6);
            doc.Add(p7);
            doc.Add(p8);
            doc.Add(p9);
            doc.Add(p10);
            doc.Add(p11);
            doc.Add(p12);
            doc.Add(p13);
            doc.Add(p14);
            doc.Add(p15);
            doc.Close();


        }

        public static void ReadPDFLog(string id,RichTextBox rt)
        {
            string strx = string.Empty;

            try
            {
                //adding the pdf to the rich text box
                PdfReader reader = new PdfReader(id+".pdf");
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                    String s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                    strx = strx + s;
                    rt.Text = strx;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void AddNewLog(string id, RichTextBox previous, RichTextBox current)
        {
            DateTime d = DateTime.Now;
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(id + ".pdf", FileMode.Create));
            doc.Open();
            Paragraph p0 = new Paragraph(previous.Text);
            Paragraph p_date = new Paragraph(d.ToString() + ":");
            Paragraph p1 = new Paragraph(current.Text);
            Paragraph p12 = new Paragraph(" ");
            Paragraph p13 = new Paragraph("=================================================");
            Paragraph p14 = new Paragraph(" ");
            Paragraph p15 = new Paragraph(" ");
            doc.Add(p0);
            doc.Add(p_date);
            doc.Add(p1);
            doc.Add(p12);
            doc.Add(p13);
            doc.Add(p14);
            doc.Add(p15);
            doc.Close();


        }

        public static void AddEditLog(string id, string previous, string current)
        {
            DateTime d = DateTime.Now;
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(id + ".pdf", FileMode.Create));
            doc.Open();
            Paragraph p0 = new Paragraph(previous);
            Paragraph p_date = new Paragraph(d.ToString() + ":");
            Paragraph p1 = new Paragraph(current);
            Paragraph p12 = new Paragraph(" ");
            Paragraph p13 = new Paragraph("=================================================");
            Paragraph p14 = new Paragraph(" ");
            Paragraph p15 = new Paragraph(" ");
            doc.Add(p0);
            doc.Add(p_date);
            doc.Add(p1);
            doc.Add(p12);
            doc.Add(p13);
            doc.Add(p14);
            doc.Add(p15);
            doc.Close();


        }

        public static void DeleteLog(string id)
        {
            string sourceFile = Application.StartupPath+@"\\"+id+".pdf";
            string destinationFile = Application.StartupPath + @"\\Archived\\_archived" +id+".pdf";
            System.IO.File.Move(sourceFile, destinationFile);
        }

        
    }
}
