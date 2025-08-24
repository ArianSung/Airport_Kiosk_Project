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

    public partial class Page_Select_Seat : UserControl
    {
        public event EventHandler ExitButtonClicked;
        public event EventHandler<List<string>> SeatsSelected;

        private List<string> reservedSeats; // 현재 항공사의 예약된 좌석 목록
        private int totalPassengers;        // 선택해야 할 총 승객 수
        private int selectedSeatsCount;     // 현재 내가 선택한 좌석 수

        // 선택한 좌석 저장
        private List<string> mySelectedSeats;


        public Page_Select_Seat()
        {
            InitializeComponent();
            this.btn_Final.Enabled = false;
        }

        // 언어
        public void UpdateLanguage()
        {
            // LanguageManager를 통해 키값으로 텍스트를 가져와서 설정

            // ... 이 페이지의 다른 모든 라벨, 버튼 텍스트도 동일하게 설정 ...
        }


        // 리셋
        public void Reset()
        {
            // 1. 캔버스 패널에 그려진 모든 좌석과 라벨들을 지웁니다.
            panelCanvas.Controls.Clear();

            // 2. 선택된 좌석 수와 관련된 변수들을 모두 0으로 초기화합니다.
            this.selectedSeatsCount = 0;
            this.totalPassengers = 0;

            // 3. 예약 좌석 리스트도 비워줍니다.
            this.reservedSeats = null;
        }

        public void InitializeSeats(BookingInfo booking)
        {
            // 전달받은 booking 정보로 변수들을 설정
            this.reservedSeats = SeatDatabase.GetReservedSeats(booking.FlightNumber);
            this.totalPassengers = booking.Adults + booking.Children;
            this.selectedSeatsCount = 0;
            this.mySelectedSeats = new List<string>();

            // 선택 시트 생성
            this.mySelectedSeats = new List<string>();

            // 인원 표시
            this.lb_Adult.Text = $"어른 : {booking.Adults}";
            this.lb_Child.Text = $"아이 : {booking.Children}";


            // 항공사 로고
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

            // 캔버스 패널을 깨끗하게 비우고 좌석을 새로 그림
            panelCanvas.Controls.Clear();
            DrawSeats();
        }

        private void DrawSeats()
        {
            // --- 좌석 레이아웃 설정값 ---
            int totalRows = 45; // 총 좌석 행 수
                                // 3-3-3 배열에 맞게 좌석 열 문자 변경 (보통 I는 건너뜁니다)
            char[] seatLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J' };
            int seatWidth = 40;
            int seatHeight = 40;
            int margin = 20;
            int gap = 5;
            int aisleGap = 40;    // 복도 간격

            // --- 좌석 그리기 시작 ---
            for (int r = 0; r < totalRows; r++)
            {
                // ============= [추가] 특정 행에 화장실/특별 구역 그리기 =============
                if (r == 15 || r == 30) // 예: 16행, 31행 위치에 특별 구역 추가
                {
                    Panel specialArea = new Panel
                    {
                        // Y위치는 현재 행과 동일하게, X위치는 좌석 시작 위치에 맞춤
                        Location = new Point(margin + 35, margin + r * (seatHeight + gap)),
                        // 너비는 전체 좌석과 복도를 합친 크기로 설정
                        Size = new Size((seatWidth * 9) + (gap * 8) + (aisleGap * 2), seatHeight),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.None
                    };
                    Label specialLabel = new Label
                    {
                        Text = "화장실 / 주방",
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    specialArea.Controls.Add(specialLabel);
                    panelCanvas.Controls.Add(specialArea);

                    // 이 행에는 좌석을 그리지 않고 다음 행으로 넘어감
                    continue;
                }
                // =================================================================

                // 행 번호 라벨 생성
                Label rowLabel = new Label
                {
                    Text = (r + 1).ToString(),
                    Location = new Point(margin, margin + r * (seatHeight + gap)),
                    Size = new Size(30, seatHeight),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10)
                };
                panelCanvas.Controls.Add(rowLabel);

                // 한 행의 좌석 버튼들 생성
                for (int c = 0; c < seatLetters.Length; c++)
                {
                    Button seatButton = new Button();

                    // ============= [수정] X 위치 계산 (복도 2개) =============
                    int x = rowLabel.Right + margin + c * (seatWidth + gap);
                    if (c >= 3) x += aisleGap; // C열 다음에 첫 번째 복도 추가
                    if (c >= 6) x += aisleGap; // F열 다음에 두 번째 복도 추가
                    // =======================================================

                    int y = margin + r * (seatHeight + gap);

                    seatButton.Location = new Point(x, y);
                    seatButton.Size = new Size(seatWidth, seatHeight);
                    seatButton.Text = seatLetters[c].ToString();
                    seatButton.Name = $"{(r + 1)}{seatLetters[c]}";

                    if (this.reservedSeats.Contains(seatButton.Name))
                    {
                        // 예약된 좌석이라면
                        seatButton.BackColor = Color.Gray;
                        seatButton.Enabled = false; // 클릭 비활성화
                    }
                    else
                    {
                        // 선택 가능한 좌석이라면
                        seatButton.BackColor = Color.LightGreen;
                    }

                    seatButton.Click += Seat_Click;

                    panelCanvas.Controls.Add(seatButton);
                }
            }
        }
        private void Seat_Click(object sender, EventArgs e)
        {
            Button clickedSeat = sender as Button;
            if (clickedSeat == null) return;

            // 현재 좌석 색상에 따라 상태를 변경합니다.
            if (clickedSeat.BackColor == Color.LightGreen)
            {
                // '선택 가능' 상태였다면 '내가 선택함' 상태로 변경
                if (selectedSeatsCount < totalPassengers)
                {
                    // '내가 선택함' 상태로 변경
                    clickedSeat.BackColor = Color.LightSkyBlue;
                    selectedSeatsCount++; // 선택한 좌석 수 1 증가
                    // 선택한 좌석 리스트 추가
                    mySelectedSeats.Add(clickedSeat.Name);
                }
                //else
                //{
                //     더 이상 선택할 수 없으면 사용자에게 알림
                //    MessageBox.Show($"총 {totalPassengers}명까지만 좌석을 선택할 수 있습니다.");
                //}
            }
            else if (clickedSeat.BackColor == Color.LightSkyBlue)
            {
                // '내가 선택함' 상태였다면 다시 '선택 가능' 상태로 변경
                clickedSeat.BackColor = Color.LightGreen;
                selectedSeatsCount--;
                // 선택한 좌석 리스트 삭제
                mySelectedSeats.Remove(clickedSeat.Name);
            }

            // 다음버튼 활성화
            if (selectedSeatsCount == totalPassengers)
            {
                btn_Final.Enabled = true;
            }
            else
            {
                btn_Final.Enabled = false;
            }
        }



        private void btn_Final_Click(object sender, EventArgs e)
        {
            SeatsSelected?.Invoke(this, mySelectedSeats);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }

}
