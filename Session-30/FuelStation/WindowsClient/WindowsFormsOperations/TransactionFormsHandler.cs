using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.WindowsFormsOperations {
    public class TransactionFormsHandler {
        public TransactionFormsHandler() {

        }

        public async Task Create(HttpClient httpClient) {
            TransactionCreateForm transactionCreateForm = new TransactionCreateForm(httpClient);
            transactionCreateForm.ShowDialog();
        }

        public async Task Edit(HttpClient httpClient, int transactionId) {
            TransactionEditForm transactionEditForm = new TransactionEditForm(httpClient, transactionId);
            transactionEditForm.ShowDialog();
        }

        public async Task Details(HttpClient httpClient, int transactionId) {
            TransactionDetailsForm transactionDetailsForm = new TransactionDetailsForm(httpClient, transactionId);
            transactionDetailsForm.ShowDialog();
        }
    }
}
