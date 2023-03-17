namespace SomerenModel
{
    public class Room
    {
        public int Id { get; set; }         // database id
        public int capacity { get; set; }     // Room Capacity
        public int floor { get; set; }   // Floor where room is 
        public string building { get; set; }      // Building where room is 
    }
}
