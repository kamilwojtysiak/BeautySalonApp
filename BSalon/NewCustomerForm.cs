﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSalon
{
    public partial class NewCustomerForm : Form
    {
        string connectionString = @"Data Source=KAMIL;Initial Catalog=Customers;Integrated Security=True;";


        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string newCustomer = "Insert into [Customers](FirstName, LastName) Values('" + )";
            SqlConnection con = new SqlConnection(@"Data Source = KAMIL; Initial Catalog = Customers; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("dbo.Customer", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", LastName.Text);

            con.Open();

            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
        }
    }
}
