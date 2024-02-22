using System;

namespace Back_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
            room.RoomSoldOutevent += OnRoomSoldOut;

            room.ReserveSeats();
            room.ReserveSeats();
            room.ReserveSeats();
            room.ReserveSeats();
            room.ReserveSeats();
            room.ReserveSeats();
            room.ReserveSeats();

            Console.ReadKey();
        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada!");
        }
    }
    
    public class Room
    {
        // metodo construtor
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }

        private int seatsInUse = 0;

        // acentos que a sala pode receber
        public int Seats { get; set; }

        public void ReserveSeats()
        {
            seatsInUse ++;
            if(seatsInUse >= Seats)
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento Reservado");
                //Console.ReadKey();
            }
        }

        public event EventHandler RoomSoldOutevent;

        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutevent;
            handler?.Invoke(this, e);
        }
    }
}

