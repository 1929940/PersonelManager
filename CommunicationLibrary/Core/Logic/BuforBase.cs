using CommunicationLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static CommunicationLibrary.Core.Models.Enums;

namespace CommunicationLibrary.Core.Logic {
    public class BuforBase<T> where T : BaseEntity {

        private List<BuforObject<T>> Data { get; set; }

        public BuforBase() {
            Data = new List<BuforObject<T>>();
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
        public void Flush() {

        }

        /*
         * Mam dwie alternatywy - albo to jest personel doc albo leave
         * Moze sprawdzic ktory, rzutowac na konkretny typ?
         * I do tego typu przypisac?
         */

        public void SetEmployeeId(int id) {

        }


        private void AddToBufor(Status status, T value) {
            Data.Add(new BuforObject<T>() {
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
