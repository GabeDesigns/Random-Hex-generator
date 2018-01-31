using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Data.OleDb;
/// <summary>
/// © Gabriel Rosales 2018
/// Created by: Gabriel Rosales
/// 
/// 
/// Purpose: To create a hexadecimal generator that uses a local database enabling it to never repeat itself.
/// and to enable security
/// 
/// 
/// </summary>
namespace RHG
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            //Loading application
            InitializeComponent();
        }

        //Loading GUI
        /// <summary>
        /// Upon form load, the application must connect to database and tell wether or not the file is actually there. If not, it will show an error and close.
        /// If it does connect, everything is normal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //connecting to database (access file named Used)
            using (var connection = new OleDbConnection())
            {
                //showing where to connect for the database
                connection.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\RHG\Used.accdb;Jet OLEDB:Database Password = MyDbPassword;";

                try
                {
                    //opening the connection
                    connection.Open();
                    //creating a databale and getting the schema from the database
                    DataTable table = connection.GetSchema("tables");
                    //adding the tables from the database to the items in the combo box "schoolcombo"
                    schoolcombo.Items.Add(table.ToString().Trim());
                    //Bug fix
                    schoolcombo.Items.Remove("Tables");


                }
                catch (Exception ex)
                {
                    //really cool display box that shows why it failed 
                    MessageBox.Show("Connection Failed\r\n\r\n" + ex.Message);

                }
                if (connection.State == ConnectionState.Closed)
                {
                    //if connection is closed or if the accessdatabase can't be reached the application will close
                    Application.Exit();
                }
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void schoolcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void InputTextBox_keyPress(object sender, KeyPressEventArgs e)
        {
            //if enter key is pressed, it pretends you clicked the "Enter" button
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                button1.Click += null;
            }
        }
        private void InputLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event handler(ie when the enter button is clicked it will generate the hex codes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //3 digit hex generator
            var r = new Random();
            int A = r.Next(100, 500);
            string hexValue1 = A.ToString("X3");
            MessageBox.Show(hexValue1);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CodeInputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
