using System.ComponentModel.Design;

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
         public  string    guestId;
         public string  guestName;
         public  int   roomNumber;
         public string  checkInDate;
         public  int      totalNights;

        public  void displayGuest()
        {
            Console.WriteLine(guestId);
            Console.WriteLine(guestName);
            Console.WriteLine(roomNumber);
            Console.WriteLine(checkInDate);
            Console.WriteLine(totalNights);
        }


        //public static void calculateTotalCost()

        //{

        //}


    }










    internal class Program

    {
      

        

        static void Main(string[] args)
        {

            List<Room> rooms = new List<Room>();

            rooms.Add(new Room
            {
                roomNumber = 101,
                roomType = " single",
                pricePerNight = 150,
                isAvailable = false,
            });
         
            rooms.Add(new Room
            {
                roomNumber = 201,
                roomType = "Suite ",
                pricePerNight = 250,
                isAvailable = true,
            });

            rooms.Add(new Room
            {
                roomNumber = 301,
                roomType = "double ",
                pricePerNight = 200,
                isAvailable = false,
            });

            rooms.Add(new Room
            {
                roomNumber = 401,
                roomType = "single ",
                pricePerNight = 150,
                isAvailable = true,
            });

           
            rooms.Add(new Room
            {
                roomNumber = 501,
                roomType = "double ",
                pricePerNight = 200,
                isAvailable = true,
            });

            rooms.Add(new Room
            {
                roomNumber = 601,
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
                        int newNumber=int.Parse(Console.ReadLine());
                    

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
                        if(nightnumber <0)
                        {
                            Console.WriteLine("Please Enter Postive Number");
                            return;
                        }
                    
                            string guestID = name + "G001";
                          

                        Guest newGuest = new Guest();
                            
                                newGuest.guestId = guestID;
                                newGuest.guestName = name;
                                newGuest.roomNumber = "";
                                newGuest.checkInDate = chackdata;
                                newGuest.totalNights = nightnumber;
                          
                            guests.Add(newGuest);
                        Console.WriteLine("========================================");
                        Console.WriteLine(" guest registerd succsssfuly ");
                        Console.WriteLine(" ID :"+ guestID);
                        Console.WriteLine("name: " + name);
                        Console.WriteLine("room number :" + );
                        Console.WriteLine(" date"+ chackdata);
                        Console.WriteLine(" total Night"+ nightnumber);
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
