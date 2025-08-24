using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Airport_Kiosk_Project.Page_Select_AirLines;

namespace Airport_Kiosk_Project
{
    public class BookingInfo
    {
        public string ReservationNumber { get; set; } // 예약 번호
        public Airline airline { get; set; }           // 항공사
        public string RepresentativeName { get; set; } // 대표 탑승객 이름
        public string FlightNumber { get; set; }      // 항공편 명
        public string Departure { get; set; }         // 출발지
        public string Arrival { get; set; }           // 도착지
        public int Adults { get; set; }               // 성인 인원
        public int Children { get; set; }             // 어린이 인원
        public DateTime DepartureTime { get; set; } // 출발 시간
        public DateTime ArrivalTime { get; set; }   // 도착 시간
    }
}
