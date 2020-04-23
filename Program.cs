using System;
using Entity;

namespace Reserva
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn){
                Console.WriteLine("Error in reservation: Check-out date must be required");
            }else{
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now){
                    Console.WriteLine("Erro na reserva");
                }else if(checkOut <= checkIn){
                    Console.WriteLine("Erro na reserva, saida < entrada");
                }else{
                    reservation.UpdateDates(checkIn, checkOut);
                }

            }            
        }
    }
}
