﻿using System.Collections.Generic;
using Temistocles.DAO;
using Temistocles.Entity;

namespace Temistocles.Model {
    public class LoginModel {
        public static List<LoginEntity> Login(LoginEntity loginEntity) {
            return Logar.Login(loginEntity);
        }
    }
}
