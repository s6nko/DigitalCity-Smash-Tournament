using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ST_BLL.Interfaces;

namespace ST_BLL.Infrastructure
{
    public class PasswordHasher : IPasswordHasher
    {
        public byte [] Hash(string password)
        {
            return SHA512.HashData(Encoding.UTF8.GetBytes(password));
        }
    }
}
