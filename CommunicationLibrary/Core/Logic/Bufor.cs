﻿using CommunicationLibrary.Core.Models;
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

        public bool Contains(T value) => BuforData.Exists(x => x.Value == value);

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
