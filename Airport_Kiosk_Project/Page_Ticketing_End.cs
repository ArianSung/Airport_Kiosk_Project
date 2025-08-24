using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Airport_Kiosk_Project
{
    public partial class Page_Ticketing_End : UserControl
    {

        public event EventHandler ExitButtonClicked;
        public event EventHandler TimeoutOccurred;

        private System.Windows.Forms.Timer animationTimer;
        private int animationStep = 0;

        private System.Windows.Forms.Timer inactivityTimer;

        // 언어
        public void UpdateLanguage()
        {
            // LanguageManager를 통해 키값으로 텍스트를 가져와서 설정

            // ... 이 페이지의 다른 모든 라벨, 버튼 텍스트도 동일하게 설정 ...
        }


        public Page_Ticketing_End()
        {
            InitializeComponent();

            // 애니메이션 타이머 설정
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 400; // 0.4초마다 동작
            animationTimer.Tick += AnimationTimer_Tick;

            // 타임아웃 타이머 설정
            inactivityTimer = new System.Windows.Forms.Timer();
            inactivityTimer.Interval = 30000; // 30초
            inactivityTimer.Tick += InactivityTimer_Tick;
        }

        public void Reset()
        {
            // 애니메이션 타이머, 타임아웃 타이머를 멈춤
            animationTimer.Stop();
            inactivityTimer.Stop();
            // "발급중" 라벨과 QR코드 픽처박스를 모두 숨김
            lblStatus.Hide();
            pbQRCode.Hide();
            btn_Exit.Enabled = true;
        }

        public void InitializeTicket(BookingInfo booking, List<string> selectedSeats)
        {
            // 초기 UI 상태 설정
            lblStatus.Text = "발급중";
            lblStatus.Show();
            pbQRCode.Hide();
            btn_Exit.Enabled = false;

            // 애니메이션 시작
            animationTimer.Start();

            // 3초 후 영수증 표시 및 QR코드 생성 로직 실행
            ShowReceiptAndQrCode(booking, selectedSeats);
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // "발급중", "발급중.", "발급중..", "발급중..." 순환
            animationStep = (animationStep + 1) % 4;
            lblStatus.Text = "발급중" + new string('.', animationStep);
        }

        private async void ShowReceiptAndQrCode(BookingInfo booking, List<string> selectedSeats)
        {
            // 1. 3초 동안 기다립니다. (async/await)
            await Task.Delay(3000);

            // 2. 3초 후 애니메이션을 멈추고 라벨을 숨깁니다.
            animationTimer.Stop();
            lblStatus.Hide();

            // 3. 영수증 내용을 만듭니다.
            string receipt = "======= [ 항공권 발급 완료 ] =======\n\n" +
                     $"  항공사: {booking.airline}\n" +
                     $"  항공편: {booking.FlightNumber}\n" +
                     $"  대표자: {booking.RepresentativeName}\n" +
                     $"  인  원: 총 {booking.Adults + booking.Children}명 (성인:{booking.Adults}, 아동:{booking.Children})\n" +
                     $"  출발지: {booking.Departure}\n" +
                     $"  도착지: {booking.Arrival}\n" +
                     $"  출발시간: {booking.DepartureTime:yyyy-MM-dd HH:mm}\n" +
                     // 이 부분에서 전달받은 selectedSeats를 사용합니다.
                     $"  선택좌석: {string.Join(", ", selectedSeats)}\n\n" +
                     "        이용해 주셔서 감사합니다.";

            // 4. 메시지 박스로 영수증을 보여줍니다.
            MessageBox.Show(receipt, "발급 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 5. 메시지 박스를 닫으면 QR코드를 생성합니다.
            GenerateQrCode(receipt);
            btn_Exit.Enabled = true;
        }

        private void GenerateQrCode(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // PictureBox에 생성된 QR코드 이미지를 보여줍니다.
            pbQRCode.Image = qrCodeImage;
            pbQRCode.Show();
            pbQRCode.BringToFront();
            inactivityTimer.Start();
        }

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            // 타이머를 멈추고 타임아웃 발생신호를 부모에게 보냄
            inactivityTimer.Stop();
            TimeoutOccurred?.Invoke(this, EventArgs.Empty);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            inactivityTimer.Stop();
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
