﻿using CommunicationLibrary.Business.Comparers;
using CommunicationLibrary.Business.Models;
using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Test.Core;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationLibrary.Test.Business {
    public class UserTest : BaseTest<User> {
        private UserRequestHandler _userRequestHandler;

        public UserTest() {
            _requestHandler = _userRequestHandler = new UserRequestHandler();
            _comparer = new UserComparer();

            _baseRow = new User() {
                FirstName = "Witold",
                LastName = "Witkowski",
                Email = "Witkowski@poczta.pl",
                Role = "Kierownik",
                IsActive = true,
            };

            _updatedRow = new User() {
                FirstName = "WITOLD",
                LastName = "WITKOWSKI",
                Email = "WITKOWSKI@POCZTA.PL",
                Role = "Kierownik",
                IsActive = true,
            };

        }
        [Fact]
        public void LoginSuccessful_ShouldPass() {
            var loginResponse = _userRequestHandler.Login("Jan.Kowalski@PersonelManager.pl", "Macko");
            Assert.False(string.IsNullOrEmpty(loginResponse.Token));
        }

        [Fact]
        public async Task LoginSuccessfulAsync_ShouldPass() {
            var loginResponse = await _userRequestHandler.LoginAsync("Jan.Kowalski@PersonelManager.pl", "Macko");
            Assert.False(string.IsNullOrEmpty(loginResponse.Token));
        }

        [Fact]
        public async Task LoginFailed_ShouldPass() {
            var loginResponse = await _userRequestHandler.LoginAsync("Kwiaty@wp.pl", "Tulipan");
            Assert.True(string.IsNullOrEmpty(loginResponse.Token));
        }

        [Fact]
        public async Task LoginFailedAsync_ShouldPass() {
            var loginResponse = await _userRequestHandler.LoginAsync("Kwiaty@wp.pl", "Tulipan");
            Assert.True(string.IsNullOrEmpty(loginResponse.Token));
        }

        [Fact]
        public void RequestPasswordReset_ShouldPass() {
            _userRequestHandler.RequestPasswordReset("Jan.Nowak@PersonelManager.pl");
            Assert.True(true);
        }

        [Fact]
        public async Task RequestPasswordResetAsync_ShouldPass() {
            await _userRequestHandler.RequestPasswordResetAsync("Jan.Nowak@PersonelManager.pl");
            Assert.True(true);
        }
    }
}