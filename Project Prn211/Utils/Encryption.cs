using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_Prn211.Utils
{
    public class Encryption
    {
        private string fixedSalt ="dsfgvhirheagvbierafc";
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string saltedPassword = password + fixedSalt;

                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);

                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

}
