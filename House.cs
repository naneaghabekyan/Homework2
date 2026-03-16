/*
 1. Ստեղծել House class
 ունի Room-ներ (composition)
 */
using System;
using System.Collections.Generic;


namespace House_Room
{
    public class Room
    {
        public int Window_num { get; private set; }
        public string Name { get; private set; }
        public Room(string name): this(0, name) { }
        public Room(int wind,string name)
        {
            Console.WriteLine("Ctor Room");
            Window_num = wind;
            Name = name;
        }
        ~Room() { Console.WriteLine("Dtor Room"); }

    }
    public class House
    {
        public double Area {  get; private set; }
        public List<Room> rooms { get; private set; }=new List<Room>();
        public House(int area) 
        {
            Console.WriteLine("Ctor House");
            Area = area;
        }

        public void RoomAdd(int wind, string name)
        {
            rooms.Add(new Room(wind,name));
        }

        public void RoomAdd(string name)
        {
            rooms.Add(new Room(name));
        }

        public void AboutHouse()
        {
            Console.WriteLine($"The area of the house is {Area}.\nRooms:");
            foreach (Room el in rooms)
                Console.WriteLine($"{el.Name}: {el.Window_num}");
        }
        ~House() { Console.WriteLine("Dtor House"); }
    }


}
