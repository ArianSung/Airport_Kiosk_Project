namespace Airport_Kiosk_Project
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // 1. 허브 역할을 하는 MainMenuControls를 생성합니다.
            MainMenuControls mainMenu = new MainMenuControls();

            // 2. MainMenuControls가 Form 전체를 꽉 채우도록 설정합니다.
            mainMenu.Dock = DockStyle.Fill;

            // 3. 생성한 mainMenu를 Form의 화면에 추가합니다.
            this.Controls.Add(mainMenu);
        }

        // 깜빡임 해결 (Gemini)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // WS_EX_COMPOSITED 옵션을 켭니다.
                return cp;
            }
        }

    }
}
