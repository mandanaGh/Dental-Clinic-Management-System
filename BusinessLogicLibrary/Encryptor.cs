using System.Security.Cryptography;
using System.Text;
using System.Security;
using System;
using System.IO;

namespace BusinessLogicLayer
{
    public static class Encryptor
    {
        public static string EncryptedString(string encryptionValue)
        {
            MD5 encryptor = new MD5CryptoServiceProvider();
            if (encryptionValue == null || encryptionValue == String.Empty)
                return null;
            return Convert.ToBase64String(encryptor.ComputeHash(Encoding.Unicode.GetBytes(encryptionValue)));
        }
    }
}