using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static CommunicationLibrary.Core.Models.Enums;

namespace CommunicationLibrary.Core.Logic {

    public class Bufor<T> where T : BaseEntity {

        private List<BuforObject<T>> BuforData { get; set; }
        private readonly BaseRequestHandler<T> _handler;

        public Bufor(BaseRequestHandler<T> handler) {
            _handler = handler;
            BuforData = new List<BuforObject<T>>();
        }


        //TODO: Go with base entity instead of T
        //Convert base entity to whatever you're updating.
        //Figure out which requesthandler to use

        //I proly need employeeID - perhaps interface?


        /* 1. Rename EmployeeDataBufor
         * 2. Needs to be able store changes in personel docs and leaves
         * 3. needs to be able to set employee id to them all
         * 4. needs to be able to do update, modify, add rows
         * 
         * PROBLEMS:
         * How to tell if its medical doc or bhp? Its personel document
         * 
         * 
         * Just make this an abstract class and make bufor for leaves, and for documents
         */

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
                SetEmployeeId(data.Value, employeeId);
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

        public async Task FlushAsync(int employeeId) {
            foreach (var data in BuforData) {
                SetEmployeeId(data.Value, employeeId);
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

        /*
         * Mam dwie alternatywy - albo to jest personel doc albo leave
         * Moze sprawdzic ktory, rzutowac na konkretny typ?
         * I do tego typu przypisac?
         */

        /*
         * Potrzebuje klase nadrzedna - EmployeeBufor, gdzie beda 4 buffory Leave, i 3 pers doc, na tym etapie dodaje handlera
         */

        private void SetEmployeeId(T value, int id) {
            if (value is PersonelDocument doc) {
                doc.Employee = new EmployeeSimplified() { Id = id };
            } else if (value is Leave leave) {
                leave.Employee = new EmployeeSimplified() { Id = id };
            }
        }


        private void AddToBufor(Status status, T value) {
            BuforData.Add(new BuforObject<T>() {
                Status = status,
                Value = value
            });
        }

        public class BuforObject<T> where T : BaseEntity {

            public Status Status { get; set; }
            public T Value { get; set; }
        }

    }
}
