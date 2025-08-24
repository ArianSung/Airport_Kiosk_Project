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
    public partial class Page_Select_AirLines : UserControl
    {
        // 항공사 선택 페이지
        public Page_Select_AirLines()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // 항공사 목록
        public enum Airline
        {
            ASIANA,
            KORAIR,
            JEJU,
            TWAY,
            EMIRATES,
            ANA
        }

        // 언어
        public void UpdateLanguage()
        {
            // LanguageManager를 통해 키값으로 텍스트를 가져와서 설정
            this.lb_Airline.Text = LanguageManager.GetText("Title_AirlineSelect");
            CenterControlHorizontally(this.lb_Airline);
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



        // 항공사를 선택했다는 이벤트 정의
        public event EventHandler<Airline> AirlineSelected;

        // 항공사 버튼 클릭 이벤트 -> 신호발생
        private void btn_ASIANA_Click(object sender, EventArgs e)
        {
            AirlineSelected?.Invoke(this, Airline.ASIANA);
        }

        private void btn_KORAIR_Click(object sender, EventArgs e)
        {
            AirlineSelected?.Invoke(this, Airline.KORAIR);
        }

        private void btn_JEJU_Click(object sender, EventArgs e)
        {
            AirlineSelected?.Invoke(this, Airline.JEJU);
        }

        private void btn_TWAY_Click(object sender, EventArgs e)
        {
            AirlineSelected?.Invoke(this, Airline.TWAY);
        }

        private void btn_EMIRATES_Click(object sender, EventArgs e)
        {
            AirlineSelected?.Invoke(this, Airline.EMIRATES);
        }

        private void btn_ANA_Click(object sender, EventArgs e)
        {
            AirlineSelected?.Invoke(this, Airline.ANA);
        }


        //
        //  shadow 표현
        //

        private void btn_ANA_MouseEnter_1(object sender, EventArgs e)
        {
            shadowPanel_ANA.Visible = true;
        }

        private void btn_ANA_MouseLeave_1(object sender, EventArgs e)
        {
            shadowPanel_ANA.Visible = false;
        }

        private void bt_ASIANA_MouseEnter(object sender, EventArgs e)
        {
            shadowPanel_ASIANA.Visible = true;
        }

        private void bt_ASIANA_MouseLeave(object sender, EventArgs e)
        {
            shadowPanel_ASIANA.Visible = false;
        }

        private void btn_KORAIR_MouseEnter(object sender, EventArgs e)
        {
            shadowPanel_KORAIR.Visible = true;
        }

        private void btn_KORAIR_MouseLeave(object sender, EventArgs e)
        {
            shadowPanel_KORAIR.Visible = false;
        }

        private void btn_JEJU_MouseEnter(object sender, EventArgs e)
        {
            shadowPanel_JEJU.Visible = true;
        }

        private void btn_JEJU_MouseLeave(object sender, EventArgs e)
        {
            shadowPanel_JEJU.Visible = false;
        }

        private void btn_TWAY_MouseEnter(object sender, EventArgs e)
        {
            shadowPanel_TWAY.Visible = true;
        }

        private void btn_TWAY_MouseLeave(object sender, EventArgs e)
        {
            shadowPanel_TWAY.Visible = false;
        }

        private void btn_EMIRATES_MouseEnter(object sender, EventArgs e)
        {
            shadowPanel_EMIRATES.Visible = true;
        }

        private void btn_EMIRATES_MouseLeave(object sender, EventArgs e)
        {
            shadowPanel_EMIRATES.Visible = false;
        }

        private void btn_Kor_Click(object sender, EventArgs e)
        {
            LanguageManager.SetLanguage(LanguageManager.Language.Korean);
        }

        private void btn_Eng_Click(object sender, EventArgs e)
        {
            LanguageManager.SetLanguage(LanguageManager.Language.English);
        }

        private void btn_Cn_Click(object sender, EventArgs e)
        {
            LanguageManager.SetLanguage(LanguageManager.Language.Chinese);
        }

        private void btn_Jp_Click(object sender, EventArgs e)
        {
            LanguageManager.SetLanguage(LanguageManager.Language.Japanese);
        }
    }
}
