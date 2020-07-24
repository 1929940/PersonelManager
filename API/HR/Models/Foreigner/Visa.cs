
namespace API.HR.Models {
    public class Visa : PersonelDocumentEntity {
        public string Type { get; set; }
        public Visa() {
            Type = "D";
        }
    }
}
