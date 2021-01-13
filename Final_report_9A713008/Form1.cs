using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Final_report_9A713008
{
    public partial class FM1 : Form
    {
        private object pB1Result;
        public FM1()
        {
            InitializeComponent();
        }
        private resp GetImages(string albumHash, string clientId)
        {
            resp result = null;
            try {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.imgur.com/3/album/I6ByU0k/images");
                //Add Header 
                WebHeaderCollection webHeaderCollection = request.Headers;
                webHeaderCollection.Add("Authorization", $"Client-ID {clientId}");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string json = readStream.ReadToEnd();

                result = JsonConvert.DeserializeObject<resp>(json);
            }
            catch (Exception exp) {
                Console.WriteLine(exp.ToString());
            }
            return result;
        }
        private void pB1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // 抓API list 出有多少東西
            var m = GetImages("I6ByU0k", "5a7fc60445b5045");

            if (m == null) {
                return;
            }
            // download 一張照片下來  
            pB1.Image = m;
        }

    }
}
