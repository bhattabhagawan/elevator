using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    class database
    {
        private bool filled;
        public DataSet ds = new DataSet();

        private void btn_displaylog_Click(object sender, EventArgs e)
        {
            try
            {
                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ElevatorDatabase.accdb;";
                string dbcommand = "Select * from Actions;";
                OleDbConnection conn = new OleDbConnection(dbconnection);
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(comm);
                conn.Open();
                MessageBox.Show("Connection Open ! ");
                while (filled == false)
                {
                    adapter.Fill(ds);
                    filled = true;
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
                string message = "Error in connection to datasource";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                //database_listbox.Items.Add(row["Date"] + "\t\t" + row["Time"] + "\t\t" + row["Action"]);
            }
        }
    }
}

