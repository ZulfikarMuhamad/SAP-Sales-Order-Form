using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;
using SalesOrderForm.Model;
using System.Net;

namespace SalesOrderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DocNum.ReadOnly = true;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            add_btn.Enabled = true;
            string URI = "http://localhost:51145/api/SalesOrder/" + Convert.ToInt32(textBox1.Text);
            getJsonStringData(URI);
               
        }
        

        public void RemoveText(object sender, EventArgs e)
        {
            if (textBox1.Text == "Document Entry")
            {
                textBox1.Text = "";
            }
        }

        public void addText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Document Entry";
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            string URI = "http://localhost:51145/api/SalesOrder/";
            List<SO_details> detail=new List< SO_details>();
            DataTable table = new DataTable();

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                SO_details arrr = new SO_details()
                {
                    ItemCode = dataGridView1.Rows[i].Cells["ItemCode"].Value.ToString(),
                    UomEntry = Convert.ToInt32(dataGridView1.Rows[i].Cells["UoMEntry"].Value),
                    Quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value),
                    UnitPrice = Convert.ToInt32(dataGridView1.Rows[i].Cells["UnitPrice"].Value),
                    DiscountPercent = Convert.ToInt32(dataGridView1.Rows[i].Cells["DiscountPercent"].Value),
                    WarehouseCode = dataGridView1.Rows[i].Cells["WarehouseCode"].Value.ToString(),
                    LineTotal = Convert.ToInt32(dataGridView1.Rows[i].Cells["LineTotal"].Value)
                };
                detail.Add(arrr);
            }

            SO_header arr = new SO_header()
            {
                CardCode = CardCode.Text,
                DocumentDate = Convert.ToDateTime(TaxDate.Text),
                PostingDate = Convert.ToDateTime(DocDate.Text),
                DeliveryDate = Convert.ToDateTime(DocDueDate.Text),
                SalesPersonCode = Convert.ToInt32(SalesPersonCode.Text),
                Lines=detail
            };
            
            Post(URI, JsonConvert.SerializeObject(arr));
            MessageBox.Show("Data has been added");
            dataGridView1.Columns.Clear();
            CardCode.Clear();
            TaxDate.Clear();
            DocDate.Clear();
            DocDueDate.Clear();
            SalesPersonCode.Clear();
        }

        public void Post(string url, string value)
        {
            var myReq = (HttpWebRequest)WebRequest.Create(url);
            myReq.ContentType = "application/json";
            myReq.Method = "POST";

            using (var streamwritter = new StreamWriter(myReq.GetRequestStream()))
            {
                streamwritter.Write(value);
                streamwritter.Flush();
                streamwritter.Close();
            }

            var myResp = (HttpWebResponse)myReq.GetResponse();
            using (var streamReader = new StreamReader(myResp.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
        public void getJsonStringData(string uri) {
            try
            {
                //request into web API
                HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(uri);
                HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();

                //if response OK and data length is exist (> 0)
                if ((myResp.StatusCode == HttpStatusCode.OK) && (myResp.ContentLength > 0))
                {
                    //read stream of JSON
                    var reader = new StreamReader(myResp.GetResponseStream());
                    string s = reader.ReadToEnd();

                    //convert JSON's string into array as Sales Order models
                    var arr = JsonConvert.DeserializeObject<SalesOrder>(s);
                    
                    /*
                    //set datagridview data source from JSON
                    dataGridView1.DataSource = arr.Values.Lines;
                    */

                    /* Add Dataset for Datagridview with custom Column*/
                    dataGridView1.Columns.Clear();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ItemCode", typeof(string));
                    //dt.Columns.Add("Description", typeof(string));
                    dt.Columns.Add("UomEntry", typeof(string));
                    //dt.Columns.Add("UomCode", typeof(string));
                    dt.Columns.Add("Quantity", typeof(string));
                    dt.Columns.Add("UnitPrice", typeof(string));
                    dt.Columns.Add("WarehouseCode", typeof(string));
                    // dt.Columns.Add("WarehouseName", typeof(string));
                    dt.Columns.Add("DiscountPercent", typeof(string));
                    dt.Columns.Add("LineTotal", typeof(string));
                    for (int i = 0; i < arr.Values.Lines.Count; i++)
                    {
                        
                        dt.Rows.Add(
                            arr.Values.Lines[i].ItemCode,
                            arr.Values.Lines[i].UomEntry,
                            arr.Values.Lines[i].Quantity,
                            arr.Values.Lines[i].UnitPrice,
                            arr.Values.Lines[i].DiscountPercent,
                            arr.Values.Lines[i].WarehouseCode,                            
                            arr.Values.Lines[i].LineTotal
                            );
                    }

                    //set data source for datagridview base on datatable "dt"
                    dataGridView1.DataSource = dt;
                    
                    //set texbox of header form
                    DocDate.Text = arr.Values.PostingDate.ToString();
                    textBox1.Text = arr.Values.DocEntry.ToString();
                    DocNum.Text = arr.Values.DocNum.ToString();
                    DocDate.Text = arr.Values.PostingDate.ToString();
                    DocDueDate.Text = arr.Values.DeliveryDate.ToString();
                    TaxDate.Text = arr.Values.DocumentDate.ToString();
                    CardCode.Text = arr.Values.CardCode.ToString();
                    SalesPersonCode.Text = arr.Values.CardName.ToString();
                }
                else
                {
                    MessageBox.Show(string.Format("Status Code == {0}", myResp.StatusCode));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
