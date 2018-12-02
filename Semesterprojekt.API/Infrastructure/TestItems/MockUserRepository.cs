//using Semesterprojekt.API.Presentation.Models;
//using Semesterprojekt.Core.Entites;
//using Semesterprojekt.Core.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Semesterprojekt.API.Infrastructure.TestItems
//{
//    public class MockUserRepository : IUserRepository
//    {
//        private readonly List<UserForLoginDto> _users;

//        public MockUserRepository()
//        {
//            _users = new List<UserForLoginDto>()
//            {
//                new UserForLoginDto() { Username = "bobby", Password = "password123"},
//                new UserForLoginDto() { Username = "gitte", Password = "fakingbish"}
//            };

//        }
//        public Task<User> Login(string username, string password)
//        {
//            var user = _users.FirstOrDefault(x => x.Username == username);

//            if (user == null)
//                return null;

//            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
//                return null;

//            return user;
//        }

//        public Task<User> Register(User user, string password)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> UserExists(string username)
//        {
//            throw new NotImplementedException();
//        }

//        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
//        {
//            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
//            {
//                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

//                for (int i = 0; i < computedHash.Length; i++)
//                {
//                    if (computedHash[i] != passwordHash[i]) return false;
//                }
//            }
//            return true;
//        }
//    }
//}
