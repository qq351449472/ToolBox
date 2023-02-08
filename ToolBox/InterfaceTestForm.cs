using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox.Model;

namespace ToolBox
{
    public partial class InterfaceTestForm : Form
    {
        public InterfaceTestForm()
        {
            InitializeComponent();
        }

        private void bt_Test_Click(object sender, EventArgs e)
        {
            rt_Result.Text = string.Empty;
            try
            {
                string url = rt_Address.Text;
                string jsonPostData = rt_InPara.Text;
                string strResult = PostUrl(url, jsonPostData);
                JToken parsedJson = JToken.Parse(strResult);
                rt_Result.Text = parsedJson.ToString(Formatting.Indented);
            }
            catch(Exception ex)
            {
                rt_Result.Text = ex.Message;
            }
        }
        public static string PostUrl(string url, string postData)
        {
            string result = "";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Proxy = null;
            req.Method = "POST";
            req.ContentType = "application/json";

            byte[] data = Encoding.UTF8.GetBytes(postData);

            req.ContentLength = data.Length;

            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);

                reqStream.Close();
            }

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            Stream stream = resp.GetResponseStream();

            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}
