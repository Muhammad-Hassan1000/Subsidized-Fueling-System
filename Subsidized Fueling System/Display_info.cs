using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;

namespace Subsidized_Fueling_System
{
    public partial class Display_info : Form
    {
        public static Bitmap vdo_img;
        public Display_info()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice device;

        private void Display_info_Load(object sender, EventArgs e)
        {
            vdo_img = null ;
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                video_list_combobox.Items.Add(device.Name);
            video_list_combobox.SelectedIndex = 0;
            device = new VideoCaptureDevice();
            
        }

        //Thread thread;

        private void start_video_Click(object sender, EventArgs e)
        {
            //thread = new Thread(video_ML);
            

            device = new VideoCaptureDevice(filter[video_list_combobox.SelectedIndex].MonikerString);
            device.NewFrame += new_frame;
            device.Start();
        }
        
        //static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        private void new_frame(object sender, NewFrameEventArgs eventArgs)
        {
            vdo_img = (Bitmap)eventArgs.Frame.Clone();

            pictureBox1.Image = vdo_img;

            video_ML();
            
        }

        private void video_ML()         //ml script
        {
            pictureBox2.Image = vdo_img;



        }

        private void Display_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }

        private void thread_btn_Click(object sender, EventArgs e)
        {
            //Form ml = new Form();
            //ml.Show();
            
            //Thread thread = new Thread(video_ML);
            //thread.Start();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            Form history_form = new Form();
            history_form.Show();
            
        }
    }
}
 