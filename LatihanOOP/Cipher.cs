using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LatihanOOP
{


    //Need work on encapsulation

    public static class CipherClass
    {
        public static string encrypt(string input, string password)
        {
            try
            {
                string n = input;
                byte[] ch = UTF8Encoding.UTF8.GetBytes(n);
                string pw = password;
                MD5CryptoServiceProvider mdhash = new MD5CryptoServiceProvider();
                byte[] keyarray = mdhash.ComputeHash(UTF8Encoding.UTF8.GetBytes(pw));
                TripleDESCryptoServiceProvider tds = new TripleDESCryptoServiceProvider();
                tds.Key = keyarray;
                tds.Mode = CipherMode.ECB;
                tds.Padding = PaddingMode.PKCS7;
                ICryptoTransform itransform = tds.CreateEncryptor();
                byte[] result = itransform.TransformFinalBlock(ch, 0, ch.Length);
                string encryptresult = Convert.ToBase64String(result);
                return "Anyone without password cant read this message";

            }
            catch (Exception ex)
            {
                string filePath = @"/Users/Nugi/CsharpOOP/app.log";
                string errMsg = $"{ex.Message}";
                File.WriteAllText(filePath, errMsg);
                return errMsg;
            }
        }

        public static string decrypt(string input, string password)
        {
            try
            {
                string y = input.Replace("\0", null);
                byte[] etext = Convert.FromBase64String(y);
                string key = password;
                MD5CryptoServiceProvider mdhash = new MD5CryptoServiceProvider();
                byte[] keyarray = mdhash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tds = new TripleDESCryptoServiceProvider();
                tds.Key = keyarray;
                tds.Mode = CipherMode.ECB;
                tds.Padding = PaddingMode.PKCS7;

                ICryptoTransform itransform = tds.CreateDecryptor();
                byte[] result = itransform.TransformFinalBlock(etext, 0, etext.Length);
                string dencryptresult = UTF8Encoding.UTF8.GetString(result);
                return dencryptresult.ToString();
            }
            catch (Exception ex)
            {
                string filePath = @"/Users/Nugi/CsharpOOP/app.log";
                string errMsg = $"{ex.Message}";
                File.WriteAllText(filePath, errMsg);
                return errMsg;
            }
        }
    }
}
    
