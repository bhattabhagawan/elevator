using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public partial class Elevator : Form
    {
        int yup = 28;
        int ydn = 310;
        public Elevator()
        {
            InitializeComponent();
        }

        private void alarm1_Click(object sender, EventArgs e) //sabai dhoka khulne
        {
            t2.Enabled = true;
            t4.Enabled = true;
            insertdata("Emergency Stop!");
        }

        private void alarm_Click(object sender, EventArgs e) // sabai dhoka kholne
        {
            t2.Enabled = true;
            t4.Enabled = true;
            insertdata("Emergency Stop!");
        }

        private void down_Click(object sender, EventArgs e) //lift tala jane part
        {
            if (lift.Location.Y >= yup)
            {
                insertdata("Moving to First Floor!");
                t3.Enabled = true;
            }
            insertdata("Opening Door!");
            if (lift.Location.Y==28)
            { insertdata("Opening Door!");
                t4.Enabled = true;
            }
            t4.Enabled = false;
            
            Up();
        }

        private void up_Click(object sender, EventArgs e) //lift mathi janxa
        {
            if (lift.Location.Y <= ydn && lift.Top==28)
            {
                insertdata("Moving to Ground Floor!");
                t1.Enabled = true;
            }
            insertdata("Opening Door!");
            if (lift.Location.Y==310)
            { t2.Enabled = false;
                t2.Enabled = true;
                insertdata("Opening Door!"); }
            t2.Enabled = false;
            Down();
        }

        private void oup_Click(object sender, EventArgs e) //mathiko matra door kholxa
        {
            if (lul.Location.X <= 47 && lift.Location.Y == 28)
            {
                t4.Enabled = true;
            }
            insertdata("Opening Door!");
            if (lul.Location.X == 47)
            { //t4.Enabled=false; 
            }
        }

        private void odown_Click(object sender, EventArgs e) // tala ko door matra kholxa
        {
            if (ldl.Location.X <= 47 && lift.Location.Y == 310)
            {
                t2.Enabled = true;
                if (ldl.Location.X ==-20)
                insertdata("Opening Door!");
            }
        }

        private void cdown_Click(object sender, EventArgs e)  //tala ko dhoka banda garne
        {
            t6.Enabled = true;
            insertdata("Closing Door!");
        }

        private void cup_Click(object sender, EventArgs e)  //mathi ko dhoka banda garne
        {
            t2.Enabled = false;
            t5.Enabled = true;
            insertdata("Closing Door!");
        }
        
        //timer ko part
        private void t1_Tick(object sender, EventArgs e) //dhoka lagayera tala jane part
        {

            if (lur.Location.X >= 47 && lift.Top <= 310)
            {
                t5.Enabled = true;
                if (lul.Location.X >= 47 && lur.Location.X <= 310)
                {
                    lift.Location = new Point(lift.Location.X, lift.Location.Y + 1);
                    t5.Enabled = false;
                    t1.Enabled = true;
                    if (lift.Location.Y == 310)
                    {
                        t1.Enabled = false;
                        t2.Enabled = true;
                    }
                }
            }
            else
            {
                lift.Location = new Point(lift.Location.X, lift.Location.Y + 1);
                
                t1.Enabled = true;
                if (lift.Location.Y == 310)
                {
                    t1.Enabled = false;
                    t2.Enabled = true;
                }
            }
        }

        private void t2_Tick(object sender, EventArgs e) //talako dhoka kholne matra
        {
            if (ldl.Location.X<=189)
            { 
            t1.Enabled = false;
            ldl.Location = new Point(ldl.Location.X - 1, ldl.Location.Y);
            ldr.Location = new Point(ldr.Location.X + 1, ldr.Location.Y);
            t2.Enabled = true;
                if (ldr.Location.X >= 188)
                {
                    t2.Enabled = false;
                }
            }
        }

        private void t3_Tick(object sender, EventArgs e)  //lift mathi jane part
        {
            if (ldl.Location.X >= 47 && lift.Location.Y >= 28)
            {
                t2.Enabled = true;
                lift.Location = new Point(lift.Location.X, lift.Location.Y - 1);
                t3.Enabled = true;
                t2.Enabled = false;
                if (lift.Location.Y == 28)
                {
                    t3.Enabled = false;
                    t4.Enabled = true;
                }
            }
            else if (ldr.Location.X >= 188 && ldl.Location.X >= 188 && lift.Top==310)
            {
                t6.Enabled = true;
                if (ldr.Location.X==121 && ldl.Location.X == 47 && lift.Location.Y == 310)
                {
                    
                    lift.Location = new Point(lift.Location.X, lift.Location.Y - 1);

                    t3.Enabled = true;
                    if (lift.Location.Y == 28)
                    {
                        t3.Enabled = false;
                        t4.Enabled = true;
                    }
                }
            }
        }

        private void t4_Tick(object sender, EventArgs e) //mthiko dhoka kholne matra
        {
            if (lul.Location.X < 189 && lift.Top >= 27)
            {
                t1.Enabled = false;
                lul.Location = new Point(lul.Location.X - 1, lul.Location.Y);
                lur.Location = new Point(lur.Location.X + 1, lur.Location.Y);
                t4.Enabled = true;
                if (lur.Location.X >= 188)
                {
                    t4.Enabled = false;
                }
            }
        }

        private void t5_Tick(object sender, EventArgs e) //mathiko dhoka laune matra
        {
            if (lul.Location.X < 188)
            {
                lul.Location = new Point(lul.Location.X + 1, lul.Location.Y);
                lur.Location = new Point(lur.Location.X - 1, lur.Location.Y);
                t5.Enabled = true;
                if (lur.Location.X <= 121)
                {
                    t5.Enabled = false;
                }
            }
        }

        private void t6_Tick(object sender, EventArgs e)  //talako dhoka laune matra
        {
            if (ldl.Location.X < 47)
            {
                ldl.Location = new Point(ldl.Location.X + 1, ldl.Location.Y);
                ldr.Location = new Point(ldr.Location.X - 1, ldr.Location.Y);
                t6.Enabled = true;
                if (ldr.Location.X <= 121)
                {
                    t6.Enabled = false;
                }
            }
        } 

        //database
        public DataSet ds = new DataSet();
        internal void insertdata(string action)
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = ElevatorDatabase.accdb;";
            string dbcommand = "insert into [Actions] ([Date],[Time],[Action]) values (@date, @time, @action)";
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();
            database_listbox.Items.Add(date + "\t\t" + time + "\t\t" + action);
            OleDbConnection conn_db = new OleDbConnection(dbconnection);
            OleDbCommand comm_insert = new OleDbCommand(dbcommand, conn_db);
            OleDbDataAdapter adapter_insert = new OleDbDataAdapter(comm_insert);
            comm_insert.Parameters.AddWithValue("@date", date);
            comm_insert.Parameters.AddWithValue("@time", time);
            comm_insert.Parameters.AddWithValue("@action", action);
            conn_db.Open();
            comm_insert.ExecuteNonQuery();
            conn_db.Close();
        }
        //led
        public string mchange
        {
            get { return middle.Text; }
            set { middle.Text = value; }
        }
        private void Up()
        {
            mchange = "1";
        }
        private void Down()
        {
            mchange = "G";
        }
    }
}
