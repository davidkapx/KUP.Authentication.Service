using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Text;


namespace KUP.Authentication.Business.Components.Security
{
    public class RijndaelCrypto
    {
        // this var has to be exactly 16 chars.
        private static readonly string INIT_VECTOR = "32A7033173D84351";

        public static byte[] EncryptToBytes(byte[] plainText)
        {
            var aes = System.Security.Cryptography.Aes.Create();

            byte[] salt = Encoding.ASCII.GetBytes(INIT_VECTOR.Length.ToString());
            Rfc2898DeriveBytes secretKey = new Rfc2898DeriveBytes(INIT_VECTOR, salt);

            
            //ICryptoTransform encryptor = rijCipher.CreateEncryptor(secretKey.GetBytes(32), secretKey.GetBytes(16));
            ICryptoTransform encryptor = aes.CreateEncryptor(secretKey.GetBytes(32), secretKey.GetBytes(16));
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainText, 0, plainText.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipheredBytes = memStream.ToArray();
            memStream.Dispose();
            cryptoStream.Dispose();
            return cipheredBytes;
        }
        public static byte[] EncryptToBytes(string plainText)
        {
            return EncryptToBytes(Encoding.UTF8.GetBytes(plainText.Trim()));
        }

        public static string EncryptToString(byte[] plainText)
        {
            return Convert.ToBase64String(EncryptToBytes(plainText));
        }
        public static string EncryptToString(string plainText)
        {
            return EncryptToString(Encoding.UTF8.GetBytes(plainText.Trim()));
        }

        public static byte[] DecryptToBytes(byte[] cipherText)
        {
            var aes = System.Security.Cryptography.Aes.Create();
            byte[] salt = Encoding.ASCII.GetBytes(INIT_VECTOR.Length.ToString());
            Rfc2898DeriveBytes secretKey = new Rfc2898DeriveBytes(INIT_VECTOR, salt);
            ICryptoTransform decryptor = aes.CreateDecryptor(secretKey.GetBytes(32), secretKey.GetBytes(16));
            MemoryStream memStream = new MemoryStream(cipherText);
            CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read);
            byte[] plainText = new byte[cipherText.Length];
            int decryptedCount = cryptoStream.Read(plainText, 0, plainText.Length);
            memStream.Dispose();
            cryptoStream.Dispose();
            return plainText;
        }
        public static byte[] DecryptToBytes(string cipherText)
        {
            return DecryptToBytes(Encoding.UTF8.GetBytes(cipherText.Trim()));
        }

        public static string DecryptToString(byte[] cipherText)
        {
            return (Encoding.Unicode.GetString(DecryptToBytes(cipherText), 0, cipherText.Length));
        }
        public static string DecryptToString(string cipherText)
        {
            return DecryptToString(Encoding.UTF8.GetBytes(cipherText.Trim()));
        }
    }
}
