using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanerProject
{
    public partial class FormViewDeatail : Form
    {
        public FormViewDeatail()
        {
            InitializeComponent();
        }

        public string GetSid
        {
            get; set;
        }

        private void FormViewDeatail_Load(object sender, EventArgs e)
        {
            labelViewSid.Text = GetSid;
            getDeatils();

        }

        private void getDeatils()
        {
            try
            {
                string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // sql select statement
                    string sql1 = "select * from season where S_id ='" + labelViewSid.Text + "' ";
                    using (SqlCommand command1 = new SqlCommand(sql1, connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command1);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow firstRow = dt.Rows[0];
                            string month = firstRow[1].ToString();
                            string numbrOfTurn = firstRow[2].ToString();
                            string did = firstRow[3].ToString();
                            string nic = firstRow[4].ToString();
                            string year = firstRow[5].ToString();

                            labelViewMonth.Text = month;
                            labelViewYear.Text = year;
                            labelViewTurns.Text = numbrOfTurn;
                            labelViewNic.Text = nic;

                            string sql2 = "select * from users where NIC ='" + labelViewNic.Text + "' ";
                            using (SqlCommand command2 = new SqlCommand(sql2, connection))
                            {
                                SqlDataAdapter sda2 = new SqlDataAdapter(command2);
                                DataTable dt2 = new DataTable();
                                sda2.Fill(dt2);

                                if (dt2.Rows.Count > 0)
                                {
                                    DataRow userFirstRow = dt2.Rows[0];
                                    string name = userFirstRow[1].ToString();
                                    labelViewName.Text = name;
                                }
                                else
                                {
                                    MessageBox.Show("command2 error");
                                }
                            }
                            string sql3 = "select * from destinations where Did = did ";
                            using (SqlCommand command3 = new SqlCommand(sql3, connection))
                            {
                                SqlDataAdapter sda3 = new SqlDataAdapter(command3);
                                DataTable dt3 = new DataTable();
                                sda3.Fill(dt3);
                                if (dt3.Rows.Count > 0)
                                {
                                    DataRow destinationFirstRow = dt3.Rows[0];
                                    string destination = destinationFirstRow[1].ToString();
                                    labelViewDestination.Text ="Galle /" + destination;
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("error");
                        }


                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int currentYear = DateTime.Now.Year;

                int currentMonth = DateTime.Now.Month;
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(currentMonth);

                if (currentYear != Convert.ToInt32(labelViewYear.Text) || monthName != labelViewMonth.Text)
                {
                    MessageBox.Show("expired season", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("valid season");
                    updateTurns();
                    buttonCheck.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void updateTurns()
        {
            try
            {
                int currentTurns = Convert.ToInt32(labelViewTurns.Text);
                currentTurns -= 1;
                if (currentTurns > 0)
                {
                    string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql4 = "update season set S_numberof_qr_readtimes  = " + currentTurns + " where S_id = '" + labelViewSid.Text + "' ";
                        using (SqlCommand command = new SqlCommand(sql4, connection))
                        {
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Exceeded turns.. please renew your season for the next month","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormScanner scanner = new FormScanner();
            scanner.Show();
            this.Hide();
        }
    }
}
