using System.Text;

namespace CustomerCardGeneration {
    public class CustomerCardGenerator {
        public string GenerateCardNumber() {
            StringBuilder sb = new StringBuilder();
            sb.Append("A");
            Random random = new Random();
            for (int i = 0; i < 14; i++) {
                sb.Append(random.Next(0, 9).ToString());
            }
            return sb.ToString();
        }
    }
}