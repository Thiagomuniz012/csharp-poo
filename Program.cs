using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokiaPhone = new Nokia("123456789", "Nokia 8", 2019);
            Iphone iphone = new Iphone("987654321", "iPhone 12", "iOS 15");

            nokiaPhone.Ligar();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
