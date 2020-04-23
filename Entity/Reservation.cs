using System;

namespace Entity
{
    public class Reservation
    {     
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            this.RoomNumber = roomNumber;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;

        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now){
                return "Reservation dates for update must be future dates";
            }if(checkOut <= checkIn){
                return "Check-out date must be after Check-In";
            }

            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            
            return null;


        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room "
            + RoomNumber
            + ", check-in: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights";
        }
    }
}