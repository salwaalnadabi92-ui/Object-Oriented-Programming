namespace OOP_Part1
{
    class Room
    {
        int roomNumber;
        string roomType;
        double pricePerNight;
        bool   isAvailable;


    }

    class Guest
    {
            int     guestId;
            string  guestName;
            int     roomNumber;
            DateTime checkInDate;
            int      totalNights;



    }












    internal class Program

    {
        public static void displayRoom()
        {

        }

        public static void displayGuest()
        {

        }
        public static void  calculateTotalCost()

        {

        }


        static void Main(string[] args)
        {

            List<Room> rooms = new List<Room>();


            List<Guest> guests = new List<Guest>();






            bool exit = false;

            while (exit == false)
            {

                Console.WriteLine(" =======================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM ");
                Console.WriteLine(" =======================================");
                Console.WriteLine("1.Add New Room ");
                Console.WriteLine("2.Register New Guest ");
                Console.WriteLine("3.Book a Room for a Guest");
                Console.WriteLine("4.Search & Filter Rooms ");
                Console.WriteLine("5.Guest & Booking Statistics. ");
                Console.WriteLine("6.Check Out a Guest");
                Console.WriteLine("7.Remove Unavailable Rooms ");
                Console.WriteLine("0.Exit");
                Console.WriteLine("========================================");
                Console.WriteLine("  Enter your choose");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:

                       

                        break;

                    case 2:
                    

                        break;

                    case 3:
                      

                        break;

                    case 4:

                     

                        break;

                    case 5:


                        break;

                    case 6:



                        break;

                    case 7:


                    default:

                        break;

                }//switch


                Console.WriteLine("Enter any key");

                Console.ReadKey();
                Console.Clear();

            }//while


























































































































        }
    }
}
