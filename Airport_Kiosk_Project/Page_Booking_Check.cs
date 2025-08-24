using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Airport_Kiosk_Project
{

    public partial class Page_Booking_Check : UserControl
    {
        // 예약체크 이벤트 핸들러
        public event EventHandler<string> CheckReservationClicked;
        public event EventHandler ExitButtonClicked;

        // 예약번호
        private string currentInput = "";

        public Page_Booking_Check()
        {
            InitializeComponent();
        }

        // 언어
        public void UpdateLanguage()
        {
            // LanguageManager를 통해 키값으로 텍스트를 가져와서 설정
            this.btn_Check_Num.Text = LanguageManager.GetText("Next_Btn1");
            this.btn_Exit.Text = LanguageManager.GetText("Exit_Btn1");
            this.lb_Book_Num.Text = LanguageManager.GetText("Book_Num");
            CenterControlHorizontally(this.lb_Book_Num);
            // ... 이 페이지의 다른 모든 라벨, 버튼 텍스트도 동일하게 설정 ...
        }

        private void CenterControlHorizontally(Control controlToCenter)
        {
            // 부모 컨트롤이 있는지 확인합니다.
            if (controlToCenter.Parent != null)
            {
                // 새로운 X 위치를 계산합니다.
                // (부모 너비 / 2) - (자식 너비 / 2)
                int newX = (controlToCenter.Parent.ClientSize.Width - controlToCenter.Width) / 2 + 3;

                // 기존 Y 위치는 그대로 유지하면서 X 위치만 새로 설정합니다.
                controlToCenter.Location = new Point(newX, controlToCenter.Location.Y);
            }
        }


        // 리셋
        public void Reset()
        {
            currentInput = "";
            textBox_Book_Num.Text = "";
        }

        private void Key_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // 버튼의 Text(예: "A", "1")를 현재 입력값 뒤에 추가합니다.
            currentInput += clickedButton.Text;

            // 텍스트박스에 결과를 업데이트합니다.
            textBox_Book_Num.Text = currentInput;
        }

        private void btn_BackSpace_Click(object sender, EventArgs e)
        {
            // 입력된 내용이 있을 경우에만 실행합니다.
            if (currentInput.Length > 0)
            {
                // 문자열의 맨 마지막 한 글자를 제거합니다.
                currentInput = currentInput.Substring(0, currentInput.Length - 1);

                // 텍스트박스에 결과를 업데이트합니다.
                textBox_Book_Num.Text = currentInput;
            }
        }

        private void btn_Check_Num_Click(object sender, EventArgs e)
        {
            CheckReservationClicked?.Invoke(this, currentInput);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
