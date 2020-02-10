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
            //number 1
            Hash.Md5("secret");
            Hash.sha1("secret");           
            Hash.sha256("secret");
            Hash.sha512("secret");
            Console.ReadLine();
            Console.Clear();
            //number 2
            var message = CipherClass.encrypt("nyobian","test1");

            var decrypt = CipherClass.decrypt(message, "test1");
            Console.WriteLine(message);
            Console.WriteLine(decrypt);
            Console.ReadLine();
            Console.Clear();

            var log = new SimpleLogger();
            log.Debug("ini debut");
            log.Error("ini error");
            log.Info("ini info");
            log.Warning("ini warning");



            //number 5
            Cart cart = new Cart();

            cart.AddItem(1, 30000, 3)
                .AddItem(2, 10000)
                .AddItem(3, 5000, 2)
                .RemoveItem(2)
                .AddItem(4, 400, 6)
                .AddDiscount(50);

            Console.WriteLine(Cart.TotalItems());
            Console.WriteLine(Cart.TotalQuantity());
            Console.WriteLine(Cart.TotalPrice());
            Cart.ShowAllItems();
            Cart.Checkout();
            Console.ReadLine();
            Console.Clear();



        }


    }

}



