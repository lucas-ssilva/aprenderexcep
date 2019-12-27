using System;
using execp.Entities;
using System.Collections.Generic;
using execp.Entities.Exceptions;

namespace execp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation r = new Reservation(room, checkin, checkout);

                Console.WriteLine(r);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());
                r.UpdateDates(checkin, checkout);
                Console.WriteLine(r);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Erro! \n\r" + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro ! \n\r " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("try Again");
            }
        }


    }
}

