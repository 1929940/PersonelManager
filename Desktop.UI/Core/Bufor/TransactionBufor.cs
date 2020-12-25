using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desktop.UI.Core.Helpers.Enums;

namespace Desktop.UI.Core.Bufor {
    public class TransactionBufor<T> where T : BaseEntity {

        private List<BuforObject<T>> BuforData { get; set; }
        private readonly BaseRequestHandler<T> _handler;

        public TransactionBufor(BaseRequestHandler<T> handler) {
            _handler = handler;
            BuforData = new List<BuforObject<T>>();
        }

        public void Add(T value) {
            AddToBufor(Status.Added, value);
        }
        public void Modify(T value) {
            AddToBufor(Status.Modified, value);
        }
        public void Remove(T value) {
            AddToBufor(Status.Removed, value);
        }
        public void Flush(int employeeId) {
            foreach (var data in BuforData) {
                SetParentId(data.Value, employeeId);
                switch (data.Status) {
                    case Status.Added:
                        _handler.Create(data.Value);
                        break;
                    case Status.Modified:
                        _handler.Update(employeeId, data.Value);
                        break;
                    case Status.Removed:
                        _handler.Delete(data.Value.Id);
                        break;
                }
            }
            BuforData.Clear();
        }

        public async Task FlushAsync(int parentId) {
            foreach (var data in BuforData) {
                SetParentId(data.Value, parentId);
                switch (data.Status) {
                    case Status.Added:
                        await _handler.CreateAsync(data.Value);
                        break;
                    case Status.Modified:
                        await _handler.UpdateAsync(data.Value.Id, data.Value);
                        break;
                    case Status.Removed:
                        await _handler.DeleteAsync(data.Value.Id);
                        break;
                }
            }
            BuforData.Clear();
        }

        public bool Contains(T value) => BuforData.Exists(x => x.Value == value);

        public bool AnyQueuedRemovals() => BuforData.Any(x => x.Status == Status.Removed);

        private void SetParentId(T value, int id) {
            switch (value) {
                case PersonelDocument doc:
                    doc.Employee = new EmployeeSimplified() { Id = id };
                    break;
                case Leave leave:
                    leave.Employee = new EmployeeSimplified() { Id = id };
                    break;
                case Advance advance:
                    advance.Contract = new ContractSimplified() { Id = id };
                    break;
            }
        }

        private void AddToBufor(Status status, T value) {
            BuforData.Add(new BuforObject<T>() {
                Status = status,
                Value = value
            });
        }
    }
}