using System;
using Enumeracao.Entities;  //chamando a class Order
using Enumeracao.Entities.Enums; //chamando a class Enums

namespace Enumeracao {
    internal class Program {
        static void Main(string[] args) {
            /**
             * 
             * Enumeracao serve para criar meio que "Ciclo de vida"
             * do Objeto e deixa o codigo mais organizado
             * 
             **/

            //instanciando a class
            Order order = new Order(1080, DateTime.Now, OrderStatus.PendingPayment);

            Console.WriteLine(order);

            //convertendo um tipo "enum" para string
            string test = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(test + " Tipo String");

            //convertendo para o tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");  //obs: tem que ser igual ao que esta na OrderStatus

            Console.WriteLine(os + " Tipo Enum");
        }
    }
}
