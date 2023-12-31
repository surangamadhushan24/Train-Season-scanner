using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanerProject
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void buttonDestination_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "select * from destinations ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);          
                        connection.Close();
                        dataGridView.DataSource = dt;
                    }

                }

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "insert into destinations(Did,destination,distanace,price) values ('" + textBoxDid.Text +"', '" + textBoxDestination.Text +"','" + textBoxDistance.Text +"','" +textBoxPrice.Text + "')";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        connection.Close();
                        dataGridView.DataSource = dt;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
    }
}
