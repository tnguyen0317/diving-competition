﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhopp
{
    public class Auth
    {
        public Auth()
        {
        }

        public bool PasswordsMatch(string hashedGivenPassword, string hashedStoredPassword)
        {
            return (hashedGivenPassword == hashedStoredPassword);
        }
    }
}
