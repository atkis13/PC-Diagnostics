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
        static DBConnection conn;

        public static void AddConfigtoDB(string id, string processor, string mobo, string ram, string hdd, string video_card, string psu, string os)
        {

        } 

        public static void AddPCtoDB(string id, string owner)
        {

        }

        public static void GetConfigFromDB(Label id, Label processor, Label mobo, Label ram, Label hdd, Label video_card, Label psu, Label os)
        {

        }

        public static void GetPCOwnerFromDB(Label owner)
        {

        }

        public static void CreateNewPDFLog() // use to update the pdf as well
        {

        }

        public static void ReadPDFLog()
        {

        }

        public static void FIllCombo(ComboBox cb)
        {

        }
    }
}
