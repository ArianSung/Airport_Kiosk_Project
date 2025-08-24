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
    public partial class MainMenuControls : UserControl
    {
        // page 생성 인스턴스(컨트롤) // 설계도 준비
        private Page_Select_AirLines page_Select_AirLines1;
        private CheckInMenu checkInMenu1;
        private DangerousGoodsNoticePage dangerousGoodsNoticePage1;
        private Page_Select_AirLines.Airline selectedAirline;   // 항공사 정보
        private Page_Booking_Check Page_Booking_Check1;
        private Page_Show_Booking page_Show_Booking1;
        private Page_No_Data page_No_Data1;
        private Page_Select_Seat page_Select_Seat1;
        private BookingInfo currentBooking;
        private Page_Ticketing_End page_Ticketing_End1;

        public MainMenuControls()
        {
            InitializeComponent();

            // 실제 객채 인스턴스 생성
            this.page_Select_AirLines1 = new Page_Select_AirLines();
            this.checkInMenu1 = new CheckInMenu();
            this.dangerousGoodsNoticePage1 = new DangerousGoodsNoticePage();
            this.Page_Booking_Check1 = new Page_Booking_Check();
            this.page_No_Data1 = new Page_No_Data();
            this.page_Show_Booking1 = new Page_Show_Booking();
            this.page_Select_Seat1 = new Page_Select_Seat();
            this.page_Ticketing_End1 = new Page_Ticketing_End();

            // 인스턴스 배치
            this.Controls.Add(this.page_Select_AirLines1);
            this.Controls.Add(this.checkInMenu1);
            this.Controls.Add(this.dangerousGoodsNoticePage1);
            this.Controls.Add(this.Page_Booking_Check1);
            this.Controls.Add(this.page_No_Data1);
            this.Controls.Add(this.page_Show_Booking1);
            this.Controls.Add(this.page_Select_Seat1);
            this.Controls.Add(this.page_Ticketing_End1);

            this.page_Select_AirLines1.Dock = DockStyle.Fill;
            this.checkInMenu1.Dock = DockStyle.Fill;
            this.dangerousGoodsNoticePage1.Dock = DockStyle.Fill;
            this.Page_Booking_Check1.Dock = DockStyle.Fill;
            this.page_Show_Booking1.Dock = DockStyle.Fill;
            this.page_Select_Seat1.Dock = DockStyle.Fill;
            this.page_Ticketing_End1.Dock = DockStyle.Fill;
            
            // 팝업창 위치 설정
            this.page_No_Data1.Anchor = AnchorStyles.None;
            this.page_No_Data1.Location = new Point(
                (this.Width - this.page_No_Data1.Width) / 2,
                (this.Height - this.page_No_Data1.Height) / 2);

            // 초기 화면 설정

            this.checkInMenu1.Hide();
            this.dangerousGoodsNoticePage1.Hide();
            this.page_Select_AirLines1.Show();
            this.page_Select_AirLines1.BringToFront();
            this.page_Show_Booking1.Hide();
            this.page_No_Data1.Hide();
            this.page_Select_Seat1.Hide();
            this.page_Ticketing_End1.Hide();

            page_Select_AirLines1.AirlineSelected += Page_Select_AirLines1_AirlineSelected;
            checkInMenu1.BackButtonClicked += CheckInMenu1_BackButtonClicked;
            checkInMenu1.StartCheckInClicked += CheckInMenu1_StartCheckInClicked;
            
            dangerousGoodsNoticePage1.AgreeButtonClicked += DangerousGoodsNoticePage1_AgreeButtonClicked;
            Page_Booking_Check1.CheckReservationClicked += Page_Booking_Check1_CheckReservationClicked;
            page_No_Data1.ConfirmButtonClicked += Page_No_Data1_ConfirmButtonClicked;

            page_Show_Booking1.TicketConfirmed += Page_Show_Booking1_TicketConfirmed;
            page_Select_Seat1.SeatsSelected += Page_Select_Seat1_SeatsSelected;

            // Exit 

            page_Ticketing_End1.ExitButtonClicked += GoToFirstPageAndResetAll;
            page_Ticketing_End1.TimeoutOccurred += GoToFirstPageAndResetAll;
            Page_Booking_Check1.ExitButtonClicked += GoToFirstPageAndResetAll;
            dangerousGoodsNoticePage1.ExitButtonClicked += GoToFirstPageAndResetAll;
            page_Show_Booking1.ExitButtonClicked += GoToFirstPageAndResetAll;
            page_Select_Seat1.ExitButtonClicked += GoToFirstPageAndResetAll;

            // 언어변경
            LanguageManager.LanguageChanged += UpdateAllPagesLanguage;


        }

        private void UpdateAllPagesLanguage(object? sender, EventArgs e)
        {
            page_Select_AirLines1.UpdateLanguage();
            checkInMenu1.UpdateLanguage();
            dangerousGoodsNoticePage1.UpdateLanguage();
            Page_Booking_Check1.UpdateLanguage();
            page_Show_Booking1.UpdateLanguage();
            page_No_Data1.UpdateLanguage();
            page_Select_Seat1.UpdateLanguage();
            page_Ticketing_End1.UpdateLanguage();
        }


        private void GoToFirstPageAndResetAll(object? sender, EventArgs e)
        {
            // 모든 페이지의 Reset() 메서드를 호출하여 상태를 초기화합니다.
            page_Ticketing_End1.Reset();
            page_Select_Seat1.Reset();
            page_Show_Booking1.Reset();
            Page_Booking_Check1.Reset();
            dangerousGoodsNoticePage1.Reset();

            // 모든 중간 페이지들을 숨깁니다.
            page_Ticketing_End1.Hide();
            page_Select_Seat1.Hide();
            page_Show_Booking1.Hide();
            Page_Booking_Check1.Hide();
            dangerousGoodsNoticePage1.Hide();
            checkInMenu1.Hide();

            // 가장 첫 페이지인 항공사 선택 화면을 보여주고 맨 앞으로 가져옵니다.
            page_Select_AirLines1.Show();
            page_Select_AirLines1.BringToFront();
        }

        private void Page_Select_Seat1_SeatsSelected(object? sender, List<string> selectedSeats)
        {
            // 선택된 좌석 데이터 베이스 저장
            SeatDatabase.AddReservedSeats(this.currentBooking.FlightNumber, selectedSeats);
            // 최종 페이지에 정보 전달
            page_Ticketing_End1.InitializeTicket(this.currentBooking, selectedSeats);

            page_Select_Seat1.Hide();
            page_Ticketing_End1.Show();
            page_Ticketing_End1.BringToFront();
        }


        private void Page_Show_Booking1_TicketConfirmed(object? sender, EventArgs e)
        {
            page_Select_Seat1.InitializeSeats(this.currentBooking);

            page_Show_Booking1.Hide();
            page_Select_Seat1.Show();
            page_Select_Seat1.BringToFront();
        }


        private void Page_No_Data1_ConfirmButtonClicked(object? sender, EventArgs e)
        {
            // 팝업창 숨김
            page_No_Data1.Hide();
        }

        private void Page_Booking_Check1_CheckReservationClicked(object? sender, string reservationNumber)
        {
            // 저장해뒀던 항공사와 입력받은 예약번호로 데이터베이스를 조회
            BookingInfo booking = BookingDatabase.FindBooking(reservationNumber, this.selectedAirline);

            if (booking != null) // 정보가 있다면 (성공)
            {
                page_Show_Booking1.Reset();
                // 예약 정보 페이지에 찾은 정보를 넘겨주고 보여줍니다.
                page_Show_Booking1.DisplayBooking(booking);
                this.currentBooking = booking;
                Page_Booking_Check1.Hide();
                page_Show_Booking1.Show();
                page_Show_Booking1.BringToFront();
            }
            else // 정보가 없다면 (실패)
            {
                // 경고 팝업을 맨 앞으로 가져와서 보여줍니다.
                page_No_Data1.Show();
                page_No_Data1.BringToFront();
            }
        }

        private void DangerousGoodsNoticePage1_AgreeButtonClicked(object? sender, EventArgs e)
        {
            Page_Booking_Check1.Reset();
            dangerousGoodsNoticePage1.Hide();
            Page_Booking_Check1.Show();
            Page_Booking_Check1.BringToFront();
            
        }

        // 체크인 메뉴 체크인 버튼
        private void CheckInMenu1_StartCheckInClicked(object? sender, EventArgs e)
        {
            // 초기화 먼저
            dangerousGoodsNoticePage1.Reset();
            // 위험물 안내 동의 페이지
            checkInMenu1.Hide();
            dangerousGoodsNoticePage1.Show();
            dangerousGoodsNoticePage1.BringToFront();
        }
        // 체크인메뉴 백버튼
        private void CheckInMenu1_BackButtonClicked(object? sender, EventArgs e)
        {
            checkInMenu1.Hide();
            page_Select_AirLines1.Show();
            page_Select_AirLines1.BringToFront();
        }

        private void Page_Select_AirLines1_AirlineSelected(object? sender, Page_Select_AirLines.Airline e)
        {
            this.selectedAirline = e;
            // CheckInMenu에게 어떤 항공사 로고를 보여줄지 명령
            checkInMenu1.SetAirlineLogo(e);

            // 페이지를 전환합니다.
            page_Select_AirLines1.Hide();
            checkInMenu1.Show();
            checkInMenu1.BringToFront();
        }


    }
}
