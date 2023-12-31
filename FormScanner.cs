using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace ScanerProject
{
    public partial class FormScanner : Form
    {
        public FormScanner()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelViewSid.Text = "";
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBoxDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void buttonViewDetail_Click(object sender, EventArgs e)
        {

            FormViewDeatail formViewDeatail = new FormViewDeatail();
            formViewDeatail.GetSid = labelViewSid.Text;
            formViewDeatail.Show();
            this.Close();
        }

        private void FormScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                comboBoxDevice.Items.Add(filterInfo);
            comboBoxDevice.SelectedIndex = 0;
        }

        private void FormScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (captureDevice.IsRunning)
                    captureDevice.Stop();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader barcodereader = new BarcodeReader();
                Result result = barcodereader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    labelViewSid.Text = result.ToString();
                    timer.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }

            }
        }

        private void buttonAdminDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
            this.Hide();
        }
    }
}
