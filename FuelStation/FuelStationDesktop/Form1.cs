using System.Net;
using System.Net.Http;
using System.Security.Policy;
using FuelStation.DTOs;


namespace FuelStationDesktop {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            webGetMethod("https://localhost:7099/Customer");
            
        }


        public string webGetMethod(string URL) {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.ContentType = "application/x-www-form-urlencoded";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;
        }

        //HttpClient httpClient = new HttpClient();
        //HttpResponseMessage response = await httpClient.GetFromJsonAsync<List<CustomerListDto>>("Customer");

    }
}