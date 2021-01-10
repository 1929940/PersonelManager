using CommunicationAndCommonsLibrary.Business.Logic;
using CommunicationAndCommonsLibrary.Business.Requests;
using CommunicationAndCommonsLibrary.Core.Models;
using CommunicationAndCommonsLibrary.Core.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationAndCommonsLibrary.Test.Core {
    public abstract class BaseTest<T> where T : BaseEntity {
        protected BaseRequestHandler<T> _requestHandler;
        protected T _baseRow;
        protected T _updatedRow;
        protected int _id;
        protected IEqualityComparer<T> _comparer;
        public BaseTest() {
            ConnectionManager.Url = @"https://localhost:44345";

            if (ConnectionManager.Token == null) {
                var login = new UserRequestHandler().Login("Jan.Kowalski@PersonelManager.pl", "Macko");
                ConnectionManager.Token = login.Token;
            }
        }

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
    }
}