using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
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
        string img_save_dir_path = @"C:\Users\Shumail\Desktop\SFS images";
        public static Bitmap vdo_img;
        IDictionary<string, int> price_dict = new Dictionary<string, int>() {
            {"2",160 },//small
            {"1",200 },//medium
            {"0",250 },//large
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
            vdo_img = null;
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                video_list_combobox.Items.Add(device.Name);
            video_list_combobox.SelectedIndex = 0;
            device = new VideoCaptureDevice();

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filter[video_list_combobox.SelectedIndex].MonikerString);
            device.NewFrame += new_frame;
            device.Start();
        }

        private void new_frame(object sender, NewFrameEventArgs eventArgs)
        {
            vdo_img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = vdo_img;
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
                

                if (!Directory.Exists(img_save_dir_path))
                {
                    Directory.CreateDirectory(img_save_dir_path);
                }
                vdo_img.Save(img_save_dir_path + filename, ImageFormat.Jpeg);
                //MessageBox.Show("Images saved");
                
                
                
                
                //webcall(vdo_img);
                //python_run(filename);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string python_script_path = @"C:\Users\Shumail\Desktop\Sameed\python_test.py";
        void python_run(string filename)
        {
            var engine = Python.CreateEngine();
            var script = python_script_path;
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
            Console.WriteLine(str(results.ToArray()));
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
            save();
        }



        void webcall2(Bitmap img)
        {
            byte[] dataStream = Encoding.UTF8.GetBytes(ImageToByte(img));   //img
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:60395/Service1.asmx/HelloWorldNew");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = dataStream.Length;
            Stream newStream = request.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);
            newStream.Close();
            var reader = new StreamReader(request.GetResponse().GetResponseStream());
            string dataReturn = reader.ReadToEnd();
        }
        // check returned convert
        void webcall(Bitmap img)
        {
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://WEB_URL");
            myReq.Method = "POST";
            myReq.ContentType = "text/xml";
            myReq.Timeout = 10000;
            myReq.Headers.Add("SOAPAction", ":\"#save\"");

            byte[] PostData = Encoding.UTF8.GetBytes(ImageToByte(img)); //img
            myReq.ContentLength = PostData.Length;

            using (Stream requestStream = myReq.GetRequestStream())
            {
                requestStream.Write(PostData, 0, PostData.Length);
            }

            HttpWebResponse response = (HttpWebResponse)myReq.GetResponse();
        }



        public static char[] ImageToByte(Bitmap img)
        {
            ImageConverter converter = new ImageConverter();
            return (char[])converter.ConvertTo(img, typeof(char[]));
        }

        
    }
}
 