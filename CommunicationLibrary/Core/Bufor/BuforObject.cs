using CommunicationAndCommonsLibrary.Core.Models;

namespace CommunicationAndCommonsLibrary.Core.Bufor {
    public class BuforObject<T> where T : BaseEntity {
        public Status Status { get; set; }
        public T Value { get; set; }
    }
}
