namespace SomerenModel
{
    public class Room
    {
        public int room_ID { get; set; }         // database id
        public int capacity { get; set; }     // Room Capacity
        public int floor { get; set; }   // Floor where room is 
        public string building { get; set; }      // Building where room is 
    }
}
