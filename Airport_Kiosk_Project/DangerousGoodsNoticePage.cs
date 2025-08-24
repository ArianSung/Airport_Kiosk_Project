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
    public partial class DangerousGoodsNoticePage : UserControl
    {
        private List<PictureBox> pages;
        private int currentPageIndex = 0;
        // 나가기 이벤트 핸들러 생성
        public event EventHandler ExitButtonClicked;
        // 동의 이벤트 핸들러 생성
        public event EventHandler AgreeButtonClicked;
        public DangerousGoodsNoticePage()
        {
            InitializeComponent();
            // 초기상태
            pages = new List<PictureBox>
            {
                pb_Danger1,
                pb_Danger2,
                pb_Danger3,
                pb_Danger4
            };
            btn_Agree.Visible = false;

            // 4. 프로그램 시작 시 첫 페이지만 보여줍니다.
            ShowPage(currentPageIndex);
        }

        // 언어
        public void UpdateLanguage()
        {
            // LanguageManager를 통해 키값으로 텍스트를 가져와서 설정
            this.btn_Next.Text = LanguageManager.GetText("Next_Btn");
            this.btn_Last.Text = LanguageManager.GetText("Last_Btn");
            this.btn_Exit.Text = LanguageManager.GetText("Exit_Btn");
            this.btn_Agree.Text = LanguageManager.GetText("Agree_Btn");
            // ... 이 페이지의 다른 모든 라벨, 버튼 텍스트도 동일하게 설정 ...
        }

        // Reset 메서드
        public void Reset()
        {
            // 1. 페이지 번호를 가장 처음인 0으로 되돌립니다.
            currentPageIndex = 0;

            // 2. 첫 번째 페이지의 UI 상태를 강제로 다시 보여줍니다.
            //    (첫 번째 사진 표시, '다음' 버튼 보이기, '동의' 버튼 숨기기)
            ShowPage(currentPageIndex);
        }

        // 페이지 보여주는 메서드
        private void ShowPage(int pageIndex)
        {
            // 모든 페이지 숨김
            foreach (var page in pages)
            {
                page.Hide();
            }
            // 페이지인덱스 표시
            pages[pageIndex].Show();

            // 마지막 페이지 확인
            if (pageIndex == pages.Count - 1)
            {
                // 마지막 페이지라면 -> 다음 버튼은 숨기고, 동의 버튼을 보여줍니다.
                btn_Next.Hide();
                btn_Agree.Show();
            }
            else
            {
                // 마지막 페이지가 아니라면 -> 다음 버튼을 보여주고, 동의 버튼을 숨깁니다.
                btn_Next.Show();
                btn_Agree.Hide();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            // 다음 페이지로 갈 수 있는지 확인 (마지막 페이지가 아닌지)
            if (currentPageIndex < pages.Count - 1)
            {
                currentPageIndex++; // 페이지 번호를 1 증가
                ShowPage(currentPageIndex);
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            // 이전 페이지로 갈 수 있는지 확인 (첫 페이지가 아닌지)
            if (currentPageIndex > 0)
            {
                currentPageIndex--; // 페이지 번호를 1 감소
                ShowPage(currentPageIndex);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_Agree_Click(object sender, EventArgs e)
        {
            AgreeButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
