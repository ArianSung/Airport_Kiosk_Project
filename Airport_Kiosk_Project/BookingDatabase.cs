using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Airport_Kiosk_Project.Page_Select_AirLines;

namespace Airport_Kiosk_Project
{
    public static class BookingDatabase
    {
        private static List<BookingInfo> allBookings;

        static BookingDatabase()
        {
            allBookings = new List<BookingInfo>
            {
                // === 대한항공 (KORAIR) 데이터 (3개) ===
                new BookingInfo { ReservationNumber = "RK1234", airline = Airline.KORAIR, RepresentativeName = "HONG GILDONG", FlightNumber = "KE110", Departure = "Seoul (ICN)", Arrival = "Tokyo (NRT)", DepartureTime = new DateTime(2025, 8, 15, 9, 0, 0), ArrivalTime = new DateTime(2025, 8, 15, 11, 25, 0), Adults = 1, Children = 0 },
                new BookingInfo { ReservationNumber = "RK5678", airline = Airline.KORAIR, RepresentativeName = "KIM MINSU", FlightNumber = "KE608", Departure = "Seoul (ICN)", Arrival = "New York (JFK)", DepartureTime = new DateTime(2025, 8, 16, 10, 0, 0), ArrivalTime = new DateTime(2025, 8, 16, 11, 0, 0), Adults = 2, Children = 0 },
                new BookingInfo { ReservationNumber = "RK9012", airline = Airline.KORAIR, RepresentativeName = "LEE JIHYE", FlightNumber = "KE901", Departure = "Seoul (ICN)", Arrival = "Paris (CDG)", DepartureTime = new DateTime(2025, 8, 17, 13, 10, 0), ArrivalTime = new DateTime(2025, 8, 17, 18, 50, 0), Adults = 2, Children = 2 },

                // === 아시아나항공 (ASIANA) 데이터 (3개) ===
                new BookingInfo { ReservationNumber = "RA1111", airline = Airline.ASIANA, RepresentativeName = "PARK SEOJUN", FlightNumber = "OZ102", Departure = "Seoul (ICN)", Arrival = "Tokyo (NRT)", DepartureTime = new DateTime(2025, 8, 15, 9, 10, 0), ArrivalTime = new DateTime(2025, 8, 15, 11, 30, 0), Adults = 1, Children = 0 },
                new BookingInfo { ReservationNumber = "RA2222", airline = Airline.ASIANA, RepresentativeName = "CHOI YUNA", FlightNumber = "OZ222", Departure = "Seoul (ICN)", Arrival = "New York (JFK)", DepartureTime = new DateTime(2025, 8, 16, 11, 0, 0), ArrivalTime = new DateTime(2025, 8, 16, 12, 10, 0), Adults = 2, Children = 1 },
                new BookingInfo { ReservationNumber = "RA3333", airline = Airline.ASIANA, RepresentativeName = "KANG MINA", FlightNumber = "OZ501", Departure = "Seoul (ICN)", Arrival = "Paris (CDG)", DepartureTime = new DateTime(2025, 8, 17, 12, 30, 0), ArrivalTime = new DateTime(2025, 8, 17, 18, 20, 0), Adults = 1, Children = 1 },

                // === 제주항공 (JEJU) 데이터 (3개) ===
                new BookingInfo { ReservationNumber = "RJ7777", airline = Airline.JEJU, RepresentativeName = "YOON DAEHO", FlightNumber = "7C1102", Departure = "Seoul (ICN)", Arrival = "Tokyo (NRT)", DepartureTime = new DateTime(2025, 8, 15, 8, 30, 0), ArrivalTime = new DateTime(2025, 8, 15, 10, 55, 0), Adults = 1, Children = 0 },
                new BookingInfo { ReservationNumber = "RJ8888", airline = Airline.JEJU, RepresentativeName = "SONG YEJIN", FlightNumber = "7C1302", Departure = "Seoul (ICN)", Arrival = "Osaka (KIX)", DepartureTime = new DateTime(2025, 8, 18, 14, 0, 0), ArrivalTime = new DateTime(2025, 8, 18, 15, 50, 0), Adults = 2, Children = 0 },
                new BookingInfo { ReservationNumber = "RJ9999", airline = Airline.JEJU, RepresentativeName = "HAN JIMIN", FlightNumber = "7C2601", Departure = "Seoul (ICN)", Arrival = "Da Nang (DAD)", DepartureTime = new DateTime(2025, 8, 19, 20, 35, 0), ArrivalTime = new DateTime(2025, 8, 19, 23, 20, 0), Adults = 4, Children = 0 },

                // === 티웨이항공 (TWAY) 데이터 (3개) ===
                new BookingInfo { ReservationNumber = "RT4321", airline = Airline.TWAY, RepresentativeName = "JUNG HOSEOK", FlightNumber = "TW211", Departure = "Seoul (ICN)", Arrival = "Tokyo (NRT)", DepartureTime = new DateTime(2025, 8, 15, 7, 45, 0), ArrivalTime = new DateTime(2025, 8, 15, 10, 10, 0), Adults = 1, Children = 0 },
                new BookingInfo { ReservationNumber = "RT5432", airline = Airline.TWAY, RepresentativeName = "BAE SUZY", FlightNumber = "TW281", Departure = "Seoul (ICN)", Arrival = "Osaka (KIX)", DepartureTime = new DateTime(2025, 8, 18, 9, 5, 0), ArrivalTime = new DateTime(2025, 8, 18, 11, 0, 0), Adults = 2, Children = 0 },
                new BookingInfo { ReservationNumber = "RT6543", airline = Airline.TWAY, RepresentativeName = "HWANG MINA", FlightNumber = "TW131", Departure = "Seoul (ICN)", Arrival = "Da Nang (DAD)", DepartureTime = new DateTime(2025, 8, 19, 19, 55, 0), ArrivalTime = new DateTime(2025, 8, 19, 22, 50, 0), Adults = 1, Children = 2 },

                // === 에미레이트항공 (EMIRATES) 데이터 (3개) ===
                new BookingInfo { ReservationNumber = "RE9988", airline = Airline.EMIRATES, RepresentativeName = "DAVID SMITH", FlightNumber = "EK323", Departure = "Seoul (ICN)", Arrival = "Dubai (DXB)", DepartureTime = new DateTime(2025, 8, 20, 23, 50, 0), ArrivalTime = new DateTime(2025, 8, 21, 4, 25, 0), Adults = 1, Children = 0 },
                new BookingInfo { ReservationNumber = "RE8877", airline = Airline.EMIRATES, RepresentativeName = "EMMA JONES", FlightNumber = "EK323", Departure = "Seoul (ICN)", Arrival = "Dubai (DXB)", DepartureTime = new DateTime(2025, 8, 21, 23, 50, 0), ArrivalTime = new DateTime(2025, 8, 22, 4, 25, 0), Adults = 2, Children = 0 },
                new BookingInfo { ReservationNumber = "RE7766", airline = Airline.EMIRATES, RepresentativeName = "MICHAEL WILLIAMS", FlightNumber = "EK323", Departure = "Seoul (ICN)", Arrival = "Dubai (DXB)", DepartureTime = new DateTime(2025, 8, 22, 23, 50, 0), ArrivalTime = new DateTime(2025, 8, 23, 4, 25, 0), Adults = 1, Children = 1 },

                // === ANA항공 (ANA) 데이터 (3개) ===
                new BookingInfo { ReservationNumber = "RN5566", airline = Airline.ANA, RepresentativeName = "SUZUKI TARO", FlightNumber = "NH868", Departure = "Seoul (ICN)", Arrival = "Tokyo (HND)", DepartureTime = new DateTime(2025, 8, 15, 20, 45, 0), ArrivalTime = new DateTime(2025, 8, 15, 23, 0, 0), Adults = 1, Children = 0 },
                new BookingInfo { ReservationNumber = "RN6677", airline = Airline.ANA, RepresentativeName = "TANAKA YUKI", FlightNumber = "NH862", Departure = "Seoul (ICN)", Arrival = "Tokyo (HND)", DepartureTime = new DateTime(2025, 8, 16, 7, 55, 0), ArrivalTime = new DateTime(2025, 8, 16, 10, 15, 0), Adults = 2, Children = 0 },
                new BookingInfo { ReservationNumber = "RN7788", airline = Airline.ANA, RepresentativeName = "SATO KENJI", FlightNumber = "NH698", Departure = "Seoul (ICN)", Arrival = "Osaka (KIX)", DepartureTime = new DateTime(2025, 8, 18, 18, 35, 0), ArrivalTime = new DateTime(2025, 8, 18, 20, 25, 0), Adults = 2, Children = 3 }
            };
        }

        public static BookingInfo FindBooking(string reservationNumber, Airline airline)
        {
            return allBookings.FirstOrDefault(b => b.airline == airline && b.ReservationNumber.ToUpper() == reservationNumber.ToUpper());
        }
    }
}
