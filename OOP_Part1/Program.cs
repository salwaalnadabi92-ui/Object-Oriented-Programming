using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Part1
{
    class Room
    {
      public  int roomNumber;
      public string roomType;
      public double pricePerNight;
      public bool   isAvailable;


        public  void displayRoom()
        {
            Console.WriteLine(roomNumber);
            Console.WriteLine(roomType);
            Console.WriteLine(pricePerNight);
            Console.WriteLine(isAvailable);
        }
    }



    class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;
        public double pricePerNight;

        public void displayGuest()

        {

            Console.WriteLine(" ID :" + guestId);
            Console.WriteLine("name: " + guestName);
            Console.WriteLine("  room number " + roomNumber);
            Console.WriteLine(" date" + checkInDate);
            Console.WriteLine(" total Night" + totalNights);
        }

        public  double alculateTotalCost()
        {
            return totalNights * pricePerNight;
        }

    }





    internal class Program

    {
      

        

        static void Main(string[] args)
        {

            List<Room> rooms = new List<Room>();

            rooms.Add(new Room
            {
                roomNumber = R101
                roomType = " single",
                pricePerNight = 150,
                isAvailable = false,
            });
         
            rooms.Add(new Room
            {
                roomNumber ="201",
                roomType = "Suite ",
                pricePerNight = 250,
                isAvailable = true,
            });

            rooms.Add(new Room
            {
                roomNumber ="301",
                roomType = "double ",
                pricePerNight = 200,
                isAvailable = false,
            });

            rooms.Add(new Room
            {
                roomNumber ="401",
                roomType = "single ",
                pricePerNight = 150,
                isAvailable = true,
            });

           
            rooms.Add(new Room
            {
                roomNumber ="501",
                roomType = "double ",
                pricePerNight = 200,
                isAvailable = true,
            });

            rooms.Add(new Room
            {
                roomNumber ="601",
                roomType = "double ",
                pricePerNight = 200,
                isAvailable = true,
            });
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

                        Console.WriteLine(" Enter: room number");
                        int  newNumber=int.Parse(Console.ReadLine());


                        if (newNumber <= 0)
                        {
                            Console.WriteLine("Please Enter Postive Number");
                            return;


                        }

                            if (rooms.Any(r => r.roomNumber == newNumber))
                            {
                                Console.WriteLine("Room already exites");
                            }

                            else
                            {


                                Console.WriteLine(" Enter: room type (Single / Double / Suite)");
                               string newType = Console.ReadLine();
                                Console.WriteLine(" Enter:price per night");
                                double newPrice = double.Parse(Console.ReadLine());


                            if (newPrice <= 0)
                            {
                                Console.WriteLine("Price must be positive.");
                                return;
                            }


                                Room newRoom = new Room();

                                newRoom.roomNumber = newNumber;
                                newRoom.roomType = newType;
                                newRoom.pricePerNight = newPrice;
                                newRoom.isAvailable = true;
                                rooms.Add(newRoom);
                                Console.WriteLine("New Room Add Successfuly");
                                Console.WriteLine("Detailes About New Room  ");

                                newRoom.displayRoom();
                                Console.WriteLine("Total Room:" + rooms.Count);
                            }
                         


                        break;

                    case 2:
                        Console.WriteLine("Enter  guest name ");
                        string name =Console.ReadLine();
                        Console.WriteLine("check in data");
                        string chackdata=Console.ReadLine();
                        Console.WriteLine("Number of Nights  TO Stay ");
                        int nightnumber=int.Parse(Console.ReadLine());
                        if (nightnumber < 0)
                        {
                            Console.WriteLine("Please Enter Postive Number");
                            return;
                        }

                            string guestID =guests.Count()+1 +"G000";
                          

                        Guest newGuest = new Guest();
                            
                                newGuest.guestId = guestID;
                                newGuest.guestName = name;
                                newGuest.roomNumber = "Not Assigned";
                                newGuest.checkInDate = chackdata;
                                newGuest.totalNights = nightnumber;
                          
                            guests.Add(newGuest);
                        Console.WriteLine("========================================");
                        Console.WriteLine(" guest registerd succsssfuly ");
                       newGuest.displayGuest();
                     

                        break;

                    case 3:

                        Console.WriteLine(" Enter guest id");
                        string guestId = Console.ReadLine();
                        Console.WriteLine(" Enter room number");
                        string roomNumber=Console.ReadLine();

                        Guest   Guest = guests.FirstOrDefault(g => g.guestId == guestId);

                        Room Room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);

                        if(Room == null )

                        {
                           Console.WriteLine(" ROOM NOT FOUND   ");
                            return;
                        }
                        if(Guest== null)
                        {
                            Console.WriteLine("GUEST NOT FOUND "); 
                            return;
                        }
                        if(!Room.isAvailable)
                        {
                            Console.WriteLine(" Room is already booked ");
                            return;
                        }


                        Guest.roomNumber = Room.roomNumber.ToString();
                       
                        Room.isAvailable =false;


                        Console.WriteLine("Booking Confirmed");
                        Console.WriteLine("Guest Name:" + Guest.guestName);
                        Console.WriteLine("Room Number:" + Room.roomNumber);
                        Console.WriteLine("Room Type: " + Room.roomType);
                        Console.WriteLine("Price Per Night:" + Room.pricePerNight);
                        Console.WriteLine("Total Nights:" + Guest.totalNights);

                        Console.WriteLine("Total Cost:" + Guest.alculateTotalCost());





                            break;

                    case 4:

                        bool exit1=false;
                        while (exit1 == false)
                        {
                            Console.WriteLine("(1)Show all available rooms");
                            Console.WriteLine("(2)Filter by room type");
                            Console.WriteLine("(3)Filter by max price");
                            Console.WriteLine("(4)Room price statistics");
                            Console.WriteLine("(0) Back");
                            Console.WriteLine("Enter your choose");
                            int choose1 = int.Parse(Console.ReadLine());
                            switch (choose1)
                            {

                                case 1:
                                    var selectAvalableRoom = rooms.Where(r => r.isAvailable).OrderBy(r => r.pricePerNight).ToList();//Linq function where 

                                    Console.WriteLine("aviable rooms" +  selectAvalableRoom.Count );

                                    foreach (var item in selectAvalableRoom)
                                    {

                                        Console.WriteLine(item);
                                    }

                                    break;

                                case 2:

                                    //Console.WriteLine("ENTER ROOM TYPE");
                                    //var selectRoomType = rooms.Where(r => r.isAvailable).ToList();


                                    //foreach (Room item in selectRoomType)
                                    //    Console.WriteLine(item);


                                    break;

                                case 3:






                                    break;

                                case 4:
                                    var price = rooms.Select(r => r.pricePerNight);
                                    Console.WriteLine();


                                    break;

                                case 0:
                                    return;

                                    break;


                            }

                        }







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
