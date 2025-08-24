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
    public partial class Page_No_Data : UserControl
    {
        // 확인버튼 이벤트 핸들러
        public event EventHandler ConfirmButtonClicked;

        public Page_No_Data()
        {
            InitializeComponent();
        }

        // 언어
        public void UpdateLanguage()
        {
            // LanguageManager를 통해 키값으로 텍스트를 가져와서 설정
            this.label1.Text = LanguageManager.GetText("Lable_Warn");
            CenterControlHorizontally(label1);
            this.btn_Confirm.Text = LanguageManager.GetText("Confirm_Btn");
            // ... 이 페이지의 다른 모든 라벨, 버튼 텍스트도 동일하게 설정 ...
        }


        private void btn_Confirm_Click_1(object sender, EventArgs e)
        {
            ConfirmButtonClicked?.Invoke(this, EventArgs.Empty);
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
    }
}
