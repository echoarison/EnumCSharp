using System;
using Enumeracao.Entities.Enums;    //especificando aonde está o meu "Objeto Enum"

namespace Enumeracao.Entities
{
    internal class Order
    {
        //atributo
        private int _id;
        private DateTime _moment;
        private OrderStatus _status;

        //Construtor
        public Order()
        {

        }

        public Order(int id, DateTime moment, OrderStatus status) {

            _id = id;
            _moment = moment;
            _status = status;
        
        }

        //set e get(Encapsulamento Manual)

        public int GetId()
        {

            return _id;

        }

        public DateTime GetMoment()
        {

            return _moment;

        }

        public OrderStatus GetStatus() 
        {

            return _status;

        }

        public void SetId(int id) 
        {

            _id = id;

        }

        public void SetMoment(DateTime moment) 
        {

            _moment = moment;

        }

        public void SetStatus(OrderStatus status) 
        {

            _status = status;

        }

        public override string ToString()
        {
            return GetId().ToString() 
                + ", " + GetMoment() 
                + ", " 
                + GetStatus();
            /*return _id.ToString() 
                + ", " 
                + _moment 
                + ", " 
                + _status;*/
        }
    }
}
