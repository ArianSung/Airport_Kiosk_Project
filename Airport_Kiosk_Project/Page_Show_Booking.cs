using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_Kiosk_Project
{
    public partial class Page_Show_Booking : UserControl
    {
        // Exit 이벤트 핸들러
        public event EventHandler ExitButtonClicked;
        private Panel currentTicketPanel = null;
        public event EventHandler TicketConfirmed;
        int movepoint = 10;
        public Page_Show_Booking()
        {
            InitializeComponent();
        }

        // 언어
        public void UpdateLanguage()
        {
            // LanguageManager를 통해 키값으로 텍스트를 가져와서 설정
            this.lb_Booking_Num.Text = LanguageManager.GetText("Lb_Book_Num");
            this.lb_Name.Text = LanguageManager.GetText("Lb_Name");
            this.lb_PeopleData.Text = LanguageManager.GetText("Lb_People");
            

            // ... 이 페이지의 다른 모든 라벨, 버튼 텍스트도 동일하게 설정 ...
        }

        // 리셋
        public void Reset()
        {
            // 1. 이전에 만들어둔 탑승권 패널(currentTicketPanel)이 있다면 찾아서 지웁니다.
            if (this.currentTicketPanel != null)
            {
                this.Controls.Remove(this.currentTicketPanel);
                this.currentTicketPanel = null; // 변수도 깨끗하게 비워줍니다.
            }

            // 2. 디자이너에서 만든 라벨들의 텍스트도 모두 지웁니다.
            this.lbData_BookingNum.Text = "";
            this.lbData_Name.Text = "";
            //this.lbData_Adult.Text = "";
            //this.lbData_Child.Text = "";

        }

        // MainMenuControls로부터 예약 정보를 받아 UI를 업데이트하는 public 메서드
        public void DisplayBooking(BookingInfo booking)
        {

            if (this.currentTicketPanel != null)
            {
                this.Controls.Remove(this.currentTicketPanel);
            }
            // 새로운 탑승권 UI를 생성
            Panel ticketPanel = CreateTicketPanel(booking);

            // 생성된 탑승권위치 조정
            ticketPanel.Location = new Point(625, 160);


            // 데이터 라벨들에 데이터베이스의 값을 채워 넣습니다.
            this.lbData_BookingNum.Text = booking.ReservationNumber;
            this.lbData_Name.Text = booking.RepresentativeName;
            this.lb_Test.Text = $"{LanguageManager.GetText("Lb_Data_Adult")}{booking.Adults}   {LanguageManager.GetText("Lb_Data_Child")}{booking.Children}";

            // 각 데이터 라벨을 제목 라벨 아래 중앙에 정렬시킵니다.
            CenterAlignLabel(lb_Booking_Num, this.lbData_BookingNum);
            CenterAlignLabel(lb_Name, this.lbData_Name);
            CenterAlignLabel(lb_PeopleData, this.lb_Test);

            // 최종 완성된 탑승권을 화면에 추가
            this.Controls.Add(ticketPanel);
            this.currentTicketPanel = ticketPanel;
            this.pb_AirLine_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            switch (booking.airline)
            {
                case Page_Select_AirLines.Airline.KORAIR:
                    this.pb_AirLine_Logo.Image = Properties.Resources.KORAIR;
                    break;
                case Page_Select_AirLines.Airline.ASIANA:
                    this.pb_AirLine_Logo.Image = Properties.Resources.ASIANA;
                    break;
                case Page_Select_AirLines.Airline.JEJU:
                    this.pb_AirLine_Logo.Image = Properties.Resources.JEJU;
                    break;
                case Page_Select_AirLines.Airline.TWAY:
                    this.pb_AirLine_Logo.Image = Properties.Resources.Tway;
                    break;
                case Page_Select_AirLines.Airline.EMIRATES:
                    this.pb_AirLine_Logo.Image = Properties.Resources.EMIRATES;
                    break;
                case Page_Select_AirLines.Airline.ANA:
                    this.pb_AirLine_Logo.Image = Properties.Resources.ANA;
                    break;
            }
        }

        // 가운데 정렬 메서드
        private void CenterAlignLabel(Label titleLabel, Label dataLabel)
        {
            // 데이터 라벨의 Y 위치 (제목 라벨 바로 아래 + 5픽셀 여백)
            int y = titleLabel.Bottom + 5;

            // 데이터 라벨의 X 위치 (제목 라벨의 중앙 - 데이터 라벨 너비의 절반)
            int x = titleLabel.Left + (titleLabel.Width / 2) - (dataLabel.Width / 2);

            // 계산된 위치로 데이터 라벨을 이동시킵니다.
            dataLabel.Location = new Point(x, y);
        }
        // 오버로드
        private void CenterAlignLabel(Label titleLabel, Panel dataLabel)
        {
            // 데이터 라벨의 Y 위치 (제목 라벨 바로 아래 + 5픽셀 여백)
            int y = titleLabel.Bottom + 5;

            // 데이터 라벨의 X 위치 (제목 라벨의 중앙 - 데이터 라벨 너비의 절반)
            int x = titleLabel.Left + (titleLabel.Width / 2) - (dataLabel.Width / 2);

            // 계산된 위치로 데이터 라벨을 이동시킵니다.
            dataLabel.Location = new Point(x, y);
        }

        // 탑승권 모양의 Panel을 생성하고 내용을 채우는 메서드
        private Panel CreateTicketPanel(BookingInfo booking)
        {
            // 항공사 색
            Color airlineColor;
            switch (booking.airline)
            {
                case Page_Select_AirLines.Airline.KORAIR:
                    airlineColor = Color.FromArgb(0, 51, 153); // 대한항공 파란색
                    break;
                case Page_Select_AirLines.Airline.ASIANA:
                    airlineColor = Color.SaddleBrown; // 아시아나 갈색
                    break;
                case Page_Select_AirLines.Airline.JEJU:
                    airlineColor = Color.FromArgb(255, 102, 0); // 제주항공 주황색
                    break;
                case Page_Select_AirLines.Airline.TWAY:
                    airlineColor = Color.Red; // 티웨이 빨간색
                    break;
                case Page_Select_AirLines.Airline.EMIRATES:
                    airlineColor = Color.FromArgb(200, 16, 46); // 에미레이트 금색
                    break;
                case Page_Select_AirLines.Airline.ANA:
                    airlineColor = Color.FromArgb(0, 51, 153); // ANA 파란색
                    break;
                default:
                    airlineColor = Color.LightSkyBlue; // 기본값 연한 하늘색
                    break;
            }
            // 전체를 감싸는 흰색 패널 (탑승권 몸체) - 요청하신 크기로 수정
            Panel panelTicket = new Panel
            {
                Width = 320,
                Height = 330,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // 상단 헤더 패널
            Panel panelHeader = new Panel
            {
                Height = 50, // 헤더 높이 조절
                BackColor = airlineColor,
                Dock = DockStyle.Top
            };
            panelTicket.Controls.Add(panelHeader);

            // 폰트 정의
            Font labelFont = new Font("맑은 고딕", 10, FontStyle.Regular);
            Font airportCodeFont = new Font("Arial", 36, FontStyle.Bold); // 크기 조절
            Font airportNameFont = new Font("맑은 고딕", 11, FontStyle.Regular);
            Font timeFont = new Font("Arial", 24, FontStyle.Bold); // 크기 조절


            // 데이터 베이스에서 문자 가져오기(도시이름 공항코드 분리)
            string departureCity = booking.Departure.Substring(0, booking.Departure.IndexOf('(') - 1);
            string departureCode = booking.Departure.Substring(booking.Departure.IndexOf('(') + 1, 3);
            string arrivalCity = booking.Arrival.Substring(0, booking.Arrival.IndexOf('(') - 1);
            string arrivalCode = booking.Arrival.Substring(booking.Arrival.IndexOf('(') + 1, 3);

            // 항공편명 라벨 (데이터베이스에서 가져오기)
            Label lblFlightNumber = new Label
            {
                Text = booking.FlightNumber, // booking 데이터 사용
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
            };
            lblFlightNumber.Location = new Point(
                (panelHeader.Width - lblFlightNumber.Width) / 2 + movepoint, // 위치 조정
                (panelHeader.Height - lblFlightNumber.Height) / 2
            );
            panelHeader.Controls.Add(lblFlightNumber);

            // "출발지", "도착지" 라벨
            Label lblDepartureTitle = new Label { Text = "출발지", Font = labelFont, AutoSize = true, Location = new Point(50, 70) };
            Label lblArrivalTitle = new Label { Text = "도착지", Font = labelFont, AutoSize = true, Location = new Point(215, 70) };

            // 공항 코드 라벨 (파싱한 데이터 사용)
            Label lblDepartureCode = new Label { Text = departureCode, Font = airportCodeFont, AutoSize = true, Location = new Point(30, 95) };
            Label lblArrivalCode = new Label { Text = arrivalCode, Font = airportCodeFont, AutoSize = true, Location = new Point(180, 95) };

            // 공항 이름 라벨 (파싱한 데이터 사용)
            Label lblDepartureName = new Label { Text = departureCity, Font = airportNameFont, AutoSize = true, Location = new Point(55, 155) };
            Label lblArrivalName = new Label { Text = arrivalCity, Font = airportNameFont, AutoSize = true, Location = new Point(215, 155) };

            // 비행기 아이콘
            Label lblPlaneIcon = new Label { Text = "✈", ForeColor = Color.DodgerBlue, Font = new Font("Segoe UI Symbol", 25), AutoSize = true, Location = new Point(132, 115) };

            // 시간 라벨
            Label lblDepartureTimeTitle = new Label { Text = "출발시간", Font = labelFont, AutoSize = true, Location = new Point(40, 210) };
            Label lblArrivalTimeTitle = new Label { Text = "도착시간", Font = labelFont, AutoSize = true, Location = new Point(208, 210) };

            // 시간 정보 (데이터베이스에서 가져오기)
            Label lblDepartureTime = new Label { Text = booking.DepartureTime.ToString("HH:mm"), Font = timeFont, AutoSize = true, Location = new Point(35, 240) };
            Label lblArrivalTime = new Label { Text = booking.ArrivalTime.ToString("HH:mm"), Font = timeFont, AutoSize = true, Location = new Point(195, 240) };


            // 모든 컨트롤들을 탑승권 패널에 추가
            panelTicket.Controls.AddRange(new Control[] {
                lblDepartureTitle, lblArrivalTitle, lblDepartureCode, lblArrivalCode,
                lblDepartureName, lblArrivalName, lblPlaneIcon, lblDepartureTimeTitle,
                lblArrivalTimeTitle, lblDepartureTime, lblArrivalTime
            });

            return panelTicket; // 완성된 탑승권 패널을 반환
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_Check_Ticket_Click(object sender, EventArgs e)
        {
            TicketConfirmed?.Invoke(this, EventArgs.Empty);
        }


    }
}
