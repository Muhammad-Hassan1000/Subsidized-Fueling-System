using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Subsidized_Fueling_System
{
    public partial class Display_info : Form
    {
        bool ml_bool;
        public static Bitmap vdo_img;
        public Display_info()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice device;

        private void Display_info_Load(object sender, EventArgs e)
        {
            ml_bool = true;
            vdo_img = null;
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                video_list_combobox.Items.Add(device.Name);
            video_list_combobox.SelectedIndex = 0;
            device = new VideoCaptureDevice();

        }
        
        private void start_video_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filter[video_list_combobox.SelectedIndex].MonikerString);
            device.NewFrame += new_frame;
            device.Start();
        }

        //static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_car.xml");

        private void new_frame(object sender, NewFrameEventArgs eventArgs)
        {
            vdo_img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = vdo_img;
            if (ml_bool)
            {
                ml_bool = false;
                ml_thread();
                //ml_bool = true;
            }
            Console.WriteLine("ml2---");

            //Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            /*Rectangle[] rectangles = cascadeClassifier.DetectMultiScale((IInputArray)eventArgs.Frame.Clone(), 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
            pictureBox1.Image = bitmap;*/

        }

        private void ml_thread()
        {
            Task t1 = new Task(video_ML);
            t1.Start();
        }
        private void video_ML()         //ml script
        {
            //if (pictureBox2.IsAccessible)
            //pictureBox2.Image = vdo_img;
            Thread.Sleep(2000);
            Console.WriteLine("ml..........");



            ml_bool = true;
        }

        private void Display_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }
        private void save()
        {
            try
            {
                string datetime = DateTime.Now.ToString("dd/MM/yyyy-HH/mm/ss");
                if (!Directory.Exists(@"C:\Users\Shumail\Desktop\SFS images"))
                {
                    Directory.CreateDirectory(@"C:\Users\Shumail\Desktop\SFS images");
                    string path = @"C:\Users\Shumail\Desktop\SFS images";
                    pictureBox1.Image.Save(path + @"\car image test" +datetime+ ".jpg", ImageFormat.Jpeg);
                    //MessageBox.Show("Images saved");
                }
                else
                {
                    string path = @"C:\Users\Shumail\Desktop\SFS images";
                    pictureBox1.Image.Save(path + @"\car image test"  +datetime+ ".jpg", ImageFormat.Jpeg);
                    //MessageBox.Show("Images saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thread_btn_Click(object sender, EventArgs e)
        {
            new Task(save).Start();
            //save();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            Form history_form = new Form();
            history_form.Show();
            
        }
    }
}
 