﻿using DataLayer;
using DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class LoginService
    {
        private readonly LoginRepository _loginRepository;
        public LoginService(LoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public void AddUser(User user)
        {
            _loginRepository.AddUser(user);
        }
        public User GetUserById(int id)
        {
           return _loginRepository.GetUserById(id);
        }
        public string GetUserByEmailAndPassword(string email, string password)
        {
            var token = _loginRepository.GetUserByEmailAndPassword(email, password);
            return token;
        }
    }
}
