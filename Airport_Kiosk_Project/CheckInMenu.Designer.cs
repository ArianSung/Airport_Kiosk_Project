namespace Airport_Kiosk_Project
{
    partial class CheckInMenu
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            btn_CheckIn = new Button();
            shadow_CheckIn = new Panel();
            btn_Back = new Button();
            pb_AirlineLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_AirlineLogo).BeginInit();
            SuspendLayout();
            // 
            // btn_CheckIn
            // 
            btn_CheckIn.BackColor = Color.Transparent;
            btn_CheckIn.FlatAppearance.BorderSize = 0;
            btn_CheckIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_CheckIn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_CheckIn.FlatStyle = FlatStyle.Flat;
            btn_CheckIn.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CheckIn.Location = new Point(330, 270);
            btn_CheckIn.Name = "btn_CheckIn";
            btn_CheckIn.Size = new Size(340, 150);
            btn_CheckIn.TabIndex = 24;
            btn_CheckIn.Text = "체크인";
            btn_CheckIn.UseVisualStyleBackColor = false;
            btn_CheckIn.Click += btn_CheckIn_Click;
            btn_CheckIn.MouseEnter += btn_CheckIn_MouseEnter;
            btn_CheckIn.MouseLeave += btn_CheckIn_MouseLeave;
            // 
            // shadow_CheckIn
            // 
            shadow_CheckIn.BackColor = Color.LightGray;
            shadow_CheckIn.Location = new Point(332, 272);
            shadow_CheckIn.Name = "shadow_CheckIn";
            shadow_CheckIn.Size = new Size(340, 150);
            shadow_CheckIn.TabIndex = 25;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.Transparent;
            btn_Back.BackgroundImage = Properties.Resources.backbutton;
            btn_Back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Location = new Point(15, 20);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(35, 35);
            btn_Back.TabIndex = 29;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // pb_AirlineLogo
            // 
            pb_AirlineLogo.BackColor = Color.Transparent;
            pb_AirlineLogo.BackgroundImageLayout = ImageLayout.None;
            pb_AirlineLogo.Location = new Point(350, 134);
            pb_AirlineLogo.Name = "pb_AirlineLogo";
            pb_AirlineLogo.Size = new Size(300, 93);
            pb_AirlineLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_AirlineLogo.TabIndex = 30;
            pb_AirlineLogo.TabStop = false;
            // 
            // CheckInMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            Controls.Add(pb_AirlineLogo);
            Controls.Add(btn_CheckIn);
            Controls.Add(btn_Back);
            Controls.Add(shadow_CheckIn);
            Name = "CheckInMenu";
            Size = new Size(1000, 700);
            Load += CheckInMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pb_AirlineLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_CheckIn;
        private Panel shadow_CheckIn;
        private Button btn_Back;
        private PictureBox pb_AirlineLogo;
    }
}
