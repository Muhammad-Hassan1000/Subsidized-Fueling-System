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
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Subsidized_Fueling_System
{
    public partial class Display_info : Form
    {
        bool ml_bool;
        public static Bitmap vdo_img;
        IDictionary<string, int> price_dict = new Dictionary<string, int>() {
            {"1",160 },
            {"2",200 },
            {"3",250 },
            {"",300 }

        };

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
            start_video.Enabled = false;
            device = new VideoCaptureDevice(filter[video_list_combobox.SelectedIndex].MonikerString);
            device.NewFrame += new_frame;
            device.Start();
        }

        //static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_car.xml");

        private void new_frame(object sender, NewFrameEventArgs eventArgs)
        {
            vdo_img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = vdo_img;
               /*if (ml_bool)
                {
                    ml_bool = false;
                    ml_thread();
                    //ml_bool = true;
                }
                //Console.WriteLine("ml2---");
            
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
                //Console.WriteLine("ml..........");


                ml_bool = true;*/
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
                string filename = @"\car image test" + datetime + ".jpg";
                if (!Directory.Exists(@"C:\Users\Shumail\Desktop\SFS images"))
                {
                    Directory.CreateDirectory(@"C:\Users\Shumail\Desktop\SFS images");
                }

                string path = @"C:\Users\Shumail\Desktop\SFS images";
                vdo_img.Save(path + filename, ImageFormat.Jpeg);
                //MessageBox.Show("Images saved");

                python_run(filename);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        void python_run(string filename)
        {
            var engine = Python.CreateEngine();
            var script = @"C:\Users\Shumail\Desktop\Sameed\python_test.py";
            var source = engine.CreateScriptSourceFromFile(script);
            
            var elO = engine.Runtime.IO;
            var errors = new MemoryStream();
            elO.SetErrorOutput(errors, Encoding.Default);
            var results = new MemoryStream();
            elO.SetOutput(results, Encoding.Default);
            
            var scope = engine.CreateScope();
            scope.SetVariable("my_string", filename);
            source.Execute(scope);
            
            string str(byte[] x) => Encoding.Default.GetString(x);

            Console.WriteLine("errors");
            Console.WriteLine(str(errors.ToArray()));
            Console.WriteLine();
            Console.WriteLine("results");
            SetcategoryTextBox(str(results.ToArray()));
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            Form history_form = new Form();
            history_form.Show();
            
        }

        private void category_textbox_TextChanged(object sender, EventArgs e)
        {
            SetpriceTextBox(category_textbox.Text.Trim('\n', '\r'));
        }

        private void SetpriceTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate () { SetpriceTextBox(text.Trim('\n', '\r')); });
                return;
            }
            
            price_textbox.Text = price_dict[text].ToString();
        }
        private void SetcategoryTextBox(String text)
        {
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate () { SetcategoryTextBox(text); });
                return;
            }
            category_textbox.Text += Environment.NewLine + text;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            new Task(save).Start();
        }
    }
}
 