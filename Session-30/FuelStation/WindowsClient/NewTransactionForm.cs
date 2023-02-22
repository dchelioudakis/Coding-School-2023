using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClient {
    public partial class NewTransactionForm : Form {

        public HttpClient sharedClient;
        public NewTransactionForm(HttpClient httpClient) {
            InitializeComponent();
            this.sharedClient = httpClient;
        }
    }
}
