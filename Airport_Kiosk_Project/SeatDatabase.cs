using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Airport_Kiosk_Project.Page_Select_AirLines;
using System.Text.Json;
using System.IO;

namespace Airport_Kiosk_Project
{
    public static class SeatDatabase
    {
        // 항공사별 예약된 좌석 정보를 저장하는 딕셔너리
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "seat_database.json");
        private static Dictionary<string, List<string>> reservedSeatsByFlightNumber;


        static SeatDatabase()
        {
            Load();
        }

        private static void Load()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(json))
                {
                    // string, List<string> 타입으로 Deserialize
                    reservedSeatsByFlightNumber = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
                }
            }

            if (reservedSeatsByFlightNumber == null)
            {
                reservedSeatsByFlightNumber = new Dictionary<string, List<string>>
                {
                    // === 대한항공 (KORAIR) ===
                    { "KE110", new List<string> {
                        "1A", "1B", "2C", "3A", "4B", "5C", "6A", "7B", "8C", "9A",
                        "10D", "11E", "12F", "13D", "14E", "16F", "17D", "18E", "19F", "20D",
                        "21G", "22H", "23J", "24G", "25H", "26J", "27G", "28H", "29J", "31G" } },
                    { "KE608", new List<string> {
                        "2A", "2B", "3C", "4A", "5B", "6C", "7A", "8B", "9C", "10A",
                        "11D", "12E", "13F", "14D", "16E", "17F", "18D", "19E", "20F", "21D",
                        "22G", "23H", "24J", "25G", "26H", "27J", "28G", "29H", "31J", "32G" } },
                    { "KE901", new List<string> {
                        "3A", "3B", "4C", "5A", "6B", "7C", "8A", "9B", "10C", "11A",
                        "12D", "13E", "14F", "16D", "17E", "18F", "19D", "20E", "21F", "22D",
                        "23G", "24H", "25J", "26G", "27H", "28J", "29G", "31H", "32J", "33G" } },

                    // === 아시아나항공 (ASIANA) ===
                    { "OZ102", new List<string> {
                        "1J", "1H", "2G", "3J", "4H", "5G", "6J", "7H", "8G", "9J",
                        "10F", "11E", "12D", "13F", "14E", "16D", "17F", "18E", "19D", "20F",
                        "21C", "22B", "23A", "24C", "25B", "26A", "27C", "28B", "29A", "31C" } },
                    { "OZ222", new List<string> {
                        "2J", "2H", "3G", "4J", "5H", "6G", "7J", "8H", "9G", "10J",
                        "11F", "12E", "13D", "14F", "16E", "17D", "18F", "19E", "20D", "21F",
                        "22C", "23B", "24A", "25C", "26B", "27A", "28C", "29B", "31A", "32C" } },
                    { "OZ501", new List<string> {
                        "3J", "3H", "4G", "5J", "6H", "7G", "8J", "9H", "10G", "11J",
                        "12F", "13E", "14D", "16F", "17E", "18D", "19F", "20E", "21D", "22F",
                        "23C", "24B", "25A", "26C", "27B", "28A", "29C", "31B", "32A", "33C" } },

                    // === 제주항공 (JEJU) ===
                    { "7C1102", new List<string> {
                        "4A", "4B", "4C", "5D", "5E", "5F", "6G", "6H", "6J", "7A",
                        "8B", "9C", "10D", "11E", "12F", "13G", "14H", "16J", "17A", "18B",
                        "19C", "20D", "21E", "22F", "23G", "24H", "25J", "26A", "27B", "28C" } },
                    { "7C1302", new List<string> {
                        "5A", "5B", "5C", "6D", "6E", "6F", "7G", "7H", "7J", "8A",
                        "9B", "10C", "11D", "12E", "13F", "14G", "16H", "17J", "18A", "19B",
                        "20C", "21D", "22E", "23F", "24G", "25H", "26J", "27A", "28B", "29C" } },
                    { "7C2601", new List<string> {
                        "6A", "6B", "6C", "7D", "7E", "7F", "8G", "8H", "8J", "9A",
                        "10B", "11C", "12D", "13E", "14F", "16G", "17H", "18J", "19A", "20B",
                        "21C", "22D", "23E", "24F", "25G", "26H", "27J", "28A", "29B", "31C" } },

                    // === 티웨이항공 (TWAY) ===
                    { "TW211", new List<string> {
                        "7A", "7B", "7C", "8D", "8E", "8F", "9G", "9H", "9J", "10A",
                        "11B", "12C", "13D", "14E", "16F", "17G", "18H", "19J", "20A", "21B",
                        "22C", "23D", "24E", "25F", "26G", "27H", "28J", "29A", "31B", "32C" } },
                    { "TW281", new List<string> {
                        "8A", "8B", "8C", "9D", "9E", "9F", "10G", "10H", "10J", "11A",
                        "12B", "13C", "14D", "16E", "17F", "18G", "19H", "20J", "21A", "22B",
                        "23C", "24D", "25E", "26F", "27G", "28H", "29J", "31A", "32B", "33C" } },
                    { "TW131", new List<string> {
                        "9A", "9B", "9C", "10D", "10E", "10F", "11G", "11H", "11J", "12A",
                        "13B", "14C", "16D", "17E", "18F", "19G", "20H", "21J", "22A", "23B",
                        "24C", "25D", "26E", "27F", "28G", "29H", "31J", "32A", "33B", "34C" } },

                    // === 에미레이트항공 (EMIRATES) ===
                    { "EK323", new List<string> {
                        "10A", "10B", "10J", "11A", "11B", "11J", "12D", "12E", "12F", "13A",
                        "14B", "16C", "17D", "18E", "19F", "20G", "21H", "22J", "23A", "24B",
                        "25C", "26D", "27E", "28F", "29G", "31H", "32J", "33A", "34B", "35C" } },

                    // === ANA항공 (ANA) ===
                    { "NH868", new List<string> {
                        "11A", "11B", "11C", "12D", "12E", "12F", "13G", "13H", "13J", "14A",
                        "16B", "17C", "18D", "19E", "20F", "21G", "22H", "23J", "24A", "25B",
                        "26C", "27D", "28E", "29F", "31G", "32H", "33J", "34A", "35B", "36C" } },
                    { "NH862", new List<string> {
                        "12A", "12B", "12C", "13D", "13E", "13F", "14G", "14H", "14J", "16A",
                        "17B", "18C", "19D", "20E", "21F", "22G", "23H", "24J", "25A", "26B",
                        "27C", "28D", "29E", "31F", "32G", "33H", "34J", "35A", "36B", "37C" } },
                    { "NH698", new List<string> {
                        "13A", "13B", "13C", "14D", "14E", "14F", "16G", "16H", "16J", "17A",
                        "18B", "19C", "20D", "21E", "22F", "23G", "24H", "25J", "26A", "27B",
                        "28C", "29D", "31E", "32F", "33G", "34H", "35J", "36A", "37B", "38C" } }
                };
            }
        }

        // 현재 데이터베이스 상태를 파일에 저장하는 메서드
        private static void Save()
        {
            string json = JsonSerializer.Serialize(reservedSeatsByFlightNumber, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // 항공편명(string)으로 예약 좌석을 추가하도록 변경
        public static void AddReservedSeats(string flightNumber, List<string> newSeats)
        {
            // 만약 해당 항공편의 키가 없다면 새로 만들어줍니다.
            if (!reservedSeatsByFlightNumber.ContainsKey(flightNumber))
            {
                reservedSeatsByFlightNumber[flightNumber] = new List<string>();
            }

            if (newSeats != null)
            {
                reservedSeatsByFlightNumber[flightNumber].AddRange(newSeats);
                Save();
            }
        }

        // 항공편명(string)으로 예약된 좌석 목록을 반환하도록 변경
        public static List<string> GetReservedSeats(string flightNumber)
        {
            if (reservedSeatsByFlightNumber.ContainsKey(flightNumber))
            {
                return reservedSeatsByFlightNumber[flightNumber];
            }
            // 해당 항공편 정보가 없으면 빈 리스트 반환
            return new List<string>();
        }
    }
}

