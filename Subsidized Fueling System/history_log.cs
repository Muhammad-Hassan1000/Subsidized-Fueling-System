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

namespace Subsidized_Fueling_System
{
    public partial class history_log : Form
    {
        public history_log()
        {
            InitializeComponent();
        }

        private void history_log_Load(object sender, EventArgs e)
        {
            lower_date.CustomFormat = "yyyy-MM-dd";
            lower_date.Format = DateTimePickerFormat.Custom;
            lower_date.Value = lower_date.MinDate;

            upper_date.CustomFormat = "yyyy-MM-dd";
            upper_date.Format = DateTimePickerFormat.Custom;
            upper_date.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Server = tcp:masamual.database.windows.net,1433; Initial Catalog = alidb; Persist Security Info = False; User ID = ali; Password = Adminaccount@101; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();


                if (String.IsNullOrEmpty(upper_price.Text))
                {
                    cmd = new SqlCommand("select p.companyName as 'Company' , p.partName as 'Part Name', p.modelName as 'Model Name' , p.price*s.tquantity as [total price] , s.tquantity from [dbo].[product_table] as p   join (select sum(sold_quantity) as [tquantity], Id ,sold_date from [dbo].[log_table] group by Id , sold_date ) as s on p.productId = s.Id  where p.partName like '%"+ "%' and p.companyName like '%" + category_txt.Text.ToString() + "%' and p.modelName like '%" + lower_price.Text.ToString() + "%' and s.sold_date between '" + lower_date.Value.Date.ToString() + "' and '" + upper_date.Value.Date.ToString() + "';", cnn);

                }
                else
                {
                    cmd = new SqlCommand("select p.companyName as 'Company' , p.partName as 'Part Name', p.modelName as 'Model Name' , p.price*s.tquantity as [total price] , s.tquantity from [dbo].[product_table] as p   join (select sum(sold_quantity) as [tquantity], Id ,invoice from [dbo].[log_table] group by Id ,invoice ) as s on p.productId = s.Id  where p.partName like '%" + "%' and p.companyName like '%" + category_txt.Text.ToString() + "%' and p.modelName like '%" + lower_price.Text.ToString() + "%' and s.invoice = @inv ;", cnn);
                    int invvalue = int.Parse(upper_price.Text);
                    cmd.Parameters.AddWithValue("@inv", invvalue);

                }
                SqlDataAdapter sqd = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqd.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Retry");
            }
        }
    }
}
