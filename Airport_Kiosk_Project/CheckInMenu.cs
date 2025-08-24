using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Airport_Kiosk_Project.Page_Select_AirLines;

namespace Airport_Kiosk_Project
{
    public partial class CheckInMenu : UserControl
    {
        public event EventHandler BackButtonClicked;
        public event EventHandler StartCheckInClicked;
        public CheckInMenu()
        {
            InitializeComponent();
        }

        // 언어
        public void UpdateLanguage()
        {
            // LanguageManager를 통해 키값으로 텍스트를 가져와서 설정
            this.btn_CheckIn.Text = LanguageManager.GetText("CheckIn_Btn");
            // ... 이 페이지의 다른 모든 라벨, 버튼 텍스트도 동일하게 설정 ...
        }

        // 가운데 정렬
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

        public void SetAirlineLogo(Airline selectedAirline) // enum Airline
        {
            // 선택된 항공사에 따라 다른 로고 이미지를 보여줍니다.
            switch (selectedAirline)
            {
                case Airline.ASIANA:
                    pb_AirlineLogo.Image = Properties.Resources.ASIANA;
                    break;
                case Airline.KORAIR:
                    pb_AirlineLogo.Image = Properties.Resources.KORAIR;
                    break;
                case Airline.ANA:
                    pb_AirlineLogo.Image = Properties.Resources.ANA;
                    break;
                case Airline.EMIRATES:
                    pb_AirlineLogo.Image = Properties.Resources.EMIRATES;
                    break;
                case Airline.JEJU:
                    pb_AirlineLogo.Image = Properties.Resources.JEJU;
                    break;
                case Airline.TWAY:
                    pb_AirlineLogo.Image = Properties.Resources.Tway;
                    break;
            }
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            StartCheckInClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_CheckIn_MouseEnter(object sender, EventArgs e)
        {
            shadow_CheckIn.Visible = true;
        }

        private void btn_CheckIn_MouseLeave(object sender, EventArgs e)
        {
            shadow_CheckIn.Visible = false;
        }

        // 뒤로가기 이벤트
        private void btn_Back_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void CheckInMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
