﻿using System;
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


namespace RHG
{
    
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (var connection = new OleDbConnection())
            {
                connection.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\grosales\Documents\rhg\RHG\Used.accdb;Jet OLEDB:Database Password = MyDbPassword;";
                   
                try
                {
                    connection.Open();

                    //TODO: do something with the connection

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed\r\n\r\n" + ex.Message);
                }
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection Successful");
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
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                button1_Click(null, null);
            }
        }
        private void InputLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
