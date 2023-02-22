using System.Text.Json;

namespace SerializeLib {
    
    public class Serializer {

        public void Serialize(object obj) {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(obj);
        }

        public T Deserialize<T>(string jsonString) {

            T? obj = JsonSerializer.Deserialize<T>(jsonString);

            return obj;
        }

    }
    
}