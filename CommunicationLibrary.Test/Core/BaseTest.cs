using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Core;
using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationLibrary.Test.Core {
    public abstract class BaseTest<T> where T : BaseEntity {
        protected BaseRequestHandler<T> _requestHandler;
        protected T _baseRow;
        protected T _updatedRow;
        protected int _rowCount;
        protected int _id;
        protected IEqualityComparer<T> _comparer;
        public BaseTest() {
            Settings.Url = @"https://localhost:44345";

            if (Settings.Token == null) {
                var login = new UserRequestHandler().Login("Jan.Kowalski@PersonelManager.pl", "Macko");
                Settings.Token = login.Token;
            }
        }

        //EVERY NEW TEST == NEW BaseTest is created!



        [Fact]
        public void CRUD_ShouldPass() {
            int id;
            T row;
            IEnumerable<T> rows;
            //Create
            row = _requestHandler.Create(_baseRow);
            Assert.Equal<T>(row, _baseRow, _comparer);

            id = row.Id;
            _updatedRow.Id = id;

            //Update
            _requestHandler.Update(id, _updatedRow);
            row = _requestHandler.Get(id);
            Assert.Equal(_updatedRow, row, _comparer);

            //Get One
            row = _requestHandler.Get(id);
            Assert.Equal<T>(_updatedRow, row, _comparer);

            //Get All
            rows = _requestHandler.Get();
            Assert.Contains<T>(row, rows, _comparer);

            //Remove
            _requestHandler.Delete(id);
            row = _requestHandler.Get(id);
            Assert.NotEqual<T>(_updatedRow, row, _comparer);
        }

        [Fact]
        public async Task CRUD_ShouldPassAsync() {
            int id;
            T row;
            IEnumerable<T> rows;
            //Create
            row = await _requestHandler.CreateAsync(_baseRow);
            Assert.Equal<T>(row, _baseRow, _comparer);

            id = row.Id;
            _updatedRow.Id = id;

            //Update
            await _requestHandler.UpdateAsync(id, _updatedRow);
            row = await _requestHandler.GetAsync(id);
            Assert.Equal(_updatedRow, row, _comparer);

            //Get One
            row = await _requestHandler.GetAsync(id);
            Assert.Equal<T>(_updatedRow, row, _comparer);

            //Get All
            rows = await _requestHandler.GetAsync();
            Assert.Contains<T>(row, rows, _comparer);

            //Remove
            await _requestHandler.DeleteAsync(id);
            row = await _requestHandler.GetAsync(id);
            Assert.NotEqual<T>(_updatedRow, row, _comparer);
        }


        //[Fact]
        //public void AddRow_ShouldPass() {
        //    T rowCreated = _requestHandler.Create(_baseRow);
        //    _id = rowCreated.Id;
        //    Assert.Equal<T>(rowCreated, _baseRow, _comparer);
        //}

        //[Fact]
        //public void GetRow_ShouldPass() {
        //    T rowCreated = _requestHandler.Create(_baseRow);
        //    T row = _requestHandler.Get(_baseRow.Id);
        //    Assert.Equal<T>(row, _baseRow, _comparer);
        //}

        //[Fact]
        //public void UpdateRow_ShouldPass() {
        //    _requestHandler.Update(_updatedRow.Id, _updatedRow);
        //    T updatedRow = _requestHandler.Get(_updatedRow.Id);
        //    Assert.Equal(_updatedRow, updatedRow, _comparer);
        //}

        //[Fact]
        //public void GetAll_ShouldPass() {
        //    IEnumerable<T> rows = _requestHandler.Get();
        //    _rowCount = rows.Count();
        //    Assert.NotEmpty(rows);
        //}

        //[Fact]
        //public void RemoveRow_ShouldPass() {
        //    _requestHandler.Delete(_baseRow.Id);
        //    T row = _requestHandler.Get(_baseRow.Id);
        //    Assert.Null(row);
        //}

        //[Fact]
        //public void RowCountChanged_ShouldPass() {
        //    IEnumerable<T> rows = _requestHandler.Get();
        //    Assert.NotEqual(rows.Count(), _rowCount);
        //}
        //#endregion
        //#region Async

        //[Fact]
        //public async void AddRowAsync_ShouldPass() {
        //    T rowCreated = await _requestHandler.CreateAsync(_baseRow);
        //    _baseRow.Id = rowCreated.Id;
        //    _updatedRow.Id = rowCreated.Id;
        //    Assert.Equal<T>(rowCreated, _baseRow, _comparer);
        //}

        //[Fact]
        //public async void GetRowAsync_ShouldPass() {
        //    T row = await _requestHandler.GetAsync(_baseRow.Id);
        //    Assert.Equal<T>(row, _baseRow, _comparer);
        //}

        //[Fact]
        //public async void UpdateRowAsync_ShouldPass() {
        //    await _requestHandler.UpdateAsync(_updatedRow.Id, _updatedRow);
        //    T updatedRow = await _requestHandler.GetAsync(_updatedRow.Id);
        //    Assert.Equal(_updatedRow, updatedRow, _comparer);
        //}

        //[Fact]
        //public async void GetAllAsync_ShouldPass() {
        //    IEnumerable<T> rows = await _requestHandler.GetAsync();
        //    _rowCount = rows.Count();
        //    Assert.NotEmpty(rows);
        //}

        //[Fact]
        //public async void RemoveRowAsync_ShouldPass() {
        //    await _requestHandler.DeleteAsync(_baseRow.Id);
        //    T row = _requestHandler.Get(_baseRow.Id);
        //    Assert.Null(row);
        //}

        //[Fact]
        //public async void RowCountChangedAsync_ShouldPass() {
        //    IEnumerable<T> rows = await _requestHandler.GetAsync();
        //    Assert.NotEqual(rows.Count(), _rowCount);
        //}
        //#endregion
    }
}