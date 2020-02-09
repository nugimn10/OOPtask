using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace LatihanOOP
{
    class Hash
    {
        public static void Md5(string source)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, source);

                Console.WriteLine(hash);

            }
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static void sha1(string source)
        {
            using (SHA1 sha1Hash = SHA1.Create())
            {
                string hash = GetSha1Hash(sha1Hash, source);

                Console.WriteLine(hash);

            }
        }

        static string GetSha1Hash(SHA1 sha1Hash, string input)
        {

            byte[] data = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static void sha256(string source)
        {
            using (SHA256 sha256hash = SHA256.Create())
            {
                string hash = GetSha256hash(sha256hash, source);

                Console.WriteLine(hash);

            }
        }

        static string GetSha256hash (SHA256 sha256hash, string input)
        {

            byte[] data = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static void sha512(string source)
        {
            using (SHA512 sha512hash = SHA512.Create())
            {
                string hash = GetSha512hash(sha512hash, source);

                Console.WriteLine(hash);

            }
        }

        static string GetSha512hash(SHA512 sha512hash, string input)
        {

            byte[] data = sha512hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

    }
}

