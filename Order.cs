using System;
using System.Collections.Generic;


namespace Order
{
    internal class Order
    {
        private string _ordernumber;
        private DateTime _date;
        private List<string> Items = new List<string>();
        public string OrderNumber 
        {  
            get { return _ordernumber; }
            private set
            {
                if (value == null || value == "")
                    Console.WriteLine("The order needs number!");
                else
                   _ordernumber = value;
            }
        }

        
        public Order(string ordnum)
        {
            OrderNumber = ordnum;
            _date = DateTime.Now;
        }
        public void AddItems(string item) 
        {
            Items.Add(item);
        }


        public void ShowOrder()
        {
            Console.WriteLine($"{OrderNumber} order was made in {_date}.\nThe items:");
            foreach (string item in Items) 
            {
                Console.WriteLine(item);
            }
        }

    }
}
