using System;

using DesafioPOO.Models;

    class Program
    {
        static void Main(string[] args)
        {

            // Criando um objeto Nokia
            Console.WriteLine("Smartphone Nokia: ");
            Smartphone Nokia = new Nokia(numero: "123456789", modelo: "ModeloNokia", imei: "IMEINokia", memoria: 64);
            Nokia.Ligar();
            Nokia.ReceberLigacao();
            Nokia.InstalarAplicativo("Facebook");

            Console.WriteLine("\n");

            // Criando um objeto Iphone

            Console.WriteLine("Smartphone Iphone: ");
            Smartphone Iphone = new Iphone(numero: "987654321", modelo: "ModeloIphone", imei: "IMEIIphone", memoria: 128);
            Iphone.Ligar();
            Iphone.ReceberLigacao();
            Iphone.InstalarAplicativo("Instagram");


        }
}

