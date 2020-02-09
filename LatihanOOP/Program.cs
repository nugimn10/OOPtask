using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;



namespace LatihanOOP
{
    class program 
    {
        static void Main(string[] args)
        {
            //md 1
            Hash.Md5("secret");
            Hash.sha1("secret");           
            Hash.sha256("secret");
            Hash.sha512("secret");
            Console.ReadLine();
            Console.Clear();

            var message = CipherClass.encrypt("nyobian","test1");

            var decrypt = CipherClass.decrypt(message, "test1");
            Console.WriteLine(message);
            Console.WriteLine(decrypt);

            // Auth.login( username: "root", password: "secret");

            //Test Number 4



        }


    }

}



